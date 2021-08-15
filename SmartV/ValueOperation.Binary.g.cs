using System;
using System.Runtime.CompilerServices;

namespace SmartV
{
    partial class ValueOperation
    {

        /// <summary> Operates <c>Add</c> unaly operation. </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Add<T>(in T x, in T y)
        {
            unchecked
            {
                if(typeof(T) == typeof(bool))
                {
                    throw new NotSupportedException();
                }
                if(typeof(T) == typeof(byte))
                {
                    var z = (byte)(Unsafe.As<T, byte>(ref Unsafe.AsRef(x)) + Unsafe.As<T, byte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<byte, T>(ref z);
                }
                if(typeof(T) == typeof(ushort))
                {
                    var z = (ushort)(Unsafe.As<T, ushort>(ref Unsafe.AsRef(x)) + Unsafe.As<T, ushort>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ushort, T>(ref z);
                }
                if(typeof(T) == typeof(uint))
                {
                    var z = (uint)(Unsafe.As<T, uint>(ref Unsafe.AsRef(x)) + Unsafe.As<T, uint>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<uint, T>(ref z);
                }
                if(typeof(T) == typeof(ulong))
                {
                    var z = (ulong)(Unsafe.As<T, ulong>(ref Unsafe.AsRef(x)) + Unsafe.As<T, ulong>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ulong, T>(ref z);
                }
                if(typeof(T) == typeof(sbyte))
                {
                    var z = (sbyte)(Unsafe.As<T, sbyte>(ref Unsafe.AsRef(x)) + Unsafe.As<T, sbyte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<sbyte, T>(ref z);
                }
                if(typeof(T) == typeof(short))
                {
                    var z = (short)(Unsafe.As<T, short>(ref Unsafe.AsRef(x)) + Unsafe.As<T, short>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<short, T>(ref z);
                }
                if(typeof(T) == typeof(int))
                {
                    var z = (int)(Unsafe.As<T, int>(ref Unsafe.AsRef(x)) + Unsafe.As<T, int>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<int, T>(ref z);
                }
                if(typeof(T) == typeof(long))
                {
                    var z = (long)(Unsafe.As<T, long>(ref Unsafe.AsRef(x)) + Unsafe.As<T, long>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<long, T>(ref z);
                }
                if(typeof(T) == typeof(float))
                {
                    var z = (float)(Unsafe.As<T, float>(ref Unsafe.AsRef(x)) + Unsafe.As<T, float>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<float, T>(ref z);
                }
                if(typeof(T) == typeof(double))
                {
                    var z = (double)(Unsafe.As<T, double>(ref Unsafe.AsRef(x)) + Unsafe.As<T, double>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<double, T>(ref z);
                }
                if(typeof(T) == typeof(decimal))
                {
                    var z = (decimal)(Unsafe.As<T, decimal>(ref Unsafe.AsRef(x)) + Unsafe.As<T, decimal>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<decimal, T>(ref z);
                }
            }
            return Cache<T>.Instance.Add(x, y);
        }


        /// <summary> Operates <c>AddChecked</c> unaly operation. </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T AddChecked<T>(in T x, in T y)
        {
            checked
            {
                if(typeof(T) == typeof(bool))
                {
                    throw new NotSupportedException();
                }
                if(typeof(T) == typeof(byte))
                {
                    var z = (byte)(Unsafe.As<T, byte>(ref Unsafe.AsRef(x)) + Unsafe.As<T, byte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<byte, T>(ref z);
                }
                if(typeof(T) == typeof(ushort))
                {
                    var z = (ushort)(Unsafe.As<T, ushort>(ref Unsafe.AsRef(x)) + Unsafe.As<T, ushort>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ushort, T>(ref z);
                }
                if(typeof(T) == typeof(uint))
                {
                    var z = (uint)(Unsafe.As<T, uint>(ref Unsafe.AsRef(x)) + Unsafe.As<T, uint>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<uint, T>(ref z);
                }
                if(typeof(T) == typeof(ulong))
                {
                    var z = (ulong)(Unsafe.As<T, ulong>(ref Unsafe.AsRef(x)) + Unsafe.As<T, ulong>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ulong, T>(ref z);
                }
                if(typeof(T) == typeof(sbyte))
                {
                    var z = (sbyte)(Unsafe.As<T, sbyte>(ref Unsafe.AsRef(x)) + Unsafe.As<T, sbyte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<sbyte, T>(ref z);
                }
                if(typeof(T) == typeof(short))
                {
                    var z = (short)(Unsafe.As<T, short>(ref Unsafe.AsRef(x)) + Unsafe.As<T, short>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<short, T>(ref z);
                }
                if(typeof(T) == typeof(int))
                {
                    var z = (int)(Unsafe.As<T, int>(ref Unsafe.AsRef(x)) + Unsafe.As<T, int>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<int, T>(ref z);
                }
                if(typeof(T) == typeof(long))
                {
                    var z = (long)(Unsafe.As<T, long>(ref Unsafe.AsRef(x)) + Unsafe.As<T, long>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<long, T>(ref z);
                }
                if(typeof(T) == typeof(float))
                {
                    var z = (float)(Unsafe.As<T, float>(ref Unsafe.AsRef(x)) + Unsafe.As<T, float>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<float, T>(ref z);
                }
                if(typeof(T) == typeof(double))
                {
                    var z = (double)(Unsafe.As<T, double>(ref Unsafe.AsRef(x)) + Unsafe.As<T, double>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<double, T>(ref z);
                }
                if(typeof(T) == typeof(decimal))
                {
                    var z = (decimal)(Unsafe.As<T, decimal>(ref Unsafe.AsRef(x)) + Unsafe.As<T, decimal>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<decimal, T>(ref z);
                }
            }
            return Cache<T>.Instance.AddChecked(x, y);
        }


        /// <summary> Operates <c>Subtract</c> unaly operation. </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Subtract<T>(in T x, in T y)
        {
            unchecked
            {
                if(typeof(T) == typeof(bool))
                {
                    throw new NotSupportedException();
                }
                if(typeof(T) == typeof(byte))
                {
                    var z = (byte)(Unsafe.As<T, byte>(ref Unsafe.AsRef(x)) - Unsafe.As<T, byte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<byte, T>(ref z);
                }
                if(typeof(T) == typeof(ushort))
                {
                    var z = (ushort)(Unsafe.As<T, ushort>(ref Unsafe.AsRef(x)) - Unsafe.As<T, ushort>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ushort, T>(ref z);
                }
                if(typeof(T) == typeof(uint))
                {
                    var z = (uint)(Unsafe.As<T, uint>(ref Unsafe.AsRef(x)) - Unsafe.As<T, uint>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<uint, T>(ref z);
                }
                if(typeof(T) == typeof(ulong))
                {
                    var z = (ulong)(Unsafe.As<T, ulong>(ref Unsafe.AsRef(x)) - Unsafe.As<T, ulong>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ulong, T>(ref z);
                }
                if(typeof(T) == typeof(sbyte))
                {
                    var z = (sbyte)(Unsafe.As<T, sbyte>(ref Unsafe.AsRef(x)) - Unsafe.As<T, sbyte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<sbyte, T>(ref z);
                }
                if(typeof(T) == typeof(short))
                {
                    var z = (short)(Unsafe.As<T, short>(ref Unsafe.AsRef(x)) - Unsafe.As<T, short>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<short, T>(ref z);
                }
                if(typeof(T) == typeof(int))
                {
                    var z = (int)(Unsafe.As<T, int>(ref Unsafe.AsRef(x)) - Unsafe.As<T, int>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<int, T>(ref z);
                }
                if(typeof(T) == typeof(long))
                {
                    var z = (long)(Unsafe.As<T, long>(ref Unsafe.AsRef(x)) - Unsafe.As<T, long>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<long, T>(ref z);
                }
                if(typeof(T) == typeof(float))
                {
                    var z = (float)(Unsafe.As<T, float>(ref Unsafe.AsRef(x)) - Unsafe.As<T, float>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<float, T>(ref z);
                }
                if(typeof(T) == typeof(double))
                {
                    var z = (double)(Unsafe.As<T, double>(ref Unsafe.AsRef(x)) - Unsafe.As<T, double>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<double, T>(ref z);
                }
                if(typeof(T) == typeof(decimal))
                {
                    var z = (decimal)(Unsafe.As<T, decimal>(ref Unsafe.AsRef(x)) - Unsafe.As<T, decimal>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<decimal, T>(ref z);
                }
            }
            return Cache<T>.Instance.Subtract(x, y);
        }


        /// <summary> Operates <c>SubtractChecked</c> unaly operation. </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T SubtractChecked<T>(in T x, in T y)
        {
            checked
            {
                if(typeof(T) == typeof(bool))
                {
                    throw new NotSupportedException();
                }
                if(typeof(T) == typeof(byte))
                {
                    var z = (byte)(Unsafe.As<T, byte>(ref Unsafe.AsRef(x)) - Unsafe.As<T, byte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<byte, T>(ref z);
                }
                if(typeof(T) == typeof(ushort))
                {
                    var z = (ushort)(Unsafe.As<T, ushort>(ref Unsafe.AsRef(x)) - Unsafe.As<T, ushort>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ushort, T>(ref z);
                }
                if(typeof(T) == typeof(uint))
                {
                    var z = (uint)(Unsafe.As<T, uint>(ref Unsafe.AsRef(x)) - Unsafe.As<T, uint>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<uint, T>(ref z);
                }
                if(typeof(T) == typeof(ulong))
                {
                    var z = (ulong)(Unsafe.As<T, ulong>(ref Unsafe.AsRef(x)) - Unsafe.As<T, ulong>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ulong, T>(ref z);
                }
                if(typeof(T) == typeof(sbyte))
                {
                    var z = (sbyte)(Unsafe.As<T, sbyte>(ref Unsafe.AsRef(x)) - Unsafe.As<T, sbyte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<sbyte, T>(ref z);
                }
                if(typeof(T) == typeof(short))
                {
                    var z = (short)(Unsafe.As<T, short>(ref Unsafe.AsRef(x)) - Unsafe.As<T, short>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<short, T>(ref z);
                }
                if(typeof(T) == typeof(int))
                {
                    var z = (int)(Unsafe.As<T, int>(ref Unsafe.AsRef(x)) - Unsafe.As<T, int>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<int, T>(ref z);
                }
                if(typeof(T) == typeof(long))
                {
                    var z = (long)(Unsafe.As<T, long>(ref Unsafe.AsRef(x)) - Unsafe.As<T, long>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<long, T>(ref z);
                }
                if(typeof(T) == typeof(float))
                {
                    var z = (float)(Unsafe.As<T, float>(ref Unsafe.AsRef(x)) - Unsafe.As<T, float>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<float, T>(ref z);
                }
                if(typeof(T) == typeof(double))
                {
                    var z = (double)(Unsafe.As<T, double>(ref Unsafe.AsRef(x)) - Unsafe.As<T, double>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<double, T>(ref z);
                }
                if(typeof(T) == typeof(decimal))
                {
                    var z = (decimal)(Unsafe.As<T, decimal>(ref Unsafe.AsRef(x)) - Unsafe.As<T, decimal>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<decimal, T>(ref z);
                }
            }
            return Cache<T>.Instance.SubtractChecked(x, y);
        }


        /// <summary> Operates <c>Multiply</c> unaly operation. </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Multiply<T>(in T x, in T y)
        {
            unchecked
            {
                if(typeof(T) == typeof(bool))
                {
                    throw new NotSupportedException();
                }
                if(typeof(T) == typeof(byte))
                {
                    var z = (byte)(Unsafe.As<T, byte>(ref Unsafe.AsRef(x)) * Unsafe.As<T, byte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<byte, T>(ref z);
                }
                if(typeof(T) == typeof(ushort))
                {
                    var z = (ushort)(Unsafe.As<T, ushort>(ref Unsafe.AsRef(x)) * Unsafe.As<T, ushort>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ushort, T>(ref z);
                }
                if(typeof(T) == typeof(uint))
                {
                    var z = (uint)(Unsafe.As<T, uint>(ref Unsafe.AsRef(x)) * Unsafe.As<T, uint>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<uint, T>(ref z);
                }
                if(typeof(T) == typeof(ulong))
                {
                    var z = (ulong)(Unsafe.As<T, ulong>(ref Unsafe.AsRef(x)) * Unsafe.As<T, ulong>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ulong, T>(ref z);
                }
                if(typeof(T) == typeof(sbyte))
                {
                    var z = (sbyte)(Unsafe.As<T, sbyte>(ref Unsafe.AsRef(x)) * Unsafe.As<T, sbyte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<sbyte, T>(ref z);
                }
                if(typeof(T) == typeof(short))
                {
                    var z = (short)(Unsafe.As<T, short>(ref Unsafe.AsRef(x)) * Unsafe.As<T, short>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<short, T>(ref z);
                }
                if(typeof(T) == typeof(int))
                {
                    var z = (int)(Unsafe.As<T, int>(ref Unsafe.AsRef(x)) * Unsafe.As<T, int>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<int, T>(ref z);
                }
                if(typeof(T) == typeof(long))
                {
                    var z = (long)(Unsafe.As<T, long>(ref Unsafe.AsRef(x)) * Unsafe.As<T, long>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<long, T>(ref z);
                }
                if(typeof(T) == typeof(float))
                {
                    var z = (float)(Unsafe.As<T, float>(ref Unsafe.AsRef(x)) * Unsafe.As<T, float>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<float, T>(ref z);
                }
                if(typeof(T) == typeof(double))
                {
                    var z = (double)(Unsafe.As<T, double>(ref Unsafe.AsRef(x)) * Unsafe.As<T, double>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<double, T>(ref z);
                }
                if(typeof(T) == typeof(decimal))
                {
                    var z = (decimal)(Unsafe.As<T, decimal>(ref Unsafe.AsRef(x)) * Unsafe.As<T, decimal>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<decimal, T>(ref z);
                }
            }
            return Cache<T>.Instance.Multiply(x, y);
        }


        /// <summary> Operates <c>MultiplyChecked</c> unaly operation. </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T MultiplyChecked<T>(in T x, in T y)
        {
            checked
            {
                if(typeof(T) == typeof(bool))
                {
                    throw new NotSupportedException();
                }
                if(typeof(T) == typeof(byte))
                {
                    var z = (byte)(Unsafe.As<T, byte>(ref Unsafe.AsRef(x)) * Unsafe.As<T, byte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<byte, T>(ref z);
                }
                if(typeof(T) == typeof(ushort))
                {
                    var z = (ushort)(Unsafe.As<T, ushort>(ref Unsafe.AsRef(x)) * Unsafe.As<T, ushort>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ushort, T>(ref z);
                }
                if(typeof(T) == typeof(uint))
                {
                    var z = (uint)(Unsafe.As<T, uint>(ref Unsafe.AsRef(x)) * Unsafe.As<T, uint>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<uint, T>(ref z);
                }
                if(typeof(T) == typeof(ulong))
                {
                    var z = (ulong)(Unsafe.As<T, ulong>(ref Unsafe.AsRef(x)) * Unsafe.As<T, ulong>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ulong, T>(ref z);
                }
                if(typeof(T) == typeof(sbyte))
                {
                    var z = (sbyte)(Unsafe.As<T, sbyte>(ref Unsafe.AsRef(x)) * Unsafe.As<T, sbyte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<sbyte, T>(ref z);
                }
                if(typeof(T) == typeof(short))
                {
                    var z = (short)(Unsafe.As<T, short>(ref Unsafe.AsRef(x)) * Unsafe.As<T, short>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<short, T>(ref z);
                }
                if(typeof(T) == typeof(int))
                {
                    var z = (int)(Unsafe.As<T, int>(ref Unsafe.AsRef(x)) * Unsafe.As<T, int>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<int, T>(ref z);
                }
                if(typeof(T) == typeof(long))
                {
                    var z = (long)(Unsafe.As<T, long>(ref Unsafe.AsRef(x)) * Unsafe.As<T, long>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<long, T>(ref z);
                }
                if(typeof(T) == typeof(float))
                {
                    var z = (float)(Unsafe.As<T, float>(ref Unsafe.AsRef(x)) * Unsafe.As<T, float>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<float, T>(ref z);
                }
                if(typeof(T) == typeof(double))
                {
                    var z = (double)(Unsafe.As<T, double>(ref Unsafe.AsRef(x)) * Unsafe.As<T, double>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<double, T>(ref z);
                }
                if(typeof(T) == typeof(decimal))
                {
                    var z = (decimal)(Unsafe.As<T, decimal>(ref Unsafe.AsRef(x)) * Unsafe.As<T, decimal>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<decimal, T>(ref z);
                }
            }
            return Cache<T>.Instance.MultiplyChecked(x, y);
        }


        /// <summary> Operates <c>Divide</c> unaly operation. </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Divide<T>(in T x, in T y)
        {
            unchecked
            {
                if(typeof(T) == typeof(bool))
                {
                    throw new NotSupportedException();
                }
                if(typeof(T) == typeof(byte))
                {
                    var z = (byte)(Unsafe.As<T, byte>(ref Unsafe.AsRef(x)) / Unsafe.As<T, byte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<byte, T>(ref z);
                }
                if(typeof(T) == typeof(ushort))
                {
                    var z = (ushort)(Unsafe.As<T, ushort>(ref Unsafe.AsRef(x)) / Unsafe.As<T, ushort>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ushort, T>(ref z);
                }
                if(typeof(T) == typeof(uint))
                {
                    var z = (uint)(Unsafe.As<T, uint>(ref Unsafe.AsRef(x)) / Unsafe.As<T, uint>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<uint, T>(ref z);
                }
                if(typeof(T) == typeof(ulong))
                {
                    var z = (ulong)(Unsafe.As<T, ulong>(ref Unsafe.AsRef(x)) / Unsafe.As<T, ulong>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ulong, T>(ref z);
                }
                if(typeof(T) == typeof(sbyte))
                {
                    var z = (sbyte)(Unsafe.As<T, sbyte>(ref Unsafe.AsRef(x)) / Unsafe.As<T, sbyte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<sbyte, T>(ref z);
                }
                if(typeof(T) == typeof(short))
                {
                    var z = (short)(Unsafe.As<T, short>(ref Unsafe.AsRef(x)) / Unsafe.As<T, short>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<short, T>(ref z);
                }
                if(typeof(T) == typeof(int))
                {
                    var z = (int)(Unsafe.As<T, int>(ref Unsafe.AsRef(x)) / Unsafe.As<T, int>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<int, T>(ref z);
                }
                if(typeof(T) == typeof(long))
                {
                    var z = (long)(Unsafe.As<T, long>(ref Unsafe.AsRef(x)) / Unsafe.As<T, long>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<long, T>(ref z);
                }
                if(typeof(T) == typeof(float))
                {
                    var z = (float)(Unsafe.As<T, float>(ref Unsafe.AsRef(x)) / Unsafe.As<T, float>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<float, T>(ref z);
                }
                if(typeof(T) == typeof(double))
                {
                    var z = (double)(Unsafe.As<T, double>(ref Unsafe.AsRef(x)) / Unsafe.As<T, double>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<double, T>(ref z);
                }
                if(typeof(T) == typeof(decimal))
                {
                    var z = (decimal)(Unsafe.As<T, decimal>(ref Unsafe.AsRef(x)) / Unsafe.As<T, decimal>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<decimal, T>(ref z);
                }
            }
            return Cache<T>.Instance.Divide(x, y);
        }


        /// <summary> Operates <c>Modulo</c> unaly operation. </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Modulo<T>(in T x, in T y)
        {
            unchecked
            {
                if(typeof(T) == typeof(bool))
                {
                    throw new NotSupportedException();
                }
                if(typeof(T) == typeof(byte))
                {
                    var z = (byte)(Unsafe.As<T, byte>(ref Unsafe.AsRef(x)) % Unsafe.As<T, byte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<byte, T>(ref z);
                }
                if(typeof(T) == typeof(ushort))
                {
                    var z = (ushort)(Unsafe.As<T, ushort>(ref Unsafe.AsRef(x)) % Unsafe.As<T, ushort>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ushort, T>(ref z);
                }
                if(typeof(T) == typeof(uint))
                {
                    var z = (uint)(Unsafe.As<T, uint>(ref Unsafe.AsRef(x)) % Unsafe.As<T, uint>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<uint, T>(ref z);
                }
                if(typeof(T) == typeof(ulong))
                {
                    var z = (ulong)(Unsafe.As<T, ulong>(ref Unsafe.AsRef(x)) % Unsafe.As<T, ulong>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ulong, T>(ref z);
                }
                if(typeof(T) == typeof(sbyte))
                {
                    var z = (sbyte)(Unsafe.As<T, sbyte>(ref Unsafe.AsRef(x)) % Unsafe.As<T, sbyte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<sbyte, T>(ref z);
                }
                if(typeof(T) == typeof(short))
                {
                    var z = (short)(Unsafe.As<T, short>(ref Unsafe.AsRef(x)) % Unsafe.As<T, short>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<short, T>(ref z);
                }
                if(typeof(T) == typeof(int))
                {
                    var z = (int)(Unsafe.As<T, int>(ref Unsafe.AsRef(x)) % Unsafe.As<T, int>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<int, T>(ref z);
                }
                if(typeof(T) == typeof(long))
                {
                    var z = (long)(Unsafe.As<T, long>(ref Unsafe.AsRef(x)) % Unsafe.As<T, long>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<long, T>(ref z);
                }
                if(typeof(T) == typeof(float))
                {
                    var z = (float)(Unsafe.As<T, float>(ref Unsafe.AsRef(x)) % Unsafe.As<T, float>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<float, T>(ref z);
                }
                if(typeof(T) == typeof(double))
                {
                    var z = (double)(Unsafe.As<T, double>(ref Unsafe.AsRef(x)) % Unsafe.As<T, double>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<double, T>(ref z);
                }
                if(typeof(T) == typeof(decimal))
                {
                    var z = (decimal)(Unsafe.As<T, decimal>(ref Unsafe.AsRef(x)) % Unsafe.As<T, decimal>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<decimal, T>(ref z);
                }
            }
            return Cache<T>.Instance.Modulo(x, y);
        }


        /// <summary> Operates <c>BitwiseOr</c> unaly operation. </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T BitwiseOr<T>(in T x, in T y)
        {
            unchecked
            {
                if(typeof(T) == typeof(bool))
                {
                    var z = (bool)(Unsafe.As<T, bool>(ref Unsafe.AsRef(x)) | Unsafe.As<T, bool>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<bool, T>(ref z);
                }
                if(typeof(T) == typeof(byte))
                {
                    var z = (byte)(Unsafe.As<T, byte>(ref Unsafe.AsRef(x)) | Unsafe.As<T, byte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<byte, T>(ref z);
                }
                if(typeof(T) == typeof(ushort))
                {
                    var z = (ushort)(Unsafe.As<T, ushort>(ref Unsafe.AsRef(x)) | Unsafe.As<T, ushort>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ushort, T>(ref z);
                }
                if(typeof(T) == typeof(uint))
                {
                    var z = (uint)(Unsafe.As<T, uint>(ref Unsafe.AsRef(x)) | Unsafe.As<T, uint>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<uint, T>(ref z);
                }
                if(typeof(T) == typeof(ulong))
                {
                    var z = (ulong)(Unsafe.As<T, ulong>(ref Unsafe.AsRef(x)) | Unsafe.As<T, ulong>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ulong, T>(ref z);
                }
                if(typeof(T) == typeof(sbyte))
                {
                    var z = (sbyte)(Unsafe.As<T, sbyte>(ref Unsafe.AsRef(x)) | Unsafe.As<T, sbyte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<sbyte, T>(ref z);
                }
                if(typeof(T) == typeof(short))
                {
                    var z = (short)(Unsafe.As<T, short>(ref Unsafe.AsRef(x)) | Unsafe.As<T, short>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<short, T>(ref z);
                }
                if(typeof(T) == typeof(int))
                {
                    var z = (int)(Unsafe.As<T, int>(ref Unsafe.AsRef(x)) | Unsafe.As<T, int>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<int, T>(ref z);
                }
                if(typeof(T) == typeof(long))
                {
                    var z = (long)(Unsafe.As<T, long>(ref Unsafe.AsRef(x)) | Unsafe.As<T, long>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<long, T>(ref z);
                }
                if(typeof(T) == typeof(float))
                {
                    throw new NotSupportedException();
                }
                if(typeof(T) == typeof(double))
                {
                    throw new NotSupportedException();
                }
                if(typeof(T) == typeof(decimal))
                {
                    throw new NotSupportedException();
                }
            }
            return Cache<T>.Instance.BitwiseOr(x, y);
        }


        /// <summary> Operates <c>BitwiseAnd</c> unaly operation. </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T BitwiseAnd<T>(in T x, in T y)
        {
            unchecked
            {
                if(typeof(T) == typeof(bool))
                {
                    var z = (bool)(Unsafe.As<T, bool>(ref Unsafe.AsRef(x)) & Unsafe.As<T, bool>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<bool, T>(ref z);
                }
                if(typeof(T) == typeof(byte))
                {
                    var z = (byte)(Unsafe.As<T, byte>(ref Unsafe.AsRef(x)) & Unsafe.As<T, byte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<byte, T>(ref z);
                }
                if(typeof(T) == typeof(ushort))
                {
                    var z = (ushort)(Unsafe.As<T, ushort>(ref Unsafe.AsRef(x)) & Unsafe.As<T, ushort>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ushort, T>(ref z);
                }
                if(typeof(T) == typeof(uint))
                {
                    var z = (uint)(Unsafe.As<T, uint>(ref Unsafe.AsRef(x)) & Unsafe.As<T, uint>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<uint, T>(ref z);
                }
                if(typeof(T) == typeof(ulong))
                {
                    var z = (ulong)(Unsafe.As<T, ulong>(ref Unsafe.AsRef(x)) & Unsafe.As<T, ulong>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ulong, T>(ref z);
                }
                if(typeof(T) == typeof(sbyte))
                {
                    var z = (sbyte)(Unsafe.As<T, sbyte>(ref Unsafe.AsRef(x)) & Unsafe.As<T, sbyte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<sbyte, T>(ref z);
                }
                if(typeof(T) == typeof(short))
                {
                    var z = (short)(Unsafe.As<T, short>(ref Unsafe.AsRef(x)) & Unsafe.As<T, short>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<short, T>(ref z);
                }
                if(typeof(T) == typeof(int))
                {
                    var z = (int)(Unsafe.As<T, int>(ref Unsafe.AsRef(x)) & Unsafe.As<T, int>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<int, T>(ref z);
                }
                if(typeof(T) == typeof(long))
                {
                    var z = (long)(Unsafe.As<T, long>(ref Unsafe.AsRef(x)) & Unsafe.As<T, long>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<long, T>(ref z);
                }
                if(typeof(T) == typeof(float))
                {
                    throw new NotSupportedException();
                }
                if(typeof(T) == typeof(double))
                {
                    throw new NotSupportedException();
                }
                if(typeof(T) == typeof(decimal))
                {
                    throw new NotSupportedException();
                }
            }
            return Cache<T>.Instance.BitwiseAnd(x, y);
        }


        /// <summary> Operates <c>BitwiseXor</c> unaly operation. </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T BitwiseXor<T>(in T x, in T y)
        {
            unchecked
            {
                if(typeof(T) == typeof(bool))
                {
                    var z = (bool)(Unsafe.As<T, bool>(ref Unsafe.AsRef(x)) ^ Unsafe.As<T, bool>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<bool, T>(ref z);
                }
                if(typeof(T) == typeof(byte))
                {
                    var z = (byte)(Unsafe.As<T, byte>(ref Unsafe.AsRef(x)) ^ Unsafe.As<T, byte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<byte, T>(ref z);
                }
                if(typeof(T) == typeof(ushort))
                {
                    var z = (ushort)(Unsafe.As<T, ushort>(ref Unsafe.AsRef(x)) ^ Unsafe.As<T, ushort>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ushort, T>(ref z);
                }
                if(typeof(T) == typeof(uint))
                {
                    var z = (uint)(Unsafe.As<T, uint>(ref Unsafe.AsRef(x)) ^ Unsafe.As<T, uint>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<uint, T>(ref z);
                }
                if(typeof(T) == typeof(ulong))
                {
                    var z = (ulong)(Unsafe.As<T, ulong>(ref Unsafe.AsRef(x)) ^ Unsafe.As<T, ulong>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<ulong, T>(ref z);
                }
                if(typeof(T) == typeof(sbyte))
                {
                    var z = (sbyte)(Unsafe.As<T, sbyte>(ref Unsafe.AsRef(x)) ^ Unsafe.As<T, sbyte>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<sbyte, T>(ref z);
                }
                if(typeof(T) == typeof(short))
                {
                    var z = (short)(Unsafe.As<T, short>(ref Unsafe.AsRef(x)) ^ Unsafe.As<T, short>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<short, T>(ref z);
                }
                if(typeof(T) == typeof(int))
                {
                    var z = (int)(Unsafe.As<T, int>(ref Unsafe.AsRef(x)) ^ Unsafe.As<T, int>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<int, T>(ref z);
                }
                if(typeof(T) == typeof(long))
                {
                    var z = (long)(Unsafe.As<T, long>(ref Unsafe.AsRef(x)) ^ Unsafe.As<T, long>(ref Unsafe.AsRef(y)));
                    return Unsafe.As<long, T>(ref z);
                }
                if(typeof(T) == typeof(float))
                {
                    throw new NotSupportedException();
                }
                if(typeof(T) == typeof(double))
                {
                    throw new NotSupportedException();
                }
                if(typeof(T) == typeof(decimal))
                {
                    throw new NotSupportedException();
                }
            }
            return Cache<T>.Instance.BitwiseXor(x, y);
        }

    }
}
