using System;
using System.Runtime.CompilerServices;

namespace Akeldov.Collections.Queries
{
    internal struct LambdaFunc<TFrom, TTo> : IFunc<TFrom, TTo>
    {
        private readonly Func<TFrom, TTo> _func;

        public LambdaFunc(Func<TFrom, TTo> func)
        {
            _func = func;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TTo Invoke(TFrom value) => _func(value);
    }
}
