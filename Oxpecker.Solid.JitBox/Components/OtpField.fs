[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.OtpField

open Oxpecker.Solid.Utils
open Oxpecker.Solid
open Oxpecker.Solid.Types
open Oxpecker.Solid.Corvu

open Fable.Core.JsInterop

[<SolidComponent>]
let OtpField (props: OtpField) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Corvu.OtpField(class' = Lib.cn [|
        "flex items-center gap-2 disabled:cursor-not-allowed has-[:disabled]:opacity-50"
        local?``class``
    |]).spread(others)

[<SolidComponent>]
let OtpFieldInput (props: OtpFieldInput) = Corvu.OtpField.Input().spread props

[<SolidComponent>]
let OtpFieldGroup (props: OtpFieldGroup) =
    let local,others = Solid.splitProps(props, [| "class" |])
    div(class' = Lib.cn [|
        "flex items-center"
        local?``class``
    |]).spread others

open Fable.Core.DynamicExtensions

[<SolidComponent>]
let OtpFieldSlot (props: OtpFieldSlot) =
    let local,others = Solid.splitProps(props, [|"class"; "index"|])
    let context = Types.OtpField.useContext()
    let character () : unit -> string = unbox (context?value().Item(!!local.index))
    let showFakeCaret () = context?value()?length = local?index &&= context?isInserting()
    div(class' = Lib.cn [|
        "group relative flex size-10 items-center justify-center border-y border-r border-input text-sm first:rounded-l-md first:border-l last:rounded-r-md"
        local?``class``
    |]).spread(others) {
        div(class' = Lib.cn [|
            "absolute inset-0 z-10 transition-all group-first:rounded-l-md group-last:rounded-r-md"
            context?activeSlots()?includes(local.index) &&= "ring-2 ring-ring ring-offset-background"
        |]) {
            unbox<string> (character())
            Show(when' = showFakeCaret()) {
                div(class' = "pointer-events-none absolute inset-0 flex items-center justify-center") {
                    div(class'="h-4 w-px animate-caret-blink bg-foreground duration-1000")
                }
            }
        }
    }

[<SolidComponent>]
let OtpFieldSeparator (props: OtpFieldSeparator) =
    div().spread(props) {
        Lucide.Lucide.Dot(class'="size-6", strokeWidth = 2)
    }