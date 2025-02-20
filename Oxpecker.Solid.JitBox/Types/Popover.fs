namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Oxpecker.Solid.Kobalte
open Fable.Core

[<Global>]
type PopoverTrigger() =
    inherit Popover.Trigger()

[<Global>]
type PopoverContent() =
    inherit Popover.Content()
    
[<Global>]
type Popover() =
    inherit Kobalte.Popover()