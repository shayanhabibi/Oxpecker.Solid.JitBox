[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.AlertDialog

open Oxpecker.Solid
open Oxpecker.Solid.Types
open Oxpecker.Solid.Kobalte
open Oxpecker.Solid.Lucide
open Fable.Core.JsInterop
open Oxpecker.Solid.Utils

[<SolidComponent>]
let AlertDialog (props: AlertDialog) = AlertDialog().spread (props)

[<SolidComponent>]
let AlertDialogTrigger (props: AlertDialogTrigger) =
    Kobalte.AlertDialog.Trigger().spread (props)

[<SolidComponent>]
let AlertDialogPortal (props: AlertDialogPortal) =
    Kobalte.AlertDialog.Portal().spread (props)

[<SolidComponent>]
let AlertDialogOverlay (props: AlertDialogOverlay) =
    let local, others = Solid.splitProps (props, [| "class" |])

    Kobalte.AlertDialog
        .Overlay(
            class' =
                Lib.cn
                    [| "fixed inset-0 z-50 bg-background/80 backdrop-blur-sm data-[expanded]:animate-in data-[closed]:animate-out data-[closed]:fade-out-0 data-[expanded]:fade-in-0"
                       local?``class`` |]
        )
        .spread (others)

[<SolidComponent>]
let AlertDialogContent (props: AlertDialogContent) =
    let local, others = Solid.splitProps (props, [| "class"; "children" |])

    Kobalte.AlertDialog.Portal() {
        Types.AlertDialogOverlay() {
            Kobalte.AlertDialog
                .Content(
                    class' =
                        Lib.cn
                            [| "fixed left-1/2 top-1/2 z-50 grid w-full max-w-lg -translate-x-1/2 -translate-y-1/2 gap-4 border bg-background p-6 shadow-lg duration-200 data-[expanded]:animate-in data-[closed]:animate-out data-[closed]:fade-out-0 data-[expanded]:fade-in-0 data-[closed]:zoom-out-95 data-[expanded]:zoom-in-95 data-[closed]:slide-out-to-left-1/2 data-[closed]:slide-out-to-top-[48%] data-[expanded]:slide-in-from-left-1/2 data-[expanded]:slide-in-from-top-[48%] sm:rounded-lg md:w-full"
                               local?``class`` |]
                )
                .spread (others) {
                Solid.children local

                Kobalte.AlertDialog.CloseButton(
                    class' =
                        "absolute right-4 top-4 rounded-sm opacity-70 ring-offset-background transition-opacity hover:opacity-100 focus:outline-none focus:ring-2 focus:ring-ring focus:ring-offset-2 disabled:pointer-events-none data-[expanded]:bg-accent data-[expanded]:text-muted-foreground"
                ) {
                    Lucide.X(strokeWidth = 2, class' = "size-4")
                    span (class' = "sr-only") { "Close" }
                }
            }
        }
    }

[<SolidComponent>]
let AlertDialogTitle (props: AlertDialogTitle) =
    let local, others = Solid.splitProps (props, [| "class" |])
    Kobalte.AlertDialog.Title(class' = Lib.cn [| "text-lg font-semibold"; local?``class`` |]).spread (others)

[<SolidComponent>]
let AlertDialogDescription (props: AlertDialogDescription) =
    let local, others = Solid.splitProps (props, [| "class" |])

    Kobalte.AlertDialog
        .Description(class' = Lib.cn [| "text-sm text-muted-foreground"; local?``class`` |])
        .spread (others)
