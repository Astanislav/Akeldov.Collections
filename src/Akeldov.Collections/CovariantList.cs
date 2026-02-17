using System.Collections;
using System.Collections.Generic;

namespace Akeldov.Collections
{
    public class CovariantList<T> : ICovariantList<T>
    {
        public List<T> _items;

        public CovariantList()
        {
            _items = new List<T>();
        }

        public CovariantList(int capacity)
        {
            _items = new List<T>(capacity);
        }

        public CovariantList(T[] items)
        {
            _items = new List<T>(items);
        }

        public CovariantList(List<T> items)
        {
            _items = items;
        }

        public CovariantList(IEnumerable<T> items)
        {
            _items = new List<T>(items);
        }

        public CovariantList(HashSet<T> items)
        {
            _items = new List<T>(items);
        }

        public int Count => _items.Count;

        public void Add(T item) => _items.Add(item);

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public T this[int index]
        {
            get => _items[index];
            set => _items[index] = value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _items.Count; i++)
                yield return _items[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static implicit operator List<T>(CovariantList<T> covariantList)
        {
            return covariantList._items;
        }

        public static implicit operator CovariantList<T>(List<T> covariantList)
        {
            return new CovariantList<T>(covariantList);
        }

        public static implicit operator CovariantList<T>(T[] covariantList)
        {
            return new CovariantList<T>(covariantList);
        }

        public static explicit operator T[](CovariantList<T> covariantList)
        {
            return covariantList._items.ToArray();
        }
    }
}
