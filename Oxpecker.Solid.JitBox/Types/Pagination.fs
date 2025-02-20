namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Oxpecker.Solid.Kobalte
open Fable.Core

[<Global>]
type PaginationItems() =
    inherit Pagination.Items()
[<Global>]
type Pagination() =
    inherit Kobalte.Pagination()
[<Global>]
type PaginationItem() =
    inherit Pagination.Item()
[<Global>]
type PaginationEllipsis() =
    inherit Pagination.Ellipsis()
[<Global>]
type PaginationPrevious() =
    inherit Pagination.Previous()
[<Global>]
type PaginationNext() =
    inherit Pagination.Next()
