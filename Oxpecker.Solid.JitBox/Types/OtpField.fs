namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Oxpecker.Solid.Corvu
open Fable.Core

[<Global>]
type OtpField() =
    inherit Corvu.OtpField()

[<Global>]
type OtpFieldInput() =
    inherit OtpField.Input()

[<Global>]
type OtpFieldGroup() =
    inherit div()

[<Global>]
type OtpFieldSlot() =
    inherit div()
    member val index: int = jsNative with get,set

[<Erase; RequireQualifiedAccess>]
module OtpField =
    [<Import("useContext","@corvu/otp-field")>]
    let useContext () = jsNative

[<Global>]
type OtpFieldSeparator() =
    inherit div()