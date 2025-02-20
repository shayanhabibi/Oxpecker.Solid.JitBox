[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.HoverCard

open Oxpecker.Solid.Utils
open Oxpecker.Solid
open Oxpecker.Solid.Types
open Oxpecker.Solid.Kobalte

open Fable.Core.JsInterop

[<SolidComponent>]
let HoverCardTrigger (props: HoverCardTrigger) = HoverCard.Trigger().spread props

[<SolidComponent>]
let HoverCard (props: HoverCard) = Kobalte.HoverCard(gutter=4).spread props

[<SolidComponent>]
let HoverCardContent (props: HoverCardContent) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.HoverCard.Portal() {
        Kobalte.HoverCard.Content(class' = Lib.cn [|
            "z-50 w-64 rounded-md border bg-popover p-4 text-popover-foreground
            shadow-md outline-none data-[state=open]:animate-in data-[state=closed]:animate-out
            data-[state=closed]:fade-out-0 data-[state=open]:fade-in-0
            data-[state=closed]:zoom-out-95 data-[state=open]:zoom-in-95
            data-[side=bottom]:slide-in-from-top-2 data-[side=left]:slide-in-from-right-2
            data-[side=right]:slide-in-from-left-2 data-[side=top]:slide-in-from-bottom-2"
            local?``class``
        |]).spread(others)
    }