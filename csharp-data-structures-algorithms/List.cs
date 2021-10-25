using System;

namespace csharp_data_structures_algorithms
{
    public class List
    {
        private Element _list;

        public List()
        {
            _list = new Element();
            Count = 0;
        }

        public int Count { get; private set; }

        public void Add(object obj)
        {
            var newElement = new Element(_list, obj);
            _list = newElement;
            Count++;
        }

        public void Remove()
        {
            if (_list.Previous is null)
            {
                // Could also throw an Exception
                Reset();
            }
            else
            {
                _list = _list.Previous;
                Count--;
            }
        }

        public void Reset()
        {
            _list = new Element();
            Count = 0;
        }

        public object Head()
        {
            return _list.Data;
        }

        private class Element
        {
            public Element(Element previous = null, object data = null)
            {
                Previous = previous;
                Data = data;
            }

            public Element Previous { get; }
            public object Data { get; }
        }
    }
}
