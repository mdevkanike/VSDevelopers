using System;
using System.Collections.Generic;
using System.Text;

namespace VSDevelopers.LinkedList
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;
        public Node(T d)
        {
            data = d;
            next = null;
        }
        public static Node<T> operator ++(Node<T> a)
        {
            a = a.next;
            return a;
        }
    }
}
