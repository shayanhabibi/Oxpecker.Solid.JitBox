[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.Badge

open Oxpecker.Solid
open Oxpecker.Solid.Types
open Oxpecker.Solid.Utils
open Fable.Core.JsInterop

let badgeVariants =
    Lib.cva
      "inline-flex items-center rounded-md border px-2.5 py-0.5 text-xs font-semibold transition-colors focus:outline-none focus:ring-2 focus:ring-ring focus:ring-offset-2"
      {|
        variants= {|
          variant= {|
            ``default``= "border-transparent bg-primary text-primary-foreground"
            secondary= "border-transparent bg-secondary text-secondary-foreground"
            outline= "text-foreground"
            success= "border-success-foreground bg-success text-success-foreground"
            warning= "border-warning-foreground bg-warning text-warning-foreground"
            error= "border-error-foreground bg-error text-error-foreground"
          |}
        |}
        defaultVariants= {|
          variant= "default"
        |}
      |}

[<SolidComponent>]
let Badge (props: Badge) =
  let local,others = Solid.splitProps(props, [|"class"; "variant"; "round"|])
  let roundedClass () = if local?round then "rounded-full" else ""
  div(
    class'= Lib.cn [|
        badgeVariants({| variant = local?variant |})
        roundedClass ()
        local?``class``
      |]
    ).spread(others)