using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
namespace SmartV;


public ref struct VectorFuncArg<T>
    where T : unmanaged
{
    public readonly bool IsScalar;
    public readonly ReadOnlySpan<T> Vector;

    private VectorFuncArg(bool isScalar, T scalar, ReadOnlySpan<T> vector)
    {
        IsScalar = isScalar;
        if(isScalar)
        {
            var tmp = new T[Vector<T>.Count];
            for (var i = 0; i < tmp.Length; ++i) tmp[i] = scalar;
            Vector = tmp;
        }
        else
        {
            Vector = vector;
        }
    }

    public ref readonly Vector<T> BySimd(int simdIndex)
    {
        if (IsScalar)
        {
            return ref Unsafe.As<T, Vector<T>>(ref Unsafe.AsRef(Vector[0]));
        }
        else
        {
            return ref Unsafe.As<T, Vector<T>>(ref Unsafe.AsRef(Vector[simdIndex * Vector<T>.Count]));
        }
    }

    public static implicit operator VectorFuncArg<T>(T scalar)
        => new(true, scalar, ReadOnlySpan<T>.Empty);

    public static implicit operator VectorFuncArg<T>(Span<T> vector)
        => new(false, default!, vector);

    public static implicit operator VectorFuncArg<T>(ReadOnlySpan<T> vector)
        => new(false, default!, vector);
}


partial class VectorOperation
{
    private sealed class Visitor<TFunc, TVFunc> : ExpressionVisitor
    {
        private readonly Expression<TFunc> _expression;
        private readonly IReadOnlyDictionary<ParameterExpression, ParameterExpression> _paramMap;
        private readonly ParameterExpression[] _newParameters;

        public Visitor(Expression<TFunc> expr)
        {
            static T identity<T>(T value) => value;

            static ParameterExpression makeVector(ParameterExpression p)
                => Expression.Parameter(typeof(Vector<>).MakeGenericType(p.Type), p.Name);

            _expression = expr;
            _paramMap = expr.Parameters
                .ToDictionary(identity, makeVector);
            _newParameters = expr.Parameters
                .Select(p => _paramMap[p])
                .ToArray();
        }




        private static bool TryReplace(Type tfrom, Type tto, MethodCallExpression input, string methodName, out MethodCallExpression output)
        {
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Static;
            static MethodInfo getMethodInfo(Type tto, string methodName, IEnumerable<Type> parameters)
                => tto
                    .GetMethods(flags)
                    .Where(m => m.Name == methodName)
                    .First(m => m.GetParameters().Select(p => p.ParameterType).SequenceEqual(parameters));

            if (input.Method.DeclaringType == tfrom && input.Method.Name == methodName)
            {
                var method = getMethodInfo(tto, methodName, input.Arguments.Select(arg => arg.Type));
                output = Expression.Call(method, input.Arguments);
                return true;
            }
            output = null!;
            return false;
        }


        public Expression<TVFunc> Build()
            => Expression.Lambda<TVFunc>(Visit(_expression.Body), _newParameters);


        public override Expression Visit(Expression node) => throw new NotImplementedException();


        protected override Expression VisitParameter(ParameterExpression node)
            => _paramMap[node];


        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            MethodCallExpression output;
            if(TryReplace(typeof(Math), typeof(Vector), node, nameof(Vector.Abs), out output))
            {
                return output;
            }
#if NET5_0_OR_GREATER
            if(TryReplace(typeof(Math), typeof(Vector), node, nameof(Vector.Ceiling), out output))
            {
                return output;
            }
            if(TryReplace(typeof(Math), typeof(Vector), node, nameof(Vector.Floor), out output))
            {
                return output;
            }
#endif
            return base.VisitMethodCall(node);
        }
    }


    private static Expression<TVFunc> Simd<TFunc, TVFunc>(Expression<TFunc> expr)
        => new Visitor<TFunc, TVFunc>(expr).Build();
}
