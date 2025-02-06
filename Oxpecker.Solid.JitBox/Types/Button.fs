namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Fable.Core
open Oxpecker.Solid.Utils

[<AutoOpen>]
module [<Erase>] button =
    [<Erase>]
    type size =
        static member inline default' : size = unbox "default"
        static member inline sm : size = unbox "sm"
        static member inline lg : size = unbox "lg"
        static member inline icon : size = unbox "icon"
    [<Erase>]
    type variant =
        static member inline default' : variant = unbox "default"
        static member inline outline : variant = unbox "outline"
        static member inline ghost : variant = unbox "ghost"
        static member inline link : variant = unbox "link"
        static member inline destructive : variant = unbox "destructive"
        static member inline secondary : variant = unbox "secondary"

[<Global>]
type Button() =
    inherit JitNode()
    member val size : size = jsNative with get,set
    member val variant : variant = jsNative with get,set


[<Erase;Import("Dot","lucide-solid")>]
type Dot() =
    inherit VoidNode()