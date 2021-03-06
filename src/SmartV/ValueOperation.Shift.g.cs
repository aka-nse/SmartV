// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY T4. DO NOT CHANGE IT. CHANGE THE .tt FILE INSTEAD.
// </auto-generated>
using System.Runtime.CompilerServices;
namespace SmartV;

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
        if(typeof(T) == typeof(byte   )) return As<byte   , T>((byte   )(As<T, byte   >(x) << y));
        if(typeof(T) == typeof(ushort )) return As<ushort , T>((ushort )(As<T, ushort >(x) << y));
        if(typeof(T) == typeof(uint   )) return As<uint   , T>((uint   )(As<T, uint   >(x) << y));
        if(typeof(T) == typeof(ulong  )) return As<ulong  , T>((ulong  )(As<T, ulong  >(x) << y));
        if(typeof(T) == typeof(sbyte  )) return As<sbyte  , T>((sbyte  )(As<T, sbyte  >(x) << y));
        if(typeof(T) == typeof(short  )) return As<short  , T>((short  )(As<T, short  >(x) << y));
        if(typeof(T) == typeof(int    )) return As<int    , T>((int    )(As<T, int    >(x) << y));
        if(typeof(T) == typeof(long   )) return As<long   , T>((long   )(As<T, long   >(x) << y));
        if(typeof(T) == typeof(bool   )) throw new NotSupportedException(); 
        if(typeof(T) == typeof(float  )) throw new NotSupportedException(); 
        if(typeof(T) == typeof(double )) throw new NotSupportedException(); 
        if(typeof(T) == typeof(decimal)) throw new NotSupportedException(); 
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
        if(typeof(T) == typeof(byte   )) return As<byte   , T>((byte   )(As<T, byte   >(x) >> y));
        if(typeof(T) == typeof(ushort )) return As<ushort , T>((ushort )(As<T, ushort >(x) >> y));
        if(typeof(T) == typeof(uint   )) return As<uint   , T>((uint   )(As<T, uint   >(x) >> y));
        if(typeof(T) == typeof(ulong  )) return As<ulong  , T>((ulong  )(As<T, ulong  >(x) >> y));
        if(typeof(T) == typeof(sbyte  )) return As<sbyte  , T>((sbyte  )(As<T, sbyte  >(x) >> y));
        if(typeof(T) == typeof(short  )) return As<short  , T>((short  )(As<T, short  >(x) >> y));
        if(typeof(T) == typeof(int    )) return As<int    , T>((int    )(As<T, int    >(x) >> y));
        if(typeof(T) == typeof(long   )) return As<long   , T>((long   )(As<T, long   >(x) >> y));
        if(typeof(T) == typeof(bool   )) throw new NotSupportedException(); 
        if(typeof(T) == typeof(float  )) throw new NotSupportedException(); 
        if(typeof(T) == typeof(double )) throw new NotSupportedException(); 
        if(typeof(T) == typeof(decimal)) throw new NotSupportedException(); 
        return Cache<T>.Instance.ShiftRight(x, y);
    }

}

