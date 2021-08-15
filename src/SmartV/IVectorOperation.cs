using System;
using System.Collections.Generic;
using System.Text;

namespace SmartV
{
    /// <summary>  </summary>
    /// <typeparam name="T"></typeparam>
    public interface IVectorOperation<T>
    {
        /// <summary></summary>
        /// <param name="x"></param>
        /// <param name="ans"></param>
        /// <exception cref="ArgumentException">
        ///     The sizes of <paramref name="x"/> and <paramref name="ans"/> are not equal.
        /// </exception>
        /// <exception cref="NotSupportedException" />
        void UnaryPlus(ReadOnlySpan<T> x, Span<T> ans);

        /// <summary></summary>
        /// <param name="x"></param>
        /// <param name="ans"></param>
        /// <exception cref="ArgumentException">
        ///     The sizes of <paramref name="x"/> and <paramref name="ans"/> are not equal.
        /// </exception>
        /// <exception cref="NotSupportedException" />
        void UnaryMinus(ReadOnlySpan<T> x, Span<T> ans);

        /// <summary></summary>
        /// <param name="x"></param>
        /// <param name="ans"></param>
        /// <exception cref="ArgumentException">
        ///     The sizes of <paramref name="x"/> and <paramref name="ans"/> are not equal.
        /// </exception>
        /// <exception cref="NotSupportedException" />
        void Not(ReadOnlySpan<T> x, Span<T> ans);

        /// <summary></summary>
        /// <param name="x"></param>
        /// <param name="ans"></param>
        /// <exception cref="ArgumentException">
        ///     The sizes of <paramref name="x"/> and <paramref name="ans"/> are not equal.
        /// </exception>
        /// <exception cref="NotSupportedException" />
        void Complement(ReadOnlySpan<T> x, Span<T> ans);

        /// <summary></summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="ans"></param>
        /// <exception cref="ArgumentException">
        ///     The sizes of <paramref name="x"/>, <paramref name="y"/>, and <paramref name="ans"/> are not equal.
        /// </exception>
        /// <exception cref="NotSupportedException" />
        void Add(ReadOnlySpan<T> x, ReadOnlySpan<T> y, Span<T> ans);

        /// <summary></summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="ans"></param>
        /// <exception cref="ArgumentException">
        ///     The sizes of <paramref name="x"/>, <paramref name="y"/>, and <paramref name="ans"/> are not equal.
        /// </exception>
        /// <exception cref="NotSupportedException" />
        void Subtract(ReadOnlySpan<T> x, ReadOnlySpan<T> y, Span<T> ans);

        /// <summary></summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="ans"></param>
        /// <exception cref="ArgumentException">
        ///     The sizes of <paramref name="x"/>, <paramref name="y"/>, and <paramref name="ans"/> are not equal.
        /// </exception>
        /// <exception cref="NotSupportedException" />
        void Multiply(ReadOnlySpan<T> x, ReadOnlySpan<T> y, Span<T> ans);

        /// <summary></summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="ans"></param>
        /// <exception cref="ArgumentException">
        ///     The sizes of <paramref name="x"/>, <paramref name="y"/>, and <paramref name="ans"/> are not equal.
        /// </exception>
        /// <exception cref="NotSupportedException" />
        void Divide(ReadOnlySpan<T> x, ReadOnlySpan<T> y, Span<T> ans);

        /// <summary></summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="ans"></param>
        /// <exception cref="ArgumentException">
        ///     The sizes of <paramref name="x"/>, <paramref name="y"/>, and <paramref name="ans"/> are not equal.
        /// </exception>
        /// <exception cref="NotSupportedException" />
        void Modulo(ReadOnlySpan<T> x, ReadOnlySpan<T> y, Span<T> ans);

        /// <summary></summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="ans"></param>
        /// <exception cref="ArgumentException">
        ///     The sizes of <paramref name="x"/>, <paramref name="y"/>, and <paramref name="ans"/> are not equal.
        /// </exception>
        /// <exception cref="NotSupportedException" />
        void BitwiseOr(ReadOnlySpan<T> x, ReadOnlySpan<T> y, Span<T> ans);

        /// <summary></summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="ans"></param>
        /// <exception cref="ArgumentException">
        ///     The sizes of <paramref name="x"/>, <paramref name="y"/>, and <paramref name="ans"/> are not equal.
        /// </exception>
        /// <exception cref="NotSupportedException" />
        void BitwiseAnd(ReadOnlySpan<T> x, ReadOnlySpan<T> y, Span<T> ans);

        /// <summary></summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="ans"></param>
        /// <exception cref="ArgumentException">
        ///     The sizes of <paramref name="x"/>, <paramref name="y"/>, and <paramref name="ans"/> are not equal.
        /// </exception>
        /// <exception cref="NotSupportedException" />
        void BitwiseXor(ReadOnlySpan<T> x, ReadOnlySpan<T> y, Span<T> ans);

        /// <summary></summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="ans"></param>
        /// <exception cref="ArgumentException">
        ///     The sizes of <paramref name="x"/>, <paramref name="y"/>, and <paramref name="ans"/> are not equal.
        /// </exception>
        /// <exception cref="NotSupportedException" />
        void Equals(ReadOnlySpan<T> x, ReadOnlySpan<T> y, Span<T> ans);

        /// <summary></summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="ans"></param>
        /// <exception cref="ArgumentException">
        ///     The sizes of <paramref name="x"/>, <paramref name="y"/>, and <paramref name="ans"/> are not equal.
        /// </exception>
        /// <exception cref="NotSupportedException" />
        void LessThan(ReadOnlySpan<T> x, ReadOnlySpan<T> y, Span<T> ans);

        /// <summary></summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="ans"></param>
        /// <exception cref="ArgumentException">
        ///     The sizes of <paramref name="x"/>, <paramref name="y"/>, and <paramref name="ans"/> are not equal.
        /// </exception>
        /// <exception cref="NotSupportedException" />
        void LessThanOrEquals(ReadOnlySpan<T> x, ReadOnlySpan<T> y, Span<T> ans);

        /// <summary></summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="ans"></param>
        /// <exception cref="ArgumentException">
        ///     The sizes of <paramref name="x"/>, <paramref name="y"/>, and <paramref name="ans"/> are not equal.
        /// </exception>
        /// <exception cref="NotSupportedException" />
        void GreaterThan(ReadOnlySpan<T> x, ReadOnlySpan<T> y, Span<T> ans);

        /// <summary></summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="ans"></param>
        /// <exception cref="ArgumentException">
        ///     The sizes of <paramref name="x"/>, <paramref name="y"/>, and <paramref name="ans"/> are not equal.
        /// </exception>
        /// <exception cref="NotSupportedException" />
        void GreaterThanOrEquals(ReadOnlySpan<T> x, ReadOnlySpan<T> y, Span<T> ans);
    }
}
