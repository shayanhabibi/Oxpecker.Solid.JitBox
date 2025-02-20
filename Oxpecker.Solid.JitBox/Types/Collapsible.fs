namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Oxpecker.Solid.Kobalte
open Fable.Core

[<Global>]
type Collapsible() =
    inherit Kobalte.Collapsible()

[<Global>]
type CollapsibleTrigger() =
    inherit Collapsible.Trigger()
    
[<Global>]
type CollapsibleContent() =
    inherit Collapsible.Content()
    
