using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirinto.Models
{
    public class PriorityNodeQueue<T>
    {
        private List<(T item, float priority)> heap = new List<(T, float)>();
        public HashSet<T> UnorderedList = new HashSet<T>();

        public void Enqueue(T item, float priority)
        {
            UnorderedList.Add(item);
            heap.Add((item, priority));
            int i = heap.Count - 1;
            while (i > 0)
            {
                int parentIndex = (i - 1) / 2;
                if (heap[parentIndex].priority > heap[i].priority)
                {
                    Swap(i, parentIndex);
                    i = parentIndex;
                }
                else
                {
                    break;
                }
            }
        }

        public T Dequeue()
        {
            if (heap.Count == 0)
            {
                throw new InvalidOperationException("PriorityQueue is empty");
            }
            T item = heap[0].item;
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            int i = 0;
            while (i < heap.Count)
            {
                int leftChildIndex = i * 2 + 1;
                int rightChildIndex = i * 2 + 2;
                if (leftChildIndex >= heap.Count)
                {
                    break;
                }
                int minChildIndex = leftChildIndex;
                if (rightChildIndex < heap.Count && heap[rightChildIndex].priority < heap[leftChildIndex].priority)
                {
                    minChildIndex = rightChildIndex;
                }
                if (heap[minChildIndex].priority < heap[i].priority)
                {
                    Swap(i, minChildIndex);
                    i = minChildIndex;
                }
                else
                {
                    break;
                }
            }
            return item;
        }

        public bool Contains(T item)
        {
            foreach (var queueItem in heap)
            {
                if (queueItem.item.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }


        public bool IsEmpty()
        {
            if (heap.Count == 0)
                return true;
            return false;
        }

        private void Swap(int i, int j)
        {
            (T item, float priority) temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }
    }
}
