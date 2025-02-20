[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.Checkbox

open Oxpecker.Solid.Lucide
open Oxpecker.Solid
open Oxpecker.Solid.Types
open Oxpecker.Solid.Kobalte
open Oxpecker.Solid.Utils
open Fable.Core.JsInterop

[<SolidComponent>]
let Checkbox (props: Checkbox) =
    let local,others = Solid.splitProps(props, [| "class" |])
    Kobalte.Checkbox(class' = Lib.cn [| "items-top group relative flex space-x-2"; local?``class`` |]).spread(others) {
        Checkbox.Input(class'="peer")
        Checkbox.Control(class' = "size-4 shrink-0 rounded-sm border border-primary ring-offset-background disabled:cursor-not-allowed disabled:opacity-50 peer-focus-visible:outline-none peer-focus-visible:ring-2 peer-focus-visible:ring-ring peer-focus-visible:ring-offset-2 data-[checked]:border-none data-[indeterminate]:border-none data-[checked]:bg-primary data-[indeterminate]:bg-primary data-[checked]:text-primary-foreground data-[indeterminate]:text-primary-foreground") {
            Checkbox.Indicator() {
                Bindings.Switch() {
                    Bindings.Match(when'= not others?indeterminate) {
                        Lucide.Check(class'="size-4", strokeWidth = 2)
                    }
                    Bindings.Match(when' = others?indeterminate) {
                        Lucide.Minus(class'="size-4", strokeWidth = 2)
                    }
                }
            }
        }


    }
