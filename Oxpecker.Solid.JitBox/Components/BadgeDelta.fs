[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.BadgeDelta

open Oxpecker.Solid
open Oxpecker.Solid.Lucide
open Oxpecker.Solid.Types
open Oxpecker.Solid.Utils
open Fable.Core.JsInterop
open Fable.Core

[<StringEnum>]
type DeltaType =
    | Increase
    | ModerateIncrease
    | Unchanged
    | ModerateDecrease
    | Decrease

let badgeDeltaVariants =
    Lib.cva "" {|
        variants = {|
            variant = {|
                success="bg-success text-success-foreground hover:bg-success"
                warning="bg-warning text-warning-foreground hover:bg-warning"
                error="bg-error text-error-foreground hover:bg-error"
            |}
        |}             
    |}

let iconMap class' delta : HtmlElement =
    match delta with
    | Increase -> Lucide.ArrowUp(class'=class')
    | ModerateIncrease -> Lucide.ArrowUpRight(class'=class')
    | Unchanged -> Lucide.ArrowRight(class'=class')
    | ModerateDecrease -> Lucide.ArrowDownRight(class'=class')
    | Decrease -> Lucide.ArrowDown(class'=class')
let variantMap delta : string =
    match delta with
    | ModerateIncrease
    | Increase -> badgeDeltaVariants({|variant="success"|})
    | Unchanged -> badgeDeltaVariants({|variant= "warning" |})
    | ModerateDecrease
    | Decrease -> badgeDeltaVariants({|variant="error"|})

[<SolidComponent>]
let BadgeDelta (props: BadgeDelta) =
    let local,others = Solid.splitProps(props, [|"class"; "children"; "deltaType"|])
    let icon () = iconMap "size-4" local?deltaType
    Badge(class'= Lib.cn [|
        variantMap local?badgeDelta
        local?``class``
    |] ).spread(others) {
        span(class'="flex gap-1") {
            icon ()
            Solid.children local
        }
    }