## Lucide Icon Binding Generator

Generates bindings for <kbd>Lucide Icons</kbd> in Oxpecker.Solid style.

Because this reuses the generator originally made for the Feliz bindings to the `lucide-react` library, the parser actually generates the icons based off the `lucide-react` library.

This is because, unlike `lucide-react`, `lucide-solid` does not have an index containing the icon exports, but instead has a file for each.

Since they are the same otherwise, `lucide-react` is kept as a dev depenedency for the generation.

## Usage

`dotnet run`