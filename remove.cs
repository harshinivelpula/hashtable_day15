using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtable
{
    public class remove
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table And Binary Search Tree");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(20);
            Console.WriteLine(hash.IsEmpty());
            hash.Add("0", "paranoids");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "they");
            hash.Add("10", "keep");
            hash.Add("11", "putting");
            hash.Add("12", "themselves");
            hash.Add("13", "deliberately");
            hash.Add("14", "into");
            hash.Add("15", "paranoid");
            hash.Add("16", "avoidable");
            hash.Add("17", "situations");
            Console.WriteLine(hash.GetV("5").GetHashCode());
            Console.WriteLine(hash.GetV("0").GetHashCode());
            Console.WriteLine($"size is: {hash.Getsize()}");
            hash.Remove("16");
            Console.WriteLine($"size is: {hash.Getsize()}");
            Console.ReadLine();
        }
    }
}
