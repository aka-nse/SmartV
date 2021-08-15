﻿using System;
using System.Runtime.CompilerServices;

namespace SmartV
{
    partial class ValueOperation
    {

        /// <summary> Operates <c>UnaryPlus</c> unaly operation. </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T UnaryPlus<T>(in T x)
        {
            if(typeof(T) == typeof(bool))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(byte))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(ushort))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(uint))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(ulong))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(sbyte))
            {
                var z = (sbyte)(+Unsafe.As<T, sbyte>(ref Unsafe.AsRef(x)));
                return Unsafe.As<sbyte, T>(ref z);
            }
            if(typeof(T) == typeof(short))
            {
                var z = (short)(+Unsafe.As<T, short>(ref Unsafe.AsRef(x)));
                return Unsafe.As<short, T>(ref z);
            }
            if(typeof(T) == typeof(int))
            {
                var z = (int)(+Unsafe.As<T, int>(ref Unsafe.AsRef(x)));
                return Unsafe.As<int, T>(ref z);
            }
            if(typeof(T) == typeof(long))
            {
                var z = (long)(+Unsafe.As<T, long>(ref Unsafe.AsRef(x)));
                return Unsafe.As<long, T>(ref z);
            }
            if(typeof(T) == typeof(float))
            {
                var z = (float)(+Unsafe.As<T, float>(ref Unsafe.AsRef(x)));
                return Unsafe.As<float, T>(ref z);
            }
            if(typeof(T) == typeof(double))
            {
                var z = (double)(+Unsafe.As<T, double>(ref Unsafe.AsRef(x)));
                return Unsafe.As<double, T>(ref z);
            }
            if(typeof(T) == typeof(decimal))
            {
                var z = (decimal)(+Unsafe.As<T, decimal>(ref Unsafe.AsRef(x)));
                return Unsafe.As<decimal, T>(ref z);
            }
            return Cache<T>.Instance.UnaryPlus(x);
        }


        /// <summary> Operates <c>UnaryMinus</c> unaly operation. </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T UnaryMinus<T>(in T x)
        {
            if(typeof(T) == typeof(bool))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(byte))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(ushort))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(uint))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(ulong))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(sbyte))
            {
                var z = (sbyte)(-Unsafe.As<T, sbyte>(ref Unsafe.AsRef(x)));
                return Unsafe.As<sbyte, T>(ref z);
            }
            if(typeof(T) == typeof(short))
            {
                var z = (short)(-Unsafe.As<T, short>(ref Unsafe.AsRef(x)));
                return Unsafe.As<short, T>(ref z);
            }
            if(typeof(T) == typeof(int))
            {
                var z = (int)(-Unsafe.As<T, int>(ref Unsafe.AsRef(x)));
                return Unsafe.As<int, T>(ref z);
            }
            if(typeof(T) == typeof(long))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(float))
            {
                var z = (float)(-Unsafe.As<T, float>(ref Unsafe.AsRef(x)));
                return Unsafe.As<float, T>(ref z);
            }
            if(typeof(T) == typeof(double))
            {
                var z = (double)(-Unsafe.As<T, double>(ref Unsafe.AsRef(x)));
                return Unsafe.As<double, T>(ref z);
            }
            if(typeof(T) == typeof(decimal))
            {
                var z = (decimal)(-Unsafe.As<T, decimal>(ref Unsafe.AsRef(x)));
                return Unsafe.As<decimal, T>(ref z);
            }
            return Cache<T>.Instance.UnaryMinus(x);
        }


        /// <summary> Operates <c>Not</c> unaly operation. </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Not<T>(in T x)
        {
            if(typeof(T) == typeof(bool))
            {
                var z = (bool)(!Unsafe.As<T, bool>(ref Unsafe.AsRef(x)));
                return Unsafe.As<bool, T>(ref z);
            }
            if(typeof(T) == typeof(byte))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(ushort))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(uint))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(ulong))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(sbyte))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(short))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(int))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(long))
            {
                throw new NotSupportedException();
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
            return Cache<T>.Instance.Not(x);
        }


        /// <summary> Operates <c>Complement</c> unaly operation. </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Complement<T>(in T x)
        {
            if(typeof(T) == typeof(bool))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(byte))
            {
                var z = (byte)(~Unsafe.As<T, byte>(ref Unsafe.AsRef(x)));
                return Unsafe.As<byte, T>(ref z);
            }
            if(typeof(T) == typeof(ushort))
            {
                var z = (ushort)(~Unsafe.As<T, ushort>(ref Unsafe.AsRef(x)));
                return Unsafe.As<ushort, T>(ref z);
            }
            if(typeof(T) == typeof(uint))
            {
                var z = (uint)(~Unsafe.As<T, uint>(ref Unsafe.AsRef(x)));
                return Unsafe.As<uint, T>(ref z);
            }
            if(typeof(T) == typeof(ulong))
            {
                var z = (ulong)(~Unsafe.As<T, ulong>(ref Unsafe.AsRef(x)));
                return Unsafe.As<ulong, T>(ref z);
            }
            if(typeof(T) == typeof(sbyte))
            {
                var z = (sbyte)(~Unsafe.As<T, sbyte>(ref Unsafe.AsRef(x)));
                return Unsafe.As<sbyte, T>(ref z);
            }
            if(typeof(T) == typeof(short))
            {
                var z = (short)(~Unsafe.As<T, short>(ref Unsafe.AsRef(x)));
                return Unsafe.As<short, T>(ref z);
            }
            if(typeof(T) == typeof(int))
            {
                var z = (int)(~Unsafe.As<T, int>(ref Unsafe.AsRef(x)));
                return Unsafe.As<int, T>(ref z);
            }
            if(typeof(T) == typeof(long))
            {
                var z = (long)(~Unsafe.As<T, long>(ref Unsafe.AsRef(x)));
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
            return Cache<T>.Instance.Complement(x);
        }

    }
}