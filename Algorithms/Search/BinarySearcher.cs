using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search
{
    public class BinarySearcher<T> : IEnumerator<T>
    {
        private readonly IList<T> _collection;
        private readonly Comparer<T> _comparer;
        private T _item;
        private int _currentItemIndex;
        private int _leftIndex;
        private int _rightIndex;
        public T Current
        {
            get
            {
                return _collection[_currentItemIndex];
            }
        }
        object IEnumerator.Current => Current;
        public BinarySearcher(IList<T> collection, Comparer<T> comparer)
        {
            if (collection == null)
            {
                throw new NullReferenceException();
            }
            _collection = collection;
            _comparer = comparer;
            _collection = (from c in _collection orderby c select c).ToList();
        }
        public int BinarySearch(T item)
        {
            bool notFound = true;
            if (item == null)
            {
                throw new NullReferenceException("Item to search for is not set");
            }
            Reset();
            _item = item;
            while ((_leftIndex <= _rightIndex) && notFound)
            {
                notFound = MoveNext();
            }
            if (notFound)
            {
                Reset();
            }
            return _currentItemIndex;
        }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            _currentItemIndex = this._leftIndex + (this._rightIndex - this._leftIndex) / 2;
            if (_comparer.Compare(_item, Current) < 0)
            {
                _rightIndex = _currentItemIndex - 1;
            }
            else if (_comparer.Compare(_item, Current) > 0)
            {
                _leftIndex = _currentItemIndex + 1;
            }
            else
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            this._currentItemIndex = -1;
            _leftIndex = 0;
            _rightIndex = _collection.Count - 1;
        }
    }
}
