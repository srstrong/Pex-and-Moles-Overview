using System;
using System.Diagnostics.Contracts;

namespace Array
{
    public class ResizableArray<T>
    {
        private T[] _array;
        private int _position;
        private int _capacity;

        public ResizableArray(int capacity)
        {
            _array = new T[capacity];
            _position = 0;
            _capacity = capacity;
        }

        public int Length
        {
            get { return _position; }
        }

        public void Add(T item)
        {
            if (_position == _capacity)
            {
                Resize();
            }

            _array[_position++] = item;
        }

        public T this[int index]
        {
            get { return _array[index]; }
        }

        void Resize()
        {
            #region Fix
            /*
            if (_capacity == 0)
            {
                _array = new T[1];
                _capacity = 1;
                return;
            }
            */
            #endregion

            var temp = new T[_capacity * 2];
            System.Array.Copy(_array, temp, _capacity);
            _capacity = _capacity + 1;
            _array = temp;
        }

        #region Contracts
        /*
        [ContractInvariantMethod]
        void Invariant()
        {
            Contract.Invariant(_capacity == _array.Length);
        }
        */ 
        #endregion
    }
}
