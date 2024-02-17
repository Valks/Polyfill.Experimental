using System;
using System.Diagnostics.CodeAnalysis;

internal static class ThrowHelper
{
    [DoesNotReturn]
    internal static void ThrowArgumentOutOfRangeException(string paramName) => throw new ArgumentOutOfRangeException(paramName);
}
