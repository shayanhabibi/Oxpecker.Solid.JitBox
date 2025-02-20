namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Oxpecker.Solid.Kobalte
open Fable.Core

[<Global>]
type Avatar() =
    inherit Kobalte.Image()

[<Global>]
type AvatarImage() =
    inherit Image.Img()

[<Global>]
type AvatarFallback() =
    inherit Image.Fallback()

