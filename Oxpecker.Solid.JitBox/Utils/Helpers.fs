namespace Oxpecker.Solid.Utils

open Fable.Core
open System
open Oxpecker.Solid

type [<Erase>] Lib =
    [<Import("twMerge","tailwind-merge")>]
    static member inline twMerge ( classes : string ) : string = jsNative
    [<Import("clsx","clsx")>]
    static member inline clsx ( classes : obj ) : string = jsNative
    static member inline cn ( classes : string * bool ) : string = classes |> Lib.clsx |> Lib.twMerge
    static member inline cn ( classes : string array ) : string = classes |> Lib.clsx |> Lib.twMerge
    static member inline cn ( classes : string list ) : string = classes |> Lib.clsx |> Lib.twMerge
    static member inline cn ( classes : string ) : string = classes |> Lib.clsx |> Lib.twMerge
    [<Import("cva","class-variance-authority")>]
    static member inline cva ( orig : string ) ( object : 'T) : obj -> string = jsNative

type [<Erase>] Solid =
    [<ImportMember("solid-js")>]
    static member inline splitProps (o : obj, p: string array): obj * obj = jsNative
    [<ImportMember("solid-js")>]
    static member inline mergeProps (o: obj, p: obj) : obj = jsNative

[<Global>]
type JitNode() =
    inherit RegularNode()
    member val children : Fragment = jsNative with get,set
    member inline this.className
        with set (value : string) = this.class' <- value