namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Oxpecker.Solid.Corvu
open Fable.Core

[<Global>]
type Drawer() =
    inherit Corvu.Drawer()
[<Global>]
type DrawerTrigger() =
    inherit Drawer.Trigger()
[<Global>]
type DrawerPortal() =
    inherit Drawer.Portal()
[<Global>]
type DrawerClose() =
    inherit Drawer.Close()
[<Global>]
type DrawerOverlay() =
    inherit Drawer.Overlay()
[<Global>]
type DrawerContent() =
    inherit Drawer.Content()
[<Global>]
type DrawerHeader() =
    inherit div()
[<Global>]
type DrawerFooter() =
    inherit div()
[<Global>]
type DrawerTitle() =
    inherit Drawer.Label()
[<Global>]
type DrawerDescription() =
    inherit Drawer.Description()

[<RequireQualifiedAccess>]
module Drawer =
    [<Import("useContext", "@corvu/drawer")>]
    let useContext (): obj = jsNative