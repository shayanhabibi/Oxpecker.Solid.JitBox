namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Oxpecker.Solid.Kobalte
open Fable.Core

[<Global>]
type Dialog() =
    inherit Kobalte.Dialog()

[<Global>]
type DialogTrigger() =
    inherit Dialog.Trigger()

[<Global>]
type DialogPortal() =
    inherit Dialog.Portal()

[<Global>]
type DialogOverlay() =
    inherit Dialog.Overlay()
    
[<Global>]
type DialogContent() =
    inherit Dialog.Content()

[<Global>]
type DialogHeader() =
    inherit div()
    
[<Global>]
type DialogFooter() =
    inherit div()

[<Global>]
type DialogTitle() =
    inherit Dialog.Title()

[<Global>]
type DialogDescription() =
    inherit Dialog.Description()