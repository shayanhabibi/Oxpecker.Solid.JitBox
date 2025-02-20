[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.DropdownMenu

open Oxpecker.Solid.Lucide
open Oxpecker.Solid
open Oxpecker.Solid.Types
open Oxpecker.Solid.Kobalte
open Oxpecker.Solid.Utils

open Fable.Core.JsInterop

[<SolidComponent>]
let DropdownMenuTrigger (props: DropdownMenuTrigger) = DropdownMenu.Trigger().spread(props)
[<SolidComponent>]
let DropdownMenuPortal (props: DropdownMenuPortal) = DropdownMenu.Portal().spread(props)
[<SolidComponent>]
let DropdownMenuSub (props: DropdownMenuSub) = DropdownMenu.Sub().spread(props)
[<SolidComponent>]
let DropdownMenuGroup (props: DropdownMenuGroup) = DropdownMenu.Group().spread(props)
[<SolidComponent>]
let DropdownMenuRadioGroup (props: DropdownMenuRadioGroup) = DropdownMenu.RadioGroup().spread(props)

[<SolidComponent>]
let DropdownMenu (props: DropdownMenu) = Kobalte.DropdownMenu(gutter=4).spread(props)

[<SolidComponent>]
let DropdownMenuContent (props: DropdownMenuContent) =
    let _,rest = Solid.splitProps(props, [|"class"|])
    Types.DropdownMenuPortal() {
        Kobalte.DropdownMenu.Content(class' = Lib.cn [|
            "z-50 min-w-32 origin-[var(--kb-menu-content-transform-origin)] animate-content-hide
            overflow-hidden rounded-md border bg-popover p-1 text-popover-foreground shadow-md
            data-[expanded]:animate-content-show"
            props?``class``
        |]).spread(rest)
    }

[<SolidComponent>]
let DropdownMenuItem (props: DropdownMenuItem) =
    let _,rest = Solid.splitProps(props, [|"class"|])
    Kobalte.DropdownMenu.Item(class'= Lib.cn [|
        "relative flex cursor-default select-none items-center
        gap-2 rounded-sm px-2 py-1.5 text-sm outline-none transition-colors
        focus:bg-accent focus:text-accent-foreground data-[disabled]:pointer-events-none
        data-[disabled]:opacity-50"
        props?``class``
    |]).spread(rest)
    
[<SolidComponent>]
let DropdownMenuShortcut (props: DropdownMenuShortcut) =
    let _,rest = Solid.splitProps(props, [|"class"|])
    span(class'= Lib.cn [| "ml-auto text-xs tracking-widest opacity-60"; props?``class`` |]).spread(rest)

[<SolidComponent>]
let DropdownMenuLabel (props: DropdownMenuLabel) =
    let _,rest = Solid.splitProps(props, [|"class"; "inset"|])
    div(class'= Lib.cn [|
        "px-2 py-1.5 text-sm font-semibold"
        props.inset &&= "pl-8"
    |]).spread(rest)

[<SolidComponent>]
let DropdownMenuSeparator (props: DropdownMenuSeparator) =
    let _,rest = Solid.splitProps(props, [|"class"|])
    Kobalte.DropdownMenu.Separator(class'= Lib.cn [|
        "-mx-1 my-1 h-px bg-muted"
        props?``class``
    |]).spread(rest)