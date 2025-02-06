namespace Oxpecker.Solid.Lucide.Generator

open FParsec
open System

[<AutoOpen>]
module Helpers =
    // Attributable to Shmew - taken from Feliz.Generator.MaterialUI/Common.fs
    let appendApostropheToReservedKeywords =
      let reserved =
        [
          "checked"; "static"; "fixed"; "inline"; "default"; "component";
          "inherit"; "open"; "type"; "true"; "false"; "in"; "end"; "global"
        ]
        |> Set.ofList
      fun s -> if reserved.Contains s then s + "'" else s
      
module LabParsers =
    let find value skip = skipCharsTillString value skip Int32.MaxValue >>. spaces
    let findCI value skip = skipCharsTillStringCI value skip Int32.MaxValue >>. spaces
    let findValidDeclaration : Parser<_,_> = manyTill (find "declare" true >>. spaces ) ( followedBy (pstring "const") >>. pstring "const" )
    let readIdentifier : Parser<_,_> = manyCharsTill (letter <|> digit ) (anyOf ": ")
    // Lucide Lab Parsers
    let getNextIconDecl : Parser<_,_> = findValidDeclaration >>. spaces >>. readIdentifier
    let getDecls : Parser<_,_> = manyTill (getNextIconDecl) (notFollowedBy ( find "declare" true ))

module LabGenerator =
      
    let parseIdentifiers target =
        runParserOnFile LabParsers.getDecls () target (System.Text.UTF8Encoding())
        |> function
            | Success(result, _, _) -> result
            | Failure(errorMsg,_,_) -> printfn $"{errorMsg}" |> exit 1

    let renderIdentifierMember identifier =
        $"""
    static member inline {identifier} : LucideLab = unbox "{identifier}" """
    
    let renderDocument parsedIdentifiers =
        [
            """
namespace Oxpecker.Solid.Lucide

// THIS FILE IS AUTO-GENERATED

open Oxpecker.Solid
open Fable.Core

[<AutoOpen; System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]
module LucideLabHelpers =    
    let [<Literal>] LucideIconsLab = "@lucide/lab"

[<Erase>]
type LucideLab ="""
            for ( identifier : string ) in parsedIdentifiers do
                renderIdentifierMember ( identifier |> appendApostropheToReservedKeywords )
            """
[<Erase;Import("Icon",LucideIcons)>]
type Icon() =
    inherit IconNode()
    member val iconNode : LucideLab = jsNative with get,set
"""
        ] |> String.concat ""

module LucideParser =
    let find value = skipCharsTillString value true Int32.MaxValue >>. spaces
    let findDeclaration = manyTill ( find "declare" ) ( followedBy (pstring "const") ) >>. pstring "const" >>. spaces
    let getIdentifier = manyCharsTill ( letter <|> digit <|> anyOf "_" ) ( anyOf " :" )
    let getIdentifierOfType type' = manyTill findDeclaration ( followedBy (getIdentifier >>. skipAnyOf " :" >>. pstring type') ) >>. getIdentifier
    let parser = manyTill (getIdentifierOfType "react") (notFollowedBy findDeclaration)

module LucideGenerator =
    let parseIdentifiers target =
        runParserOnFile LucideParser.parser () target (System.Text.UTF8Encoding())
        |> function
            | Success(result, _, _) -> result
            | Failure(errorMsg,_,_) -> printfn $"{errorMsg}" |> exit 1

    let renderIdentifierMember identifier =
        $"""
    [<Erase; Import("{identifier}", LucideIcons)>]
    type {identifier}() =
        inherit IconNode()"""
    let renderDocument parsedIdentifiers =
        [
            """
namespace Oxpecker.Solid.Lucide

// THIS FILE IS AUTO GENERATED

open Oxpecker.Solid
open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type IconNode() =
    inherit VoidNode()
    member inline this.className with get (value : string) = this.class' <- value
    member val size : int = jsNative with get,set
    member val color : string = jsNative with get,set
    member val strokeWidth : int = jsNative with get,set
    member val absoluteStrokeWidth : bool = jsNative with get,set

[<AutoOpen; System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]
module [<Erase>] Helpers =
    let [<Literal>] LucideIcons = "lucide-solid"

module Lucide ="""
            for ( identifier : string ) in parsedIdentifiers do
                if identifier <> "Icon" then
                    renderIdentifierMember ( identifier |> appendApostropheToReservedKeywords )
        ] |> String.concat ""
    

open System.IO

module Program =
    [<EntryPoint>]
    let main argv =
        LabGenerator.parseIdentifiers "../node_modules/@lucide/lab/dist/lucide-lab.d.ts"
        |> LabGenerator.renderDocument
        |> fun render -> File.WriteAllText(@"..\Oxpecker.Solid.Lucide\LucideLab.fs", render)
        LucideGenerator.parseIdentifiers "../node_modules/lucide-react/dist/lucide-react.d.ts"
        |> LucideGenerator.renderDocument
        |> fun render -> File.WriteAllText(@"..\Oxpecker.Solid.Lucide\Lucide.fs", render)
        printfn "Completed"
        0