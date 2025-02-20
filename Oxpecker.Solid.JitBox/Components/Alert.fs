[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.Alert

open Oxpecker.Solid
open Oxpecker.Solid.Types
open Oxpecker.Solid.Kobalte
open Oxpecker.Solid.Utils
open Fable.Core.JsInterop

let alertVariants =
    Lib.cva
        "relative w-full rounded-lg border p-4 [&>svg+div]:translate-y-[-3px] [&>svg]:absolute [&>svg]:left-4 [&>svg]:top-4 [&>svg]:text-foreground [&>svg~*]:pl-7"
        {| variants =
            {| variant =
                {| ``default`` = "bg-background text-foreground"
                   destructive =
                    "border-destructive/50 text-destructive dark:border-destructive [&>svg]:text-destructive" |} |}
           defaultVariants = {| variant = "default" |} |}


[<SolidComponent>]
let Alert (props: Alert) =
    let local,others = Solid.splitProps(props,[|"class";"variant"|])
    Alert( class'= Lib.cn [| alertVariants({|variant= props?variant|}); local?``class`` |]).spread(others)

[<SolidComponent>]
let AlertTitle (props: AlertTitle) =
    let local,others = Solid.splitProps(props, [|"class"|])
    h5(class'=Lib.cn [| "mb-1 font-medium leading-none tracking-tight"; local?``class`` |]).spread(others)

[<SolidComponent>]
let AlertDescription (props: AlertDescription) =
    let local,others = Solid.splitProps(props, [|"class"|])
    div(class'=Lib.cn[|"text-sm [&_p]:leading-relaxed"; local?``class``|]).spread(others)