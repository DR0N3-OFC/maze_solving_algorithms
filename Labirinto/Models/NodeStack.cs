using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirinto.Models
{
    public class NodeStack<T>
    {
        T[] items = new T[0];
        private int size;

        public int Size { get => size; set => size = value; }

        public void Push(T value)
        {
            if (Size == items.Count())
            {
                int newlength = Size == 0 ? 4 : Size * 2;
                T[] newarray = new T[newlength];
                items.CopyTo(newarray, 0);
                items = newarray;
            }
            items[Size] = value;
            Size++;
        }
        

        public T Pop()
        {
            if (Size == 0)
            {
                throw new InvalidOperationException("Empty");
            }
            Size--;
            return items[Size];
        }


        public T Peek()
        {
            if (Size == 0)
            {
                throw new InvalidOperationException("Empty");
            }
            return items[Size - 1];
        }
    }
}
