using System;
using System.Runtime.CompilerServices;

namespace Akeldov.Collections.Queries
{
    public struct LambdaPredicate<TFrom> : IPredicate<TFrom>
    {
        private readonly Func<TFrom, bool> _func;

        public LambdaPredicate(Func<TFrom, bool> func)
        {
            _func = func;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Invoke(TFrom value) => _func(value);
    }
}
