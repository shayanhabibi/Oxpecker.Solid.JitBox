namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Oxpecker.Solid.Kobalte
open Fable.Core

[<AutoOpen>]
module [<Erase>] ProgressCircle =
    [<StringEnum; RequireQualifiedAccess>]
    type Size =
        | Xs
        | Sm
        | Md
        | Lg
        | Xl
[<Global>]
type ProgressCircle() =
    inherit div()
    member val value :  int = jsNative with get,set
    member val size: Size = jsNative with get,set
    member val radius: int = jsNative with get,set
    member val strokeWidth: int = jsNative with get,set
    member val showAnimation: bool = jsNative with get,set

[<Global>]
type Progress() =
    inherit Kobalte.Progress()