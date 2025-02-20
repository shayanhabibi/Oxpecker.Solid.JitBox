[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.Label

open Oxpecker.Solid.Utils
open Oxpecker.Solid
open Oxpecker.Solid.Types

open Fable.Core.JsInterop

[<SolidComponent>]
let Label (props: Label) =
    let local,others = Solid.splitProps(props, [|"class"|])
    label(class'= Lib.cn [|
        "text-sm font-medium leading-none peer-disabled:cursor-not-allowed peer-disabled:opacity-70"
        local?``class``
    |]).spread(others)