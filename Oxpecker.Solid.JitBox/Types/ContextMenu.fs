namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Oxpecker.Solid.Kobalte
open Fable.Core

[<Global>]
type ContextMenu() =
    inherit Kobalte.ContextMenu()
[<Global>]
type ContextMenuTrigger() =
    inherit ContextMenu.Trigger()
[<Global>]
type ContextMenuPortal() =
    inherit ContextMenu.Portal()
[<Global>]
type ContextMenuSub() =
    inherit ContextMenu.Sub()
[<Global>]
type ContextMenuGroup() =
    inherit ContextMenu.Group()
[<Global>]
type ContextMenuRadioGroup() =
    inherit ContextMenu.RadioGroup()
[<Global>]
type ContextMenuContent() =
    inherit ContextMenu.Content()
[<Global>]
type ContextMenuItem() =
    inherit ContextMenu.Item()
[<Global>]
type ContextMenuShortcut() =
    inherit span()
[<Global>]
type ContextMenuSeparator() =
    inherit ContextMenu.Separator()
[<Global>]
type ContextMenuSubTrigger() =
    inherit ContextMenu.SubTrigger()
[<Global>]
type ContextMenuSubContent() =
    inherit ContextMenu.SubContent()
[<Global>]
type ContextMenuCheckboxItem() =
    inherit ContextMenu.CheckboxItem()
[<Global>]
type ContextMenuGroupLabel() =
    inherit ContextMenu.GroupLabel()
[<Global>]
type ContextMenuRadioItem() =
    inherit ContextMenu.RadioItem()
