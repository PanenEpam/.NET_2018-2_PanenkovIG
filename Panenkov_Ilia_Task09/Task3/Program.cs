using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
			int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            LinkedList<int> list2 = new LinkedList<int>(arr);

            Console.WriteLine(RemoveEachSecondItem(list1));

			Console.WriteLine(RemoveEachSecondItem(list2));
        }

        public static T RemoveEachSecondItem<T>(IEnumerable<T> ie)
        {
            var elementsCount = ie.Count();
            if (elementsCount == 0)
                throw new Exception("Empty ie");

            var firstNode = CreateCircularList(ie);
            var isOdd = false;
            var currentNode = firstNode;
            MyNode<T> previousNode = null;
            while (elementsCount > 1)
            {
                if (isOdd)
                {
                    previousNode.next = currentNode.next;
                    elementsCount--;
                }
                else
                {
                    previousNode = currentNode;
                }
                currentNode = currentNode.next;
                isOdd = !isOdd;
            }
            return currentNode.item;
        }


        static MyNode<T> CreateCircularList<T>(IEnumerable<T> ie)
        {
            MyNode<T> firstNode = null;
            MyNode<T> previousNode = null;
            foreach (var item in ie)
            {
                var newNode = new MyNode<T>(item);
                if (firstNode == null)
                {
                    firstNode = newNode;
                }
                else
                {
                    previousNode.next = newNode;
                }
                previousNode = newNode;
            }
            previousNode.next = firstNode;
            return firstNode;
        }

    }

    class MyNode<T>
    {
        public readonly T item;
        public MyNode<T> next;

        public MyNode(T item)
        {
            this.item = item;
        }
    }   
}

