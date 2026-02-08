using System.Collections.Generic;

namespace Akeldov.Collections
{
    public interface ICovariantList<out T> : IEnumerable<T>
    {
        int Count { get; }

        T Get(int index);

        void Shuffle();

        void Reverse();

        ICovariantList<T> Copy();
    }
}
