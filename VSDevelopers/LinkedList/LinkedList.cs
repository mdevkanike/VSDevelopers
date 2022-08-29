using System;
using System.Collections.Generic;
using System.Text;

namespace VSDevelopers.LinkedList
{
    public class LinkedList<T>
    {
        public Node<T> First;
        public LinkedList(T[] words)
        {
            Node<T> temp=First;
            foreach (T d in words)
            {
                if (First == null)
                {
                    First = new Node<T>(d);
                    temp = First;
                }
                else
                {
                    temp.next = new Node<T>(d);
                    temp++;
                }
                
            }

        }
        public void Display()
        {
            Node<T> temp = First;
            Console.WriteLine("The linked list values:");
            while (temp != null)
            {
                System.Console.Write($"{temp.data}->");
                temp++;
            }
            System.Console.Write("NULL");
        }
    }
}
