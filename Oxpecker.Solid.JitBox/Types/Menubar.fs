namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Oxpecker.Solid.Kobalte
open Fable.Core

[<Global>]
type MenubarGroup() =
    inherit Menubar.Group()
[<Global>]
type MenubarPortal() =
    inherit Menubar.Portal()
[<Global>]
type MenubarSub() =
    inherit Menubar.Sub()
[<Global>]
type MenubarRadioGroup() =
    inherit Menubar.RadioGroup()
[<Global>]
type Menubar() =
    inherit Kobalte.Menubar()
[<Global>]
type MenubarTrigger() =
    inherit Menubar.Trigger()
[<Global>]
type MenubarContent() =
    inherit Menubar.Content()
[<Global>]
type MenubarSubTrigger() =
    inherit Menubar.SubTrigger()
    member val inset: bool = jsNative with get,set
[<Global>]
type MenubarSubContent() =
    inherit Menubar.SubContent()
[<Global>]
type MenubarItem() =
    inherit Menubar.Item()
    member val inset: bool = jsNative with get,set
[<Global>]
type MenubarCheckboxItem() =
    inherit Menubar.CheckboxItem()
[<Global>]
type MenubarRadioItem() =
    inherit Menubar.RadioItem()
[<Global>]
type MenubarItemLabel() =
    inherit Menubar.ItemLabel()
    member val inset: bool = jsNative with get,set
[<Global>]
type MenubarGroupLabel() =
    inherit Menubar.GroupLabel()
    member val inset: bool = jsNative with get,set
[<Global>]
type MenubarSeparator() =
    inherit Menubar.Separator()
[<Global>]
type MenubarShortcut() =
    inherit span()