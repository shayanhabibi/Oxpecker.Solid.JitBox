namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Fable.Core

[<Global>]
type Card() =
    inherit div()

[<Global>]
type CardHeader() =
    inherit div()
    
[<Global>]
type CardTitle() =
    inherit h3()

[<Global>]
type CardDescription() =
    inherit p()
    
[<Global>]
type CardContent() =
    inherit div()
    
[<Global>]
type CardFooter() =
    inherit div()