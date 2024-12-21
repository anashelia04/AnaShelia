using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    public class GenericQueue<T>
    {
        private List<T> _items = new List<T>();

        public bool Enqueue(T item)
        { 
            if (item == null)
                return false; 

            _items.Add(item);
            return true;
        }
        public (bool, T) Dequeue()
        {
            if (_items.Count == 0)
                return (false, default); 

            T item = _items[0];
            _items.RemoveAt(0);
            return (true, item);
        }

        public (bool, T) Peek()
        {
            if (_items.Count == 0)
            {
                return (false, default);
            }
                
            return (true, _items[0]);
        }

        
        public bool IsEmpty()
        {
            return _items.Count == 0;
        }
    }

}
