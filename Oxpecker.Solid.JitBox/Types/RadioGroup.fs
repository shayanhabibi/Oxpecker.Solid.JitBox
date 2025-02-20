namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Oxpecker.Solid.Kobalte
open Fable.Core

[<Global>]
type RadioGroup() =
    inherit Kobalte.RadioGroup()
[<Global>]
type RadioGroupItem() =
    inherit RadioGroup.Item()
[<Global>]
type RadioGroupItemLabel() =
    inherit RadioGroup.ItemLabel()
