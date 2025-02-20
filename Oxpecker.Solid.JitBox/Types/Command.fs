namespace Oxpecker.Solid.Types

open Oxpecker.Solid
open Oxpecker.Solid.Cmdk
open Fable.Core

[<Global>]
type Command() =
    inherit Cmdk.Command()

[<Global>]
type CommandDialog() =
    inherit Dialog()

[<Global>]
type CommandInput() =
    inherit Command.Input()

[<Global>]
type CommandList() =
    inherit Command.List()

[<Global>]
type CommandEmpty() =
    inherit Command.Empty()
    
[<Global>]
type CommandGroup() =
    inherit Command.Group()

[<Global>]
type CommandSeparator() =
    inherit Command.Separator()
    
[<Global>]
type CommandItem() =
    inherit Command.Item()

[<Global>]
type CommandShortcut() =
    inherit span()