using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace SmartV;


public partial interface IVectorOperation
{
}


public static partial class VectorOperation
{
    private partial class _Default : IVectorOperation
    {
    }
    public static IVectorOperation Default { get; } = new _Default();


    private partial class _Parallelized : IVectorOperation
    {
        private ParallelOptions Options { get; }
        public _Parallelized(ParallelOptions options) => Options = options;
    }
    public static IVectorOperation Parallelized(ParallelOptions options) => new _Parallelized(options);


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


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static TTo Cast<TFrom, TTo>(in TFrom x)
        => Unsafe.As<TFrom, TTo>(ref Unsafe.AsRef(x));
}
