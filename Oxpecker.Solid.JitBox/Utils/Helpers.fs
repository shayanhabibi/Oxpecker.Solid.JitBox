﻿namespace Oxpecker.Solid.Utils

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
    static member inline cn ( classes : string ) : string = classes |> Lib.clsx |> Lib.twMerge
    [<Import("cva","class-variance-authority")>]
    static member inline cva ( orig : string ) ( object : 'T) : obj -> string = jsNative

type [<Erase>] Solid =
    [<ImportMember("solid-js")>]
    static member inline splitProps (o : 'T, p: string array): 'T * 'T = jsNative
    [<ImportMember("solid-js")>]
    static member inline mergeProps (o: obj, p: obj) : obj = jsNative
    [<Emit("$0.children")>]
    static member inline children (o: 'T) : Fragment = jsNative

[<Global>]
type JitNode() =
    inherit RegularNode()
    member val children : Fragment = jsNative with get,set
    member inline this.className
        with set (value : string) = this.class' <- value

[<AutoOpen; Erase>]
module Operators =
    [<Emit("$0 && $1")>]
    let (&&=) (conditional: 'T) (output: 'M): 'M = jsNative
    [<Import("splitProps","solid-js")>]
    let (/=) (value: 'T) (splitter: string array) : 'T * 'T = jsNative