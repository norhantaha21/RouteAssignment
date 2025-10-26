using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Adv01
{
    #region Question04
    internal class FixedSizeList<T>
    {

        private T[] items;
        private int count;
        public int capacity { get; }

        public FixedSizeList(int size)
        {
            capacity = size;
            items = new T[size];
            count = 0;
        }

        public void Add(T item)
        {
            if (count >= capacity)
            {
                throw new InvalidOperationException("List is full ! cannt add more elements ");
            }
            items[count++] = item;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
            return items[index];
        }

        public int Count => count; //read only
    } 
    #endregion
}
