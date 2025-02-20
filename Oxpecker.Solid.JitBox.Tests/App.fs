module App

open Oxpecker.Solid
open Oxpecker.Solid.JitBox.Components
let Button = Button
let import = (
    Accordion,
    AccordionItem,
    AccordionContent,
    AccordionTrigger,
    Alert,
    AlertTitle,
    AlertDialog,
    AlertDialogContent,
    AlertDialogOverlay,
    AlertDialogPortal,
    AlertDialogTitle,
    AlertDialogTrigger
    )
open Oxpecker.Solid.Types
open Oxpecker.Solid.Lucide

[<SolidComponent>]
let App() =
    div(class'="h-screen w-screen") {
        h1() { "Hello Lucide!" }
        Lucide.Activity()
        Lucide.Ampersands(strokeWidth = 2)
        Lucide.Dot(color = "blue")
        Lucide.Dot(color = "rgb(200,200,200)")
        Accordion(multiple=false,  collapsible=true, class'="w-full") {
            AccordionItem(value="item-1") {
                AccordionTrigger(class'="h-5 w-5") { "Is it accessible?" }
                AccordionContent() { "Yea, it adheres to all kinds of shit" }
            }
        }
        Button() { "Test" }
        Alert() {
            AlertTitle() {"Hello"}
        }
    }
