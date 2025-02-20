[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.Card

open Oxpecker.Solid
open Oxpecker.Solid.Types
open Fable.Core.JsInterop
open Oxpecker.Solid.Utils

[<SolidComponent>]
let Card (props: Card) =
    let local,others = Solid.splitProps(props, [|"class"|])
    div(class'= Lib.cn [|"rounded-lg border bg-card text-card-foreground shadow-sm"; local?``class``|]).spread(others)

[<SolidComponent>]
let CardHeader (props: CardHeader) =
    let local,others = Solid.splitProps(props, [|"class"|])
    div(class'=Lib.cn [| "flex flex-col space-y-1.5 p-6"; local?``class`` |]).spread(others)

[<SolidComponent>]
let CardTitle (props: CardTitle) =
    let local,others = Solid.splitProps(props, [|"class"|])
    h3(class'= Lib.cn [|"text-lg font-semibold leading-none tracking-tight"; local?``class``|]).spread(others)

[<SolidComponent>]
let CardDescription (props: CardDescription) =
    let local,others = Solid.splitProps(props, [|"class"|])
    p(class'= Lib.cn [| "text-sm text-muted-foreground"; local?``class`` |]).spread(others)
    
[<SolidComponent>]
let CardContent (props: CardContent)=
    let local,others = Solid.splitProps(props, [|"class"|])
    div(class' = Lib.cn [|"p-6 pt-0"; local?``class``|]).spread(others)

[<SolidComponent>]
let CardFooter (props: CardFooter) =
    let local,others = Solid.splitProps(props, [|"class"|])
    div(class'= Lib.cn [| "flex items-center p-6 pt-0"; local?``class`` |]).spread(others)