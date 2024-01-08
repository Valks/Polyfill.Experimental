using System;

internal static class ThrowHelper
{
    internal static void ThrowArgumentOutOfRangeException(string paramName) => throw new ArgumentOutOfRangeException(paramName);
}
