[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.Breadcrumb

open Oxpecker.Solid
open Oxpecker.Solid.Lucide
open Oxpecker.Solid.Types
open Oxpecker.Solid.Kobalte
open Fable.Core.JsInterop
open Fable.Core
open Oxpecker.Solid.Utils

[<SolidComponent>]
let Breadcrumb (props: Breadcrumb) = Kobalte.Breadcrumbs().spread(props)

[<SolidComponent>]
let BreadcrumbList (props: BreadcrumbList) =
    let local,others = Solid.splitProps(props, [|"class"|])
    ol(class'= Lib.cn [|
        "flex flex-wrap items-center gap-1.5 break-words text-sm text-muted-foreground sm:gap-2.5"
        local?``class``
    |]).spread(others)

[<SolidComponent>]
let BreadcrumbItem (props: BreadcrumbItem) =
    let local,others = Solid.splitProps(props, [|"class"|])
    li(class'=Lib.cn [|"inline-flex items-center gap-1.5"; local?``class``|]).spread(others)

[<SolidComponent>]
let BreadcrumbLink (props: BreadcrumbLink) =
    let local,others = Solid.splitProps(props, [|"class"|])
    Kobalte.Breadcrumbs.Link(class'= Lib.cn [|
        "transition-colors hover:text-foreground data-[current]:font-normal data-[current]:text-foreground"
        local?``class``
    |]).spread(others)

[<SolidComponent>]
let BreadcrumbSeparator (props: BreadcrumbSeparator) =
    let local,others = Solid.splitProps(props, [|"class"; "children"|])
    Breadcrumbs.Separator(class'=Lib.cn [|"[&>svg]:size-3.5" ; local?``class``|]).spread(others) {
        Show(when'= !!(Solid.children local),
             fallback= Lucide.Slash(strokeWidth=2))
    }

[<SolidComponent>]
let BreadcrumbEllipsis (props: BreadcrumbEllipsis) =
    let local,others = Solid.splitProps(props, [|"class"|])
    span(
        class' = Lib.cn [|
            "flex size-9 items-center justify-center"
            local?``class``
        |]
        ).spread(others) {
        Lucide.Ellipsis(strokeWidth=2, class'="size-4")
        span(class'="sr-only") { "More" }
    }
