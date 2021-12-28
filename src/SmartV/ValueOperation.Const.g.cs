// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY T4. DO NOT CHANGE IT. CHANGE THE .tt FILE INSTEAD.
// </auto-generated>
using System.Numerics;
using System.Runtime.CompilerServices;
namespace SmartV;

partial class ValueOperation
{
    
    /// <summary> Gets a value which is equals to <c>0</c> of <typeparamref name="T"/>. </summary>
    /// <exception cref="NotSupportedException" />
    public static T Zero<T>()
    {
            if(typeof(T) == typeof(byte   )) return As<byte   , T>(0);
            if(typeof(T) == typeof(ushort )) return As<ushort , T>(0);
            if(typeof(T) == typeof(uint   )) return As<uint   , T>(0);
            if(typeof(T) == typeof(ulong  )) return As<ulong  , T>(0);
            if(typeof(T) == typeof(sbyte  )) return As<sbyte  , T>(0);
            if(typeof(T) == typeof(short  )) return As<short  , T>(0);
            if(typeof(T) == typeof(int    )) return As<int    , T>(0);
            if(typeof(T) == typeof(long   )) return As<long   , T>(0);
            if(typeof(T) == typeof(float  )) return As<float  , T>(0);
            if(typeof(T) == typeof(double )) return As<double , T>(0);
            if(typeof(T) == typeof(decimal)) return As<decimal, T>(0);
            if(typeof(T) == typeof(Complex)) return As<Complex, T>(0);
        return Cache<T>.Instance.Zero;
    }
    
    /// <summary> Gets a value which is equals to <c>1</c> of <typeparamref name="T"/>. </summary>
    /// <exception cref="NotSupportedException" />
    public static T One<T>()
    {
            if(typeof(T) == typeof(byte   )) return As<byte   , T>(1);
            if(typeof(T) == typeof(ushort )) return As<ushort , T>(1);
            if(typeof(T) == typeof(uint   )) return As<uint   , T>(1);
            if(typeof(T) == typeof(ulong  )) return As<ulong  , T>(1);
            if(typeof(T) == typeof(sbyte  )) return As<sbyte  , T>(1);
            if(typeof(T) == typeof(short  )) return As<short  , T>(1);
            if(typeof(T) == typeof(int    )) return As<int    , T>(1);
            if(typeof(T) == typeof(long   )) return As<long   , T>(1);
            if(typeof(T) == typeof(float  )) return As<float  , T>(1);
            if(typeof(T) == typeof(double )) return As<double , T>(1);
            if(typeof(T) == typeof(decimal)) return As<decimal, T>(1);
            if(typeof(T) == typeof(Complex)) return As<Complex, T>(1);
        return Cache<T>.Instance.One;
    }
}