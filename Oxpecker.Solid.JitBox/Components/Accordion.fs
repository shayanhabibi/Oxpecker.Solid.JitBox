[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.Accordion

open Oxpecker.Solid.Types
open Oxpecker.Solid.Kobalte
open Oxpecker.Solid
open Oxpecker.Solid.Lucide
open Fable.Core
open Oxpecker.Solid.Utils
open Fable.Core.JsInterop

[<SolidComponent>]
let AccordionItem ( props : AccordionItem ) =
    let local, others = Solid.splitProps(props, [|"class"|])
    Accordion.Item(class'= Lib.cn [|"border-b"; local?``class``|]).spread(others)

[<SolidComponent>]
let AccordionTrigger ( props : AccordionTrigger ) =
    let local, others = Solid.splitProps(props, [|"class"; "children"|])
    let triggerClass = Lib.cn [|
        "flex flex-1 items-center justify-between py-4 font-medium transition-all hover:underline [&[data-expanded]>svg]:rotate-180"
        local?``class``
    |]
    Accordion.Header(class'="flex") {
        Accordion.Trigger(class'= triggerClass).spread(others) {
            Solid.children local
            Lucide.ChevronDown(strokeWidth=2, class'="size-4 shrink-0 transition-transform duration-300")
        }
    }

[<SolidComponent>]
let AccordionContent (props: AccordionContent) =
    let local,others = Solid.splitProps(props, [|"class"; "children"|])
    Accordion.Content(class'= Lib.cn [|
        "animate-accordion-up overflow-hidden text-sm transition-all data-[expanded]:animate-accordion-down"
        local?``class``
    |] ).spread(others) {
        div(class'="pb-4 pt-0") {
            Solid.children local
        }
    }
[<SolidComponent>]
let Accordion (props: Accordion) =
    let _,rest = props /= [| "some" |]
    Accordion().spread(props) {}