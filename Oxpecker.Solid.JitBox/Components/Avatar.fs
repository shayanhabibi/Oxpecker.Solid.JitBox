[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.Avatar

open Oxpecker.Solid
open Oxpecker.Solid.Types
open Oxpecker.Solid.Kobalte
open Fable.Core.JsInterop
open Oxpecker.Solid.Utils

[<SolidComponent>]
let Avatar (props: Avatar) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.Image(class'=Lib.cn [|
        "relative flex size-10 shrink-0 overflow-hidden rounded-full"
        local?``class``
    |]).spread(others)

[<SolidComponent>]
let AvatarImage (props: AvatarImage) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.Image.Img(class' = Lib.cn [|
        "aspect-square size-full"
        local?``class``
    |]).spread(others)

[<SolidComponent>]
let AvatarFallback (props: AvatarFallback) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Image.Fallback(class'=Lib.cn [|
        "flex size-full items-center justify-center bg-muted"
        local?``class``
    |]).spread(others)
