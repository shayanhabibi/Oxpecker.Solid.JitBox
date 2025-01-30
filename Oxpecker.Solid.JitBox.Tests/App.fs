module App

open Oxpecker.Solid



[<SolidComponent>]
let App() =
    div(class' = "") {
        h1(class' = "") { "HelloWorld" }
    }
