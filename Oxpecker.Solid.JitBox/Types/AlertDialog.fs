namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Oxpecker.Solid.Kobalte
open Fable.Core

[<Global>]
type AlertDialog() =
    inherit Kobalte.AlertDialog()

[<Global>]
type AlertDialogTrigger() =
    inherit AlertDialog.Trigger()

[<Global>]
type AlertDialogPortal() =
    inherit AlertDialog.Portal()

[<Global>]
type AlertDialogOverlay() =
    inherit AlertDialog.Overlay()

[<Global>]
type AlertDialogContent() =
    inherit AlertDialog.Content()

[<Global>]
type AlertDialogTitle() =
    inherit AlertDialog.Title()

[<Global>]
type AlertDialogDescription() =
    inherit AlertDialog.Description()