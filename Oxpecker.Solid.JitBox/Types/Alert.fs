namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Oxpecker.Solid.Kobalte
open Fable.Core

[<Global>]
type Alert() =
    inherit Kobalte.Alert()

[<Global>]
type AlertTitle() =
    inherit h5()

[<Global>]
type AlertDescription() =
    inherit div()