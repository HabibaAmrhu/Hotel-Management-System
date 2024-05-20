using System;
using System.Collections.Generic;


namespace HotelManagement1
{
    internal class Queue<T>
    {
        private int front;
        private int back;
        private T[] arr;
        private int size;
        public Queue(int size)
        {
            front = 0;
            back = -1;
            arr = new T[size];
        }
        public void Enqueue(T item)
        {
            back++;
            arr[back] =item;
            size++;
        }
        public T Dequeue()
        {
            if (front > back)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            else
            {
                T item = arr[front];
                front++;
                return item;
            }
        }
        public T Peek()
        {
            if (front>back)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            else
            {
                return arr[front];
            }
        }
        public bool IsEmpty()
        {
            return back < front;
        }
        public void GetAllItems()
        {
            Console.WriteLine("items of queue areL ");
            for (int i = front; i <= back; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}