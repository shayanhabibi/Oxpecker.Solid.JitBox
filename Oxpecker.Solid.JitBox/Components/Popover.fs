[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.Popover

open Oxpecker.Solid.Utils
open Oxpecker.Solid
open Oxpecker.Solid.Types
open Oxpecker.Solid.Kobalte
open Fable.Core.JsInterop

[<SolidComponent>]
let PopoverTrigger (props: PopoverTrigger) = Kobalte.Popover.Trigger().spread(props)
[<SolidComponent>]
let Popover (props: Popover) = Kobalte.Popover(gutter=4).spread(props)
[<SolidComponent>]
let PopoverContent (props: PopoverContent) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.Popover.Portal() {
        Kobalte.Popover.Content(class' = Lib.cn [|
            "z-50 w-72 origin-[var(--kb-popover-content-transform-origin)] rounded-md border bg-popover p-4 text-popover-foreground shadow-md outline-none data-[expanded]:animate-in data-[closed]:animate-out data-[closed]:fade-out-0 data-[expanded]:fade-in-0 data-[closed]:zoom-out-95 data-[expanded]:zoom-in-95"
            local?``class``
        |]).spread(others)
    }