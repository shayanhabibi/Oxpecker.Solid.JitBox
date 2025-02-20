[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.Combobox

open Oxpecker.Solid.Lucide
open Oxpecker.Solid
open Oxpecker.Solid.Types
open Oxpecker.Solid.Kobalte
open Oxpecker.Solid.Utils

open Fable.Core.JsInterop

[<SolidComponent>]
let ComboboxItem (props: ComboboxItem) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.Combobox.Item(class'= Lib.cn [|
        "relative flex cursor-default select-none items-center justify-between rounded-sm px-2 py-1.5 text-sm outline-none data-[disabled]:pointer-events-none data-[highlighted]:bg-accent data-[highlighted]:text-accent-foreground data-[disabled]:opacity-50"
        local?``class``
    |]).spread(others)

[<SolidComponent>]
let ComboboxItemIndicator (props: ComboboxItemIndicator) =
    let local,others = Solid.splitProps(props, [|"children"|])
    Combobox.ItemIndicator().spread(others) {
         (Solid.children local) ??= unbox (Lucide.Check(class'="size-4", strokeWidth = 2)) 
    }

[<SolidComponent>]
let ComboboxSection (props: ComboboxSection) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Combobox.Section(class'= Lib.cn [|
        "overflow-hidden p-1 px-2 py-1.5 text-xs font-medium text-muted-foreground"
        local?``class``
    |]).spread(others)

[<SolidComponent>]
let ComboboxControl (props: ComboboxControl) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Combobox.Control(class' = Lib.cn [|
        "flex h-10 items-center rounded-md border px-3"
        local?``class``
    |]).spread(others)
    
[<SolidComponent>]
let ComboboxInput (props: ComboboxInput) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Combobox.Input(class' = Lib.cn [|
        "flex size-full rounded-md bg-transparent py-3 text-sm outline-none placeholder:text-muted-foreground disabled:cursor-not-allowed disabled:opacity-50"
        local?``class``
    |]).spread(others)

[<SolidComponent>]
let ComboboxTrigger (props: ComboboxTrigger) =
    let local,others = Solid.splitProps(props, [|"class" ; "children"|])
    Combobox.Trigger(class' = Lib.cn [| "size-4 opacity-50" ; local?``class`` |]).spread(others) {
        Combobox.Icon() {
            (Solid.children local) ??= unbox (Lucide.ArrowUpDown(class'="size-4"))
        }
    }

[<SolidComponent>]
let ComboboxContent (props: ComboboxContent) =
    let local,others = Solid.splitProps(props, [| "class" |])
    Combobox.Portal() {
        Combobox.Content(class' = Lib.cn [|
            "relative z-50 min-w-32 overflow-hidden rounded-md border bg-popover text-popover-foreground shadow-md animate-in fade-in-80"
            local?``class``
        |]).spread(others) {
            Combobox.Listbox(class'="m-0 p-1")
        }
    }