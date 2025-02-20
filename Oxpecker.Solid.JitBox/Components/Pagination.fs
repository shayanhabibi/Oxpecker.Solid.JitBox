[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.Pagination

open Oxpecker.Solid.JitBox.Components.Button
open Oxpecker.Solid
open Oxpecker.Solid.Utils
open Oxpecker.Solid.Types
open Oxpecker.Solid.Kobalte
open Fable.Core.JsInterop

[<SolidComponent>]
let PaginationItems (props: PaginationItems) = Kobalte.Pagination.Items()
[<SolidComponent>]
let Pagination (props: Pagination) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.Pagination(class' = Lib.cn [|
        "[&>*]:flex [&>*]:flex-row [&>*]:items-center [&>*]:gap-1"
        local?``class``
    |]).spread(others)

[<SolidComponent>]
let PaginationItem (props: PaginationItem) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.Pagination.Item(class' = Lib.cn [|
        buttonVariants({|variant="ghost"|})
        "size-10 data-[current]:border"
        local?``class``
    |]).spread(others)

[<SolidComponent>]
let PaginationEllipsis (props: PaginationEllipsis) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.Pagination.Ellipsis(
        class'= Lib.cn [|
            "flex size-10 items-center justify-center"
            local?``class``
        |]).spread(others) {
        Lucide.Lucide.Ellipsis(class'="size-4",strokeWidth = 2)
        span(class'="sr-only") {"More pages"}
    }

[<SolidComponent>]
let PaginationPrevious (props: PaginationPrevious) =
    let local,others = Solid.splitProps(props, [|"class"; "children"|])
    Kobalte.Pagination.Previous(class' = Lib.cn [|
        buttonVariants({|variant="ghost"|})
        "gap-1 pl-2.5"
        local?``class``
    |]).spread(others) {
        Show(when' = (unbox Solid.children local),
             fallback = Fragment() {
                 Lucide.Lucide.ChevronLeft(class'="size-4", strokeWidth = 2)
                 span() { "Previous" }
             }) {
            Solid.children local
        }
    }
[<SolidComponent>]
let PaginationNext (props: PaginationNext) =
    let local,others = Solid.splitProps(props, [|"class"; "children"|])
    Kobalte.Pagination.Next(class' = Lib.cn [|
        buttonVariants({|variant = "ghost" |})
        "gap-1 pl-2.5"
        local?``class``
    |]).spread(others) {
        Show(
            when' = unbox Solid.children local,
            fallback = Fragment() {
                span() {"Next"}
                Lucide.Lucide.ChevronRight(class'="size-4", strokeWidth = 2)
            }
        ) { Solid.children local }
    }