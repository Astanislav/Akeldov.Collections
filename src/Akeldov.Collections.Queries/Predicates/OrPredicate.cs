namespace Akeldov.Collections.Queries
{
    internal struct OrFunc<T, T1, T2> : IPredicate<T>, IFunc<T, bool>
        where T1 : struct, IPredicate<T>, IFunc<T, bool>
        where T2 : struct, IPredicate<T>, IFunc<T, bool>
    {
        private T1 _first;
        private T2 _second;

        public OrFunc(T1 first, T2 second)
        {
            _first = first;
            _second = second;
        }

        public bool Invoke(T value) => _first.Invoke(value) || _second.Invoke(value);
    }
}
