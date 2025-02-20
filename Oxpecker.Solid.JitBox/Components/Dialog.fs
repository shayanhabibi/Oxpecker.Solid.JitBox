[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.Dialog

open Oxpecker.Solid
open Oxpecker.Solid.Types
open Oxpecker.Solid.Kobalte
open Oxpecker.Solid.Utils
open Fable.Core.JsInterop

[<SolidComponent>]
let Dialog (props: Dialog) = Kobalte.Dialog().spread (props)

[<SolidComponent>]
let DialogTrigger (props: DialogTrigger) = Kobalte.Dialog.Trigger().spread (props)

[<SolidComponent>]
let DialogPortal (props: DialogPortal) =
    let _, rest = Solid.splitProps (props, [| "children" |])

    Kobalte.Dialog.Portal().spread (rest) {
        div (class' = "fixed inset-0 z-50 flex items-start justify-center sm:items-center") { Solid.children props }
    }

[<SolidComponent>]
let DialogOverlay (props: DialogOverlay) =
    let _, rest = Solid.splitProps (props, [| "class" |])

    Kobalte.Dialog
        .Overlay(
            class' =
                Lib.cn
                    [| "fixed inset-0 z-50 bg-background/80 backdrop-blur-sm data-[expanded]:animate-in data-[closed]:animate-out data-[closed]:fade-out-0 data-[expanded]:fade-in-0"
                       props?``class`` |]
        )
        .spread (rest)

[<SolidComponent>]
let DialogContent (props: DialogContent) =
    let _, rest = Solid.splitProps (props, [| "class"; "children" |])

    Types.DialogPortal() {
        Types.DialogOverlay() {}

        Kobalte.Dialog
            .Content(
                class' =
                    Lib.cn
                        [| "fixed left-1/2 top-1/2 z-50 grid max-h-screen w-full max-w-lg -translate-x-1/2 -translate-y-1/2 gap-4 overflow-y-auto border bg-background p-6 shadow-lg duration-200 data-[expanded]:animate-in data-[closed]:animate-out data-[closed]:fade-out-0 data-[expanded]:fade-in-0 data-[closed]:zoom-out-95 data-[expanded]:zoom-in-95 data-[closed]:slide-out-to-left-1/2 data-[closed]:slide-out-to-top-[48%] data-[expanded]:slide-in-from-left-1/2 data-[expanded]:slide-in-from-top-[48%] sm:rounded-lg"
                           props?``class`` |]
            )
            .spread (rest) {
            Kobalte.Dialog.CloseButton(
                class' =
                    "absolute right-4 top-4 rounded-sm opacity-70 ring-offset-background transition-opacity hover:opacity-100 focus:outline-none focus:ring-2 focus:ring-ring focus:ring-offset-2 disabled:pointer-events-none data-[expanded]:bg-accent data-[expanded]:text-muted-foreground"
            ) {
                Lucide.Lucide.X(class' = "size-4")
                span (class' = "sr-only") { "Close" }
            }
        }
    }

[<SolidComponent>]
let DialogHeader (props: DialogHeader) =
    let _,rest = Solid.splitProps(props, [|"class"|])
    div(class'= Lib.cn [|
        "flex flex-col space-y-1.5 text-center sm:text-left"
        props?``class``
    |]).spread(rest)

[<SolidComponent>]
let DialogFooter (props: DialogFooter) =
    let _,rest = Solid.splitProps(props, [|"class"|])
    div(class'= Lib.cn [|
        "flex flex-col-reverse sm:flex-row sm:justify-end sm:space-x-2"
        props?``class``
    |]).spread(rest)

[<SolidComponent>]
let DialogTitle (props: DialogTitle) =
    let _,rest = Solid.splitProps(props, [|"class"|])
    Kobalte.Dialog.Title(class'= Lib.cn [|
        "text-lg font-semibold leading-none tracking-tight"
        props?``class``
    |]).spread(rest)

[<SolidComponent>]
let DialogDescription (props: DialogDescription) =
    let _,rest = Solid.splitProps(props, [|"class"|])
    Kobalte.Dialog.Description(class'= Lib.cn [| "text-sm text-muted-foreground"; props?``class`` |]).spread(rest)