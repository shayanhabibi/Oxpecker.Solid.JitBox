namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Oxpecker.Solid.Kobalte
open Fable.Core

[<Global>]
type Breadcrumb() =
    inherit Kobalte.Breadcrumbs()

[<Global>]
type BreadcrumbList() =
    inherit ol()

[<Global>]
type BreadcrumbItem() =
    inherit li()

[<Global>]
type BreadcrumbLink() =
    inherit Breadcrumbs.Link()

[<Global>]
type BreadcrumbSeparator() =
    inherit Breadcrumbs.Separator()

[<Global>]
type BreadcrumbEllipsis() =
    inherit span()
