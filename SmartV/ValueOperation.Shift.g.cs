﻿using System;
using System.Runtime.CompilerServices;

namespace SmartV
{
    partial class ValueOperation
    {

        /// <summary> Operates <c>ShiftLeft</c> unaly operation. </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ShiftLeft<T>(in T x, int y)
        {
            if(typeof(T) == typeof(bool))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(byte))
            {
                var z = (byte)(Unsafe.As<T, byte>(ref Unsafe.AsRef(x)) << y);
                return Unsafe.As<byte, T>(ref z);
            }
            if(typeof(T) == typeof(ushort))
            {
                var z = (ushort)(Unsafe.As<T, ushort>(ref Unsafe.AsRef(x)) << y);
                return Unsafe.As<ushort, T>(ref z);
            }
            if(typeof(T) == typeof(uint))
            {
                var z = (uint)(Unsafe.As<T, uint>(ref Unsafe.AsRef(x)) << y);
                return Unsafe.As<uint, T>(ref z);
            }
            if(typeof(T) == typeof(ulong))
            {
                var z = (ulong)(Unsafe.As<T, ulong>(ref Unsafe.AsRef(x)) << y);
                return Unsafe.As<ulong, T>(ref z);
            }
            if(typeof(T) == typeof(sbyte))
            {
                var z = (sbyte)(Unsafe.As<T, sbyte>(ref Unsafe.AsRef(x)) << y);
                return Unsafe.As<sbyte, T>(ref z);
            }
            if(typeof(T) == typeof(short))
            {
                var z = (short)(Unsafe.As<T, short>(ref Unsafe.AsRef(x)) << y);
                return Unsafe.As<short, T>(ref z);
            }
            if(typeof(T) == typeof(int))
            {
                var z = (int)(Unsafe.As<T, int>(ref Unsafe.AsRef(x)) << y);
                return Unsafe.As<int, T>(ref z);
            }
            if(typeof(T) == typeof(long))
            {
                var z = (long)(Unsafe.As<T, long>(ref Unsafe.AsRef(x)) << y);
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
            return Cache<T>.Instance.ShiftLeft(x, y);
        }


        /// <summary> Operates <c>ShiftRight</c> unaly operation. </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ShiftRight<T>(in T x, int y)
        {
            if(typeof(T) == typeof(bool))
            {
                throw new NotSupportedException();
            }
            if(typeof(T) == typeof(byte))
            {
                var z = (byte)(Unsafe.As<T, byte>(ref Unsafe.AsRef(x)) >> y);
                return Unsafe.As<byte, T>(ref z);
            }
            if(typeof(T) == typeof(ushort))
            {
                var z = (ushort)(Unsafe.As<T, ushort>(ref Unsafe.AsRef(x)) >> y);
                return Unsafe.As<ushort, T>(ref z);
            }
            if(typeof(T) == typeof(uint))
            {
                var z = (uint)(Unsafe.As<T, uint>(ref Unsafe.AsRef(x)) >> y);
                return Unsafe.As<uint, T>(ref z);
            }
            if(typeof(T) == typeof(ulong))
            {
                var z = (ulong)(Unsafe.As<T, ulong>(ref Unsafe.AsRef(x)) >> y);
                return Unsafe.As<ulong, T>(ref z);
            }
            if(typeof(T) == typeof(sbyte))
            {
                var z = (sbyte)(Unsafe.As<T, sbyte>(ref Unsafe.AsRef(x)) >> y);
                return Unsafe.As<sbyte, T>(ref z);
            }
            if(typeof(T) == typeof(short))
            {
                var z = (short)(Unsafe.As<T, short>(ref Unsafe.AsRef(x)) >> y);
                return Unsafe.As<short, T>(ref z);
            }
            if(typeof(T) == typeof(int))
            {
                var z = (int)(Unsafe.As<T, int>(ref Unsafe.AsRef(x)) >> y);
                return Unsafe.As<int, T>(ref z);
            }
            if(typeof(T) == typeof(long))
            {
                var z = (long)(Unsafe.As<T, long>(ref Unsafe.AsRef(x)) >> y);
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
            return Cache<T>.Instance.ShiftRight(x, y);
        }

    }
}
