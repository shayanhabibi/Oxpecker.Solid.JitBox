[<AutoOpen>]
module Oxpecker.Solid.JitBox.Components.Drawer

open Oxpecker.Solid
open Oxpecker.Solid.Types
open Oxpecker.Solid.Corvu
open Oxpecker.Solid.Utils
open Fable.Core.JsInterop

[<SolidComponent>]
let Drawer (props: Drawer) = Corvu.Drawer().spread(props)
[<SolidComponent>]
let DrawerTrigger (props: DrawerTrigger) = Corvu.Drawer.Trigger().spread(props)
[<SolidComponent>]
let DrawerPortal (props: DrawerPortal) = Corvu.Drawer.Portal().spread(props)
[<SolidComponent>]
let DrawerClose (props: DrawerClose) = Corvu.Drawer.Close().spread(props)

[<SolidComponent>]
let DrawerOverlay (props: DrawerOverlay) =
    let _,rest = Solid.splitProps(props, [|"class"|])
    let drawerContext = Types.Drawer.useContext()
    Corvu.Drawer.Overlay(class'= Lib.cn [|
        "fixed inset-0 z-50 data-[transitioning]:transition-colors data-[transitioning]:duration-300"
        props?``class``
    |]).spread(rest).style'({|
        ``background-color`` = $"rgb(0 0 0 / {0.8 * drawerContext?openPercentage()})"
    |})

[<SolidComponent>]
let DrawerContent (props: DrawerContent) =
    let _,rest = Solid.splitProps(props, [|"class"; "children"|])
    Types.DrawerPortal() {
        Types.DrawerOverlay()
        Corvu.Drawer.Content(class'= Lib.cn [|
            "fixed inset-x-0 bottom-0 z-50 mt-24 flex h-auto flex-col rounded-t-[10px] border bg-background after:absolute after:inset-x-0 after:top-full after:h-1/2 after:bg-inherit data-[transitioning]:transition-transform data-[transitioning]:duration-300 md:select-none"
            props?``class``
        |]).spread(rest) {
            div(class'="mx-auto mt-4 h-2 w-[100px] rounded-full bg-muted")
            Solid.children props
        }
    }

[<SolidComponent>]
let DrawerHeader (props: DrawerHeader) =
    let _,rest = Solid.splitProps(props, [|"class"|])
    div(class'= Lib.cn [|
        "grid gap-1.5 p-4 text-center sm:text-left"
        props?``class``
    |]).spread(rest)

[<SolidComponent>]
let DrawerFooter (props: DrawerFooter) =
    let _,rest = Solid.splitProps(props, [|"class"|])
    div(class'= Lib.cn [|
        "t-auto flex flex-col gap-2 p-4"
        props?``class``
    |]).spread(rest)
[<SolidComponent>]
let DrawerTitle (props: DrawerTitle) =
    let _,rest = Solid.splitProps(props, [|"class"|])
    Corvu.Drawer.Label(class'= Lib.cn [|
        "text-lg font-semibold leading-none tracking-tight"
        props?``class``
    |]).spread(rest)

[<SolidComponent>]
let DrawerDescription (props: DrawerDescription) =
    let _,rest = Solid.splitProps(props, [|"class"|])
    Corvu.Drawer.Description(class'=Lib.cn [|"text-sm text-muted-foreground"; props?``class``|]).spread(rest)
