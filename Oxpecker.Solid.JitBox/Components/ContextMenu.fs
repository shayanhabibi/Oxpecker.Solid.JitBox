[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.ContextMenu

open Oxpecker.Solid.Lucide
open Oxpecker.Solid
open Oxpecker.Solid.Types
open Oxpecker.Solid.Kobalte
open Oxpecker.Solid.Utils

open Fable.Core.JsInterop

[<SolidComponent>]
let ContextMenuTrigger (props: ContextMenuTrigger) = ContextMenu.Trigger().spread(props)
[<SolidComponent>]
let ContextMenuPortal (props: ContextMenuPortal) = ContextMenu.Portal().spread(props)
[<SolidComponent>]
let ContextMenuSub (props: ContextMenuSub) = ContextMenu.Sub().spread(props)
[<SolidComponent>]
let ContextMenuGroup(props: ContextMenuGroup) = ContextMenu.Group().spread(props)
[<SolidComponent>]
let ContextMenuRadioGroup(props: ContextMenuRadioGroup) = ContextMenu.RadioGroup().spread(props)

[<SolidComponent>]
let ContextMenu (props: ContextMenu) = Kobalte.ContextMenu(gutter=4).spread(props)

[<SolidComponent>]
let ContextMenuContent (props: ContextMenuContent) =
    let local,others = Solid.splitProps(props,[|"class"|])
    Kobalte.ContextMenu.Portal() {
        Kobalte.ContextMenu.Content(class'= Lib.cn [|
            "z-50 min-w-32 origin-[var(--kb-menu-content-transform-origin)] overflow-hidden rounded-md border bg-popover p-1 text-popover-foreground shadow-md animate-in"
            local?``class``
        |]).spread(others)
    }

[<SolidComponent>]
let ContextMenuItem (props: ContextMenuItem) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.ContextMenu.Item(
        class' = Lib.cn [|
            "relative flex cursor-default select-none items-center rounded-sm px-2 py-1.5 text-sm outline-none transition-colors focus:bg-accent focus:text-accent-foreground data-[disabled]:pointer-events-none data-[disabled]:opacity-50"
            local?``class``
        |]).spread(others)

[<SolidComponent>]
let ContextMenuShortcut (props: ContextMenuShortcut) =
    let local,others = Solid.splitProps(props, [|"class"|])
    span(class'= Lib.cn [| "ml-auto text-xs tracking-widest opacity-60"; local?``class`` |]).spread(others)

[<SolidComponent>]
let ContextMenuSeparator (props: ContextMenuSeparator) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.ContextMenu.Separator(
        class' = Lib.cn [|
            "-mx-1 my-1 h-px bg-muted"
            local?``class``
        |]
    ).spread(others)

[<SolidComponent>]
let ContextMenuSubTrigger (props: ContextMenuSubTrigger) =
    let local,others = Solid.splitProps(props, [|"class"; "children"|])
    Kobalte.ContextMenu.SubTrigger(class'= Lib.cn [|
        "flex cursor-default select-none items-center rounded-sm px-2 py-1.5 text-sm outline-none focus:bg-accent data-[state=open]:bg-accent"
        local?``class``
    |]).spread(others) {
        Solid.children local
        Lucide.ChevronRight(class'="ml-auto size-4", strokeWidth = 2)
    }

[<SolidComponent>]
let ContextMenuSubContent (props: ContextMenuSubContent) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.ContextMenu.SubContent(class'= Lib.cn [|
        "z-50 min-w-32 origin-[var(--kb-menu-content-transform-origin)] overflow-hidden rounded-md border bg-popover p-1 text-popover-foreground shadow-md animate-in"
        local?``class``
    |]).spread(others)
    
[<SolidComponent>]
let ContextMenuCheckboxItem (props: ContextMenuCheckboxItem) =
    let local,others = Solid.splitProps(props, [|"class" ; "children"|])
    Kobalte.ContextMenu.CheckboxItem(class'= Lib.cn [|
        "relative flex cursor-default select-none items-center rounded-sm py-1.5 pl-8 pr-2 text-sm outline-none transition-colors focus:bg-accent focus:text-accent-foreground data-[disabled]:pointer-events-none data-[disabled]:opacity-50"
        local?``class``
    |]).spread(others) {
        span(class'= "absolute left-2 flex size-3.5 items-center justify-center") {
            Kobalte.ContextMenu.ItemIndicator() {
                Lucide.Check(class'="size-4", strokeWidth = 2)
            }
        }
        Solid.children local
    }

[<SolidComponent>]
let ContextMenuGroupLabel (props: ContextMenuGroupLabel) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.ContextMenu.GroupLabel(class' = Lib.cn [|"px-2 py-1.5 text-sm font-semibold"; local?``class``|]).spread(others)

[<SolidComponent>]
let ContextMenuRadioItem (props: ContextMenuRadioItem) =
    let local,others = Solid.splitProps(props, [|"class"; "children"|])
    Kobalte.ContextMenu.RadioItem(class'= Lib.cn [|
        "relative flex cursor-default select-none items-center rounded-sm py-1.5 pl-8 pr-2 text-sm outline-none transition-colors focus:bg-accent focus:text-accent-foreground data-[disabled]:opacity-50"
        local?``class``
    |]).spread(others) {
        span(class'="absolute left-2 flex size-3.5 items-center justify-center") {
            Kobalte.ContextMenu.ItemIndicator() {
                Lucide.Circle(class'="size-2 fill-current", strokeWidth = 2)
            }
        }
        Solid.children local
    }