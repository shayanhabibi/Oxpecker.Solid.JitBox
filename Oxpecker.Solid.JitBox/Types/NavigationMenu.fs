namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Oxpecker.Solid.Kobalte
open Fable.Core

[<Global>]
type NavigationMenuItem() =
    inherit NavigationMenu.Item()

[<Global>]
type NavigationMenu() =
    inherit Kobalte.NavigationMenu()
    
[<Global>]
type NavigationMenuTrigger() =
    inherit NavigationMenu.Trigger()

[<Global>]
type NavigationMenuIcon() =
    inherit NavigationMenu.Icon()

[<Global>]
type NavigationMenuViewport() =
    inherit NavigationMenu.Viewport()

[<Global>]
type NavigationMenuContent() =
    inherit NavigationMenu.Content()

[<Global>]
type NavigationMenuLink() =
    inherit NavigationMenu.Item()

[<Global>]
type NavigationMenuLabel() =
    inherit NavigationMenu.ItemLabel()

[<Global>]
type NavigationMenuDescription() =
    inherit NavigationMenu.ItemDescription()
