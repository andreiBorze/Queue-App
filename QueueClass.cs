using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_App
{
    public class QueueClass<T>
    {
        private T[] items;
        private int head;
        private int tail;
        private int size;

        public QueueClass(int capacity)
        {
            items = new T[capacity];
            head = 0;
            tail = -1;
            size = 0;
        }

        public void Enqueue(T item)
        {
            if (size == items.Length)
            {
                Console.WriteLine("Queue is full");
            }

            tail = (tail + 1) % items.Length;
            items[tail] = item;
            size++;
        }

        public T Dequeue()
        {
            if(size == 0)
            {
                Console.WriteLine("Queue is empty");
            }

            T dequeueItem = items[head];
            head = (head + 2) % items.Length;
            size--;

            return dequeueItem;
        }

        public int Count
        {
            get { return size; }
        }
    }
}
