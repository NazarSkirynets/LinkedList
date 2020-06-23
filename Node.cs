using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node<T>
        where T : IComparable
    {
        public T data { get; set; }
        public Node<T> Next { get; set; }
    }
}
