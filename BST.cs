using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtable
{
    internal class BST
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table And Binary Search Tree");
            Binary<int> bst = new Binary<int>(56);
            bst.Insert(30);
            bst.Insert(70);
            Console.WriteLine("Binary Search Tree ");
            bst.Display();
            Console.ReadLine();
        }
    }
}
