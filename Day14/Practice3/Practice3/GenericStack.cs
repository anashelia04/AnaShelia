using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class GenericStack<T>
    {
        private List<T> _items = new List<T>();

        public void Push(T item)
        {
            _items.Add(item);
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                return default(T);
            }

            T item = _items[^1];
            _items.RemoveAt(_items.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                return default(T);
            }
            return _items[^1];
        }

        public bool IsEmpty()
        {
            return _items.Count == 0;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            Console.WriteLine("Stack contents:");
            Console.WriteLine();
            for (int i = _items.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(_items[i]);

            }
            Console.WriteLine();
        }
    }
}
