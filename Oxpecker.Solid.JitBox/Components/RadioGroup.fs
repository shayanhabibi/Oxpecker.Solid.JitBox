[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.RadioGroup

open Oxpecker.Solid.Utils
open Oxpecker.Solid
open Oxpecker.Solid.Types
open Oxpecker.Solid.Kobalte
open Fable.Core.JsInterop

[<SolidComponent>]
let RadioGroup (props: RadioGroup) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.RadioGroup(class' = Lib.cn [|"grid gap-2"; local?``class``|]).spread(others)

[<SolidComponent>]
let RadioGroupItem (props: RadioGroupItem) =
    let local,others = Solid.splitProps(props, [|"class"; "children"|])
    Kobalte.RadioGroup.Item(class' = Lib.cn [|
        "flex items-center space-x-2"
        local?``class``
    |]).spread(others) {
        Kobalte.RadioGroup.ItemInput()
        Kobalte.RadioGroup.ItemControl(class' = "aspect-square size-4 rounded-full border border-primary text-primary ring-offset-background focus:outline-none focus-visible:ring-2 focus-visible:ring-ring focus-visible:ring-offset-2 disabled:cursor-not-allowed disabled:opacity-50") {
            Kobalte.RadioGroup.ItemIndicator(class' = "flex h-full items-center justify-center") {
                Lucide.Lucide.Circle(class' = "size-2.5 fill-current text-current")
            }
        }
        Solid.children local
    }

[<SolidComponent>]
let RadioGroupItemLabel (props: RadioGroupItemLabel) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.RadioGroup.ItemLabel(class' = Lib.cn [|
        "text-sm font-medium leading-none peer-disabled:cursor-not-allowed peer-disabled:opacity-70"
        local?``class``
    |]).spread(others)