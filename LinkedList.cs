using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList<T>
        where T : IComparable
    {
        private Node<T> first;
        private Node<T> last;
        private int Length;
        public int lenght { get { return Length; } }
        public T GetT(int index)
        {
            if (Length < index)
            {
                return default(T);
            }
            else
            {
                int i = 0;
                Node<T> curr = first;
                while (i != index && curr != null)
                {
                    curr = curr.Next;
                    i++;
                }
                return curr.data;
            }
        }
        public bool SetT(int index, T data)
        {
            if (Length < index)
            {
                return false;
            }
            else
            {
                int i = 0;
                Node<T> curr = first;
                while (i != index && curr != null)
                {
                    curr = curr.Next;
                    i++;
                }
                curr.data = data;
                return true;
            }
        }
        public LinkedList() { Length = 0; }
        public LinkedList(T t)
        {
            Length = 0;
            Add(t);
        }
        public LinkedList(T[] t)
        {
            Length = 0;
            Add(t);
        }
        public void Add(T t)
        {
            if (first == null)
            {
                first = new Node<T> { data = t, Next = last };
            }
            else if (last == null)
            {
                Node<T> temp = new Node<T> { data = t };
                last = temp;
                first.Next = last;
            }
            else
            {
                Node<T> temp = new Node<T> { data = t };
                last.Next = temp;
                last = temp;
            }
            Length++;
        }
        public void Add(T[] t)
        {
            foreach (var item in t)
            {
                Add(item);
            }
        }
        public void AddFirst(T t)
        {
            Node<T> temp = new Node<T> { data = t, Next = first };
            first = temp;
        }
        public void AddFirst(T[] t)
        {

            for (int i = t.Length - 1; i >= 0; i--)
            {
                AddFirst(t[i]);
            }
        }
        public void Print()
        {
            Console.WriteLine(ToString());
            
        }
        public override string ToString()
        {
            string rez = "";
            Node<T> curr = first;
            rez += curr.data.ToString();
            curr = curr.Next;
            while (curr != null)
            {
                rez += ", ";
                rez += curr.data.ToString();
                curr = curr.Next;
            }
            return rez;
        }
        public void Delete(int index = 0)
        {
            if ((index >= 0) && (index < Length))
            {
                if (index == 0)
                {
                    first = first.Next;
                }
                else
                {
                    Node<T> prev = first;
                    for (int i = 0; i < index - 1; i++)
                    {
                        prev = prev.Next;
                    }
                    if (index == Length - 1)
                    {
                        prev.Next = null;
                        last = prev;
                    }
                    else
                    {
                        Node<T> next = prev.Next;
                        prev.Next = next.Next;
                    }

                }

            }
        }
    }
}
