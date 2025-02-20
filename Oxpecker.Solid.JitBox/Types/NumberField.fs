namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Oxpecker.Solid.Kobalte
open Fable.Core

[<Global>]
type NumberField() =
    inherit Kobalte.NumberField()
[<Global>]
type NumberFieldGroup() =
    inherit div()
[<Global>]
type NumberFieldLabel() =
    inherit NumberField.Label()
[<Global>]
type NumberFieldInput() =
    inherit NumberField.Input()
[<Global>]
type NumberFieldIncrementTrigger() =
    inherit NumberField.IncrementTrigger()
[<Global>]
type NumberFieldDecrementTrigger() =
    inherit NumberField.DecrementTrigger()
[<Global>]
type NumberFieldDescription() =
    inherit NumberField.Description()
[<Global>]
type NumberFieldErrorMessage() =
    inherit NumberField.ErrorMessage()