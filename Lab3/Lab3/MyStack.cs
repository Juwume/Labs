using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class MyStackItem<T>
    {
        public T data { get; set; }
        public MyStackItem<T> next { get; set; }

        public MyStackItem(T param)
        {
            this.data = param;
        }
    }

    class MyStack<T>
    {
       
        public bool Is_empty()
        {
            if (count == 0)
                return true;
            else
                return false;
        }
        public void Push(T element)
        {
            var new_top = new MyStackItem<T>(element);
            new_top.next = top;
            top = new_top;
            count++;
        }
        public void Pop()
        {
            this.top = this.top.next;
            count--;
        }
        public int Count() {
            return this.count;
        }
        public T Peek()
        {
            return this.top.data;
        }
        private MyStackItem<T> top;
        private int count;
    }
}
