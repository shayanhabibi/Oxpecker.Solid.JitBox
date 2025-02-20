namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Oxpecker.Solid.Kobalte
open Fable.Core

[<Global>]
type Accordion() =
    inherit Kobalte.Accordion()

[<Global>]
type AccordionItem() =
    inherit Accordion.Item()

[<Global>]
type AccordionTrigger() =
    inherit Accordion.Trigger()

[<Global>]
type AccordionContent() =
    inherit Accordion.Content()
    