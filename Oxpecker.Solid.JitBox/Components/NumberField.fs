[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.NumberField

open Oxpecker.Solid
open Oxpecker.Solid.Types
open Oxpecker.Solid.Kobalte
open Oxpecker.Solid.Utils
open Fable.Core.JsInterop

[<SolidComponent>]
let NumberField (props: NumberField) = Kobalte.NumberField().spread props
[<SolidComponent>]
let NumberFieldGroup (props: NumberFieldGroup) =
    let local,others = Solid.splitProps(props, [|"class"|])
    div(class' = Lib.cn [|
        "relative rounded-md focus-within:ring-2 focus-within:ring-ring focus-within:ring-offset-2"
        local?``class``
    |]).spread others

[<SolidComponent>]
let NumberFieldLabel (props: NumberFieldLabel) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.NumberField.Label(class'= Lib.cn [|
        "text-sm font-medium leading-none peer-disabled:cursor-not-allowed peer-disabled:opacity-70"
        local?``class``
    |]).spread(others)

[<SolidComponent>]
let NumberFieldInput (props: NumberFieldInput) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.NumberField.Input(class' = Lib.cn [|
        "flex h-10 w-full rounded-md border border-input bg-transparent px-3 py-2 text-sm ring-offset-background file:border-0 file:bg-transparent file:text-sm file:font-medium placeholder:text-muted-foreground focus-visible:outline-none disabled:cursor-not-allowed disabled:opacity-50 data-[invalid]:border-error-foreground data-[invalid]:text-error-foreground"
        local?``class``
    |]).spread others

[<SolidComponent>]
let NumberFieldIncrementTrigger (props: NumberFieldIncrementTrigger) =
    let local,others = Solid.splitProps(props, [| "class" |])
    Kobalte.NumberField.IncrementTrigger(class' = Lib.cn [|
        "absolute right-1 top-1 inline-flex size-4 items-center justify-center"
        local?``class``
    |]).spread(others) {
        Show(
            when'= ((Solid.children local) &&= true),
            fallback =  (Solid.children local)
        ) {
            Lucide.Lucide.ChevronUp(class'="size-4")
        } 
    }

[<SolidComponent>]
let NumberFieldDecrementTrigger (props: NumberFieldDecrementTrigger) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.NumberField.DecrementTrigger(class' = Lib.cn [|
        "absolute bottom-1 right-1 inline-flex size-4 items-center justify-center"
        local?``class``
    |]).spread(others) {
        Show(
            when' = ((Solid.children local) &&= true),
            fallback = Solid.children local
        ) {
            Lucide.Lucide.ChevronDown(class' = "size-4")
        }
    }

[<SolidComponent>]
let NumberFieldDescription (props: NumberFieldDescription) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.NumberField.Description(class'= Lib.cn [|"text-sm text-muted-foreground"; local?``class``|]).spread others

[<SolidComponent>]
let NumberFieldErrorMessage (props: NumberFieldErrorMessage) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.NumberField.ErrorMessage(class' = Lib.cn [|
        "text-sm text-error-foreground"
        local?``class``
    |]).spread(others)