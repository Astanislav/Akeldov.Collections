using System.Collections;
using System.Collections.Generic;

namespace Akeldov.Collections
{
    public struct CovariantListEnumerator<T> : IEnumerator<T>
    {
        private readonly List<T> _items;
        private int _index;

        public CovariantListEnumerator(List<T> items)
        {
            _items = items;
            _index = -1;
        }

        public T Current => _items[_index];
        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _index++;
            return _index < _items.Count;
        }

        public void Reset() => _index = -1;
        public void Dispose() { }
    }
}
