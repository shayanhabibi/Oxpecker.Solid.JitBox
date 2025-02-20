[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.Progress

open Oxpecker.Solid
open Oxpecker.Solid.Types
open Oxpecker.Solid.Kobalte
open Oxpecker.Solid.Utils
open Fable.Core.JsInterop

[<SolidComponent>]
let Progress (props: Progress) =
    let local, others = Solid.splitProps (props, [| "children" |])

    Kobalte.Progress().spread (others) {
        Solid.children local

        Progress.Track(class' = "relative h-2 w-full overflow-hidden rounded-full bg-secondary") {
            Progress.Fill(class' = "h-full w-[var(--kb-progress-fill-width)] flex-1 bg-primary transition-all")
        }
    }

[<SolidComponent>]
let ProgressLabel () =
    Kobalte.Progress.Label()