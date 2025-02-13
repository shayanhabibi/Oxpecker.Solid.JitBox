module App

open Oxpecker.Solid
open Oxpecker.Solid.JitBox.Components
let Button = Button
open Oxpecker.Solid.Types
open Oxpecker.Solid.Lucide

let mutable style = size.lg

[<SolidComponent>]
let App() =
    div() {
        h1() { "Hello Lucide!" }
        Lucide.Activity()
        Lucide.Ampersands(strokeWidth = 2)
        Lucide.Dot(color = "blue")
        Lucide.Dot(color = "rgb(200,200,200)")
    }
