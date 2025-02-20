namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Oxpecker.Solid.Kobalte
open Fable.Core

[<Global>]
type DropdownMenuTrigger() =
    inherit DropdownMenu.Trigger()
[<Global>]
type DropdownMenuPortal() =
    inherit DropdownMenu.Portal()
[<Global>]
type DropdownMenuSub() =
    inherit DropdownMenu.Sub()
[<Global>]
type DropdownMenuGroup() =
    inherit DropdownMenu.Group()
[<Global>]
type DropdownMenuRadioGroup() =
    inherit DropdownMenu.RadioGroup()
[<Global>]
type DropdownMenu() =
    inherit Kobalte.DropdownMenu()
[<Global>]
type DropdownMenuContent() =
    inherit DropdownMenu.Content()
[<Global>]
type DropdownMenuItem() =
    inherit DropdownMenu.Item()
[<Global>]
type DropdownMenuShortcut() =
    inherit span()
[<Global>]
type DropdownMenuLabel() =
    inherit div()
    member val inset : bool = jsNative with get,set
[<Global>]
type DropdownMenuSeparator() =
    inherit DropdownMenu.Separator()
