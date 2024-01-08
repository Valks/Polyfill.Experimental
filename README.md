# Polyfill.Experimental

Extra polyfills for `.netstandard2.0`

Referencing and continuing the idea's of: https://github.com/SimonCropp/Polyfill

This project references [Polyfill](https://github.com/SimonCropp/Polyfill) as a dependency and adds extra polyfills for:

| Polyfill | |
|-|-|
| System.Buffers.ReadOnlySequence<T> | Extension Methods |
| System.Buffers.SequenceReader<T> | |
| System.Text.Encoder | Extension Methods |
| System.Text.Encoding | Extension Methods |


While taking a lot of reference from the dotnet runtime repository itself: https://github.com/dotnet/runtime it also leverages knowledge from others who've also tried porting these functions:

| Source | Link |
|-|-|
| Nerdbank.Streams | https://github.com/dotnet/Nerdbank.Streams

