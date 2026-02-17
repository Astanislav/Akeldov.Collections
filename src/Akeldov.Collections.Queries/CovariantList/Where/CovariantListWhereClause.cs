namespace Akeldov.Collections.Queries
{
    public struct CovariantListWhereClause<TItem, TPredicate>
        where TPredicate : struct, IPredicate<TItem>
    {
        internal CovariantList<TItem> _source;
        internal TPredicate _predicate;

        public CovariantListWhereClause(CovariantList<TItem> source, TPredicate predicate)
        {
            _source = source;
            _predicate = predicate;
        }

        public CovariantList<TItem> ToCovariantList()
        {
            var count = _source.Count;
            var items = _source._items;

            var result = new CovariantList<TItem>(count);

            for (int i = 0; i < count; i++)
            {
                var item = items[i];

                if (_predicate.Invoke(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
