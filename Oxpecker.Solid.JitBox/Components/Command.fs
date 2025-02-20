[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.Command

open Oxpecker.Solid
open Oxpecker.Solid.Types
open Oxpecker.Solid.Cmdk
open Oxpecker.Solid.Utils

open Fable.Core.JsInterop

[<SolidComponent>]
let Command (props: Command) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Cmdk.Command(
        class'= Lib.cn [|
        "flex size-full flex-col overflow-hidden rounded-md bg-popover text-popover-foreground blur-none"
        local?``class``
    |]
    ).spread(others)

[<SolidComponent>]
let CommandDialog (props: CommandDialog) =
    let local,others = Solid.splitProps(props, [|"children"|])
    Dialog().spread(others) {
        DialogContent(class'="overflow-hidden p-0") {
            Types.Command(class' = "[&_[cmdk-group-heading]]:px-2 [&_[cmdk-group-heading]]:font-medium [&_[cmdk-group-heading]]:text-muted-foreground [&_[cmdk-group]:not([hidden])_~[cmdk-group]]:pt-0 [&_[cmdk-input-wrapper]_svg]:size-5 [&_[cmdk-input]]:h-12 [&_[cmdk-item]]:px-2 [&_[cmdk-item]]:py-3 [&_[cmdk-item]_svg]:size-5") {
                Solid.children local
            }
        }
    }

[<SolidComponent>]
let CommandInput (props: CommandInput) =
    let local,others = Solid.splitProps(props, [|"class"|])
    div(class'="flex items-center border-b px-3").attr("cmdk-input-wrapper", "") {
        Lucide.Lucide.Search(class'="mr-2 size-4 shrink-0 opacity-50", strokeWidth = 2)
        Cmdk.Command.Input(class'= Lib.cn [|
            "flex h-10 w-full rounded-md bg-transparent py-3 text-sm outline-none placeholder:text-muted-foreground disabled:cursor-not-allowed disabled:opacity-50"
            local?``class``
        |]).spread(others)
    }
    
[<SolidComponent>]
let CommandList (props: CommandList) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Cmdk.Command.List(class'= Lib.cn [|
        "max-h-[300px] overflow-y-auto overflow-x-hidden"
        local?``class``
    |]).spread(others)

[<SolidComponent>]
let CommandEmpty (props: CommandEmpty) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Cmdk.Command.Empty(class' = Lib.cn [|"py-6 text-center text-sm"; local?``class``|]
    ).spread(others)

[<SolidComponent>]
let CommandGroup (props: CommandGroup) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Cmdk.Command.Group(class'= Lib.cn [|
        "overflow-hidden p-1 text-foreground [&_[cmdk-group-heading]]:px-2 [&_[cmdk-group-heading]]:py-1.5 [&_[cmdk-group-heading]]:text-xs [&_[cmdk-group-heading]]:font-medium [&_[cmdk-group-heading]]:text-muted-foreground"
        local?``class``
    |]).spread(others)

[<SolidComponent>]
let CommandSeparator (props: CommandSeparator) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Cmdk.Command.Separator(class' = Lib.cn [|
        "h-px bg-border"
        local?``class``
    |]).spread(others)

[<SolidComponent>]
let CommandItem (props: CommandItem) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Cmdk.Command.Item(class' = Lib.cn [|
        "relative flex cursor-default select-none items-center rounded-sm px-2 py-1.5 text-sm outline-none aria-selected:bg-accent aria-selected:text-accent-foreground data-[disabled=true]:pointer-events-none data-[disabled=true]:opacity-50"
        local?``class``
    |]).spread(others)

[<SolidComponent>]
let CommandShortcut (props: CommandShortcut) =
    let local,others = Solid.splitProps(props, [|"class"|])
    span( class' = Lib.cn [| "ml-auto text-xs tracking-widest text-muted-foreground"; local?``class`` |]).spread(others)