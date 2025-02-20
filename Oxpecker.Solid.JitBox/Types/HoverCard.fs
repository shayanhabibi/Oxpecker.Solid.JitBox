namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Oxpecker.Solid.Kobalte
open Fable.Core

[<Global>]
type HoverCardTrigger() =
    inherit HoverCard.Trigger()
    
[<Global>]
type HoverCard() =
    inherit Kobalte.HoverCard()

[<Global>]
type HoverCardContent() =
    inherit HoverCard.Content()