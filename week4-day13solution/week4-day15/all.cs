using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_day15
{
    class all<T>
    {
        private T[] _item;


        public void add(T item) { }
        public void remove(int index) { }
        public void isEmpty() { }
        public void Count() { }
        public void display() { }


        public void add(T item)
        {
            if (_item is null)
            {
                _items = new T[] { item };
            }
            else
            {
                int length = _item.Length;
                T[] Temp = new T[length+1];
                for (int i = 0; i < length; i++)
                {
                    Temp[i] = _items[i];

                }
                Temp[Temp.Length-1] = item;
                _items = Temp;
            }
        }

        public void Removeat(int index)
        {
            if(index <0 || index > _item.Length)
            {
                return;
            }
            int pos = 0;
            T[] TEMP = new T[pos-1];
            for (int i = 0;i < _item.Length; i++)
            {
                if(index == i)
                {
                    continue;
                }
                TEMP[pos++] = _item[i];
            }
        }

        public bool isEmpty => _item is null || _item.Length == 0;
        public int Count => _item.Length;
        public void display()
        {
            Console.WriteLine("[");

        }
    }
}
