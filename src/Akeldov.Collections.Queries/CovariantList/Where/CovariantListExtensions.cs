using System;

namespace Akeldov.Collections.Queries
{
    public static partial class ICovariantListExtensions
    {
        public static CovariantListWhereClause<T, TPredicate> Where<T, TPredicate>(this CovariantList<T> list, TPredicate predicate)
            where TPredicate : struct, IPredicate<T>, IFunc<T, bool>
        {
            return new CovariantListWhereClause<T, TPredicate>(list, predicate);
        }

        public static CovariantListWhereClause<T, LambdaPredicate<T>> Where<T>(this CovariantList<T> list, Func<T, bool> predicate)
        {
            var functor = new LambdaPredicate<T>(predicate);
            return new CovariantListWhereClause<T, LambdaPredicate<T>>(list, functor);
        }

        public static CovariantListWhereClause<T, AndPredicate<T, TPrev, TNew>> Where<T, TPrev, TNew>(
            this CovariantListWhereClause<T, TPrev> list,
            TNew predicate)
            where TPrev : struct, IPredicate<T>
            where TNew : struct, IPredicate<T>
        {
            return new CovariantListWhereClause<T, AndPredicate<T, TPrev, TNew>>(
                list._source,
                new AndPredicate<T, TPrev, TNew>(list._predicate, predicate)
            );
        }
    }
}
