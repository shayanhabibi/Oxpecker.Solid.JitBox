[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.Callout

open Oxpecker.Solid
open Oxpecker.Solid.Types
open Oxpecker.Solid.Utils
open Fable.Core.JsInterop

let calloutVariants =
    Lib.cva
        "rounded-md border-l-4 p-2 pl-4"
        {| variants =
            {| variant =
                {| ``default`` = "border-info-foreground bg-info text-info-foreground"
                   success = "border-success-foreground bg-success text-success-foreground"
                   warning = "border-warning-foreground bg-warning text-warning-foreground"
                   error = "border-error-foreground bg-error text-error-foreground" |} |}
           defaultVariants = {| variant = "default" |} |}

[<SolidComponent>]
let Callout (props: Callout) =
    let local,others = Solid.splitProps(props, [|"class" ; "variant"|])
    div(
        class' = Lib.cn [|
            calloutVariants({| variant = local?variant |})
            local?``class``
        |]
    ).spread(others)

[<SolidComponent>]
let CalloutTitle (props: CalloutTitle) =
    let local,others = Solid.splitProps(props, [| "class" |])
    h3(
        class' = Lib.cn [| "font-semibold" ; local?``class`` |]    
    ).spread(others)

[<SolidComponent>]
let CalloutContent (props: CalloutContent) =
    let local,others = Solid.splitProps(props, [|"class"|])
    div(class'=Lib.cn [| "mt-2"; local?``class`` |]).spread(others)