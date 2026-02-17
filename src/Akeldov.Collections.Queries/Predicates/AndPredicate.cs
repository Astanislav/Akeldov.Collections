namespace Akeldov.Collections.Queries
{
    public struct AndPredicate<T, T1, T2> : IPredicate<T>, IFunc<T, bool>
        where T1 : struct, IPredicate<T>, IFunc<T, bool>
        where T2 : struct, IPredicate<T>, IFunc<T, bool>
    {
        private T1 _first;
        private T2 _second;

        public AndPredicate(T1 first, T2 second)
        {
            _first = first;
            _second = second;
        }

        public bool Invoke(T value) => _first.Invoke(value) && _second.Invoke(value);
    }
}
