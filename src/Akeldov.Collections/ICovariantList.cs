using System.Collections.Generic;

namespace Akeldov.Collections
{
    public interface ICovariantList<out T> : IEnumerable<T>
    {
        int Count { get; }

        T this[int index] { get; }

        void Shuffle();

        void Reverse();

        ICovariantList<T> Copy();
    }
}
