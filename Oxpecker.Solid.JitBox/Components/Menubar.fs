[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.Menubar

open Oxpecker.Solid.Utils
open Oxpecker.Solid
open Oxpecker.Solid.Types
open Oxpecker.Solid.Kobalte
open Fable.Core.JsInterop

[<SolidComponent>]
let MenubarGroup (props: MenubarGroup) = Menubar.Group().spread props
[<SolidComponent>]
let MenubarPortal (props: MenubarPortal) = Menubar.Portal().spread props
[<SolidComponent>]
let MenubarSub (props: MenubarSub) = Menubar.Sub().spread props
[<SolidComponent>]
let MenubarRadioGroup (props: MenubarRadioGroup) = Menubar.RadioGroup().spread props

[<SolidComponent>]
let Menubar (props: Menubar) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.Menubar(class'= Lib.cn [|
        "flex h-10 items-center space-x-1 rounded-md border bg-background p-1"
        local?``class``
    |]).spread others

[<SolidComponent>]
let MenubarTrigger (props: MenubarTrigger) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.Menubar.Trigger(class' = Lib.cn [|
        "flex cursor-default select-none items-center rounded-sm px-3 py-1.5 text-sm font-medium
        outline-none focus:bg-accent focus:text-accent-foreground data-[state=open]:bg-accent
        data-[state=open]:text-accent-foreground"
        local?``class``
    |]).spread others

[<SolidComponent>]
let MenubarContent (props: MenubarContent) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Types.MenubarPortal() {
        Kobalte.Menubar.Content(class' = Lib.cn [|
            "z-50 min-w-48 origin-[var(--kb-menu-content-transform-origin)] animate-content-hide
            overflow-hidden rounded-md border bg-popover p-1 text-popover-foreground shadow-md data-[expanded]:animate-content-show"
            local?``class``
        |]).spread others
    }

[<SolidComponent>]
let MenubarSubTrigger (props: MenubarSubTrigger) =
    let local,others = Solid.splitProps(props, [|
        "class"; "children"; "inset"
    |])
    Kobalte.Menubar.SubTrigger(class'=Lib.cn [|
        "flex cursor-default select-none items-center rounded-sm px-2 py-1.5 text-sm outline-none focus:bg-accent focus:text-accent-foreground data-[state=open]:bg-accent data-[state=open]:text-accent-foreground"
        local.inset &&= "pl-8"
        local?``class``
    |]).spread(others) {
        Solid.children local
        Lucide.Lucide.ChevronRight(class' = "ml-auto size-4", strokeWidth = 2)
    }

[<SolidComponent>]
let MenubarSubContent (props: MenubarSubContent) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Types.MenubarPortal() {
        Kobalte.Menubar.SubContent(class' = Lib.cn [|
            "z-50 min-w-32 origin-[var(--kb-menu-content-transform-origin)] overflow-hidden rounded-md border bg-popover p-1 text-popover-foreground shadow-md animate-in"
            local?``class``
        |]).spread(others)
    }

[<SolidComponent>]
let MenubarItem (props: MenubarItem) =
    let local,others = Solid.splitProps(props, [|"class"; "inset"|])
    Kobalte.Menubar.Item(
        class' = Lib.cn [|
            "relative flex cursor-default select-none items-center rounded-sm px-2 py-1.5 text-sm outline-none focus:bg-accent focus:text-accent-foreground data-[disabled]:pointer-events-none data-[disabled]:opacity-50"
            local.inset &&= "pl-8"
            local?``class``
        |]).spread(others)

[<SolidComponent>]
let MenubarCheckboxItem (props: MenubarCheckboxItem) =
    let local,others = Solid.splitProps(props, [|"class"; "children"|])
    Kobalte.Menubar.CheckboxItem(class'= Lib.cn [|
        "relative flex cursor-default select-none items-center rounded-sm py-1.5 pl-8 pr-2 text-sm outline-none focus:bg-accent focus:text-accent-foreground data-[disabled]:pointer-events-none data-[disabled]:opacity-50"
        local?``class``
    |]).spread(others) {
        span(class'="absolute left-2 flex size-3.5 items-center justify-center") {
            Kobalte.Menubar.ItemIndicator() {
                Lucide.Lucide.Check(class'="size-4",strokeWidth = 2)
            }
        }
        Solid.children local
    }

[<SolidComponent>]
let MenubarRadioItem (props: MenubarRadioItem) =
    let local,others = Solid.splitProps(props, [|"class"; "children"|])
    Kobalte.Menubar.RadioItem(class' = Lib.cn [|
        "relative flex cursor-default select-none items-center rounded-sm py-1.5 pl-8 pr-2 text-sm outline-none focus:bg-accent focus:text-accent-foreground data-[disabled]:pointer-events-none data-[disabled]:opacity-50"
        local?``class``
    |]).spread(others) {
        span(class'="absolute left-2 flex size-3.5 items-center justify-center") {
            Lucide.Lucide.Circle(class'="size-2 fill-current", strokeWidth=2)
        }
        Solid.children local
    }

[<SolidComponent>]
let MenubarItemLabel (props: MenubarItemLabel) =
    let local,others = Solid.splitProps(props, [|"class"; "inset"|])
    Kobalte.Menubar.ItemLabel(class'=Lib.cn [|
        "px-2 py-1.5 text-sm font-semibold"
        local.inset &&= "pl-8"
        local?``class``
    |]).spread(others)

[<SolidComponent>]
let MenubarGroupLabel (props: MenubarGroupLabel) =
    let local,others = Solid.splitProps(props, [|"class";"inset"|])
    Kobalte.Menubar.GroupLabel(class' = Lib.cn [|
        "px-2 py-1.5 text-sm font-semibold"
        local.inset &&= "pl-8"
        local?``class``
    |]).spread(others)

[<SolidComponent>]
let MenubarSeparator (props: MenubarSeparator) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.Menubar.Separator(class'=Lib.cn [|"-mx-1 my-1 h-px bg-muted"; local?``class``|]).spread(others)
    
[<SolidComponent>]
let MenubarShortcut (props: MenubarShortcut) =
    let local,others = Solid.splitProps(props, [|"class"|])
    span(class' = Lib.cn [|
        "ml-auto text-xs tracking-widest text-muted-foreground"
        local?``class``
    |]).spread others
