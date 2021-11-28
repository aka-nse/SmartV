using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace SmartV;

public static partial class VectorOperation
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void AssertSizeMatch<T>(ReadOnlySpan<T> x, ReadOnlySpan<T> y, string xArgName, string yArgName)
    {
        if(y.Length != x.Length)
        {
            throw new ArgumentException($"The length of {xArgName} and {yArgName} must be same.");
        }
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int GetVectorizableLength<T>(Span<T> span)
        where T : unmanaged
        => (span.Length / Vector<T>.Count) * Vector<T>.Count;


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Span<Vector<T>> Cast<T>(Span<T> span, int vlen)
        where T : unmanaged
        => MemoryMarshal.Cast<T, Vector<T>>(span.Slice(0, vlen));


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ReadOnlySpan<Vector<T>> Cast<T>(ReadOnlySpan<T> span, int vlen)
        where T : unmanaged
        => MemoryMarshal.Cast<T, Vector<T>>(span.Slice(0, vlen));
}
