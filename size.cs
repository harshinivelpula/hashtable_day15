﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtable
{
    internal class size<T> where T : IComparable
    {
        T nodedata;
        public Binary<T> lefttree { get; set; }
        public Binary<T> righttree { get; set; }
        bool result = false;
        int leftcount = 0;
        int rightcount = 0;

        public size(T nodedata)
        {
            this.nodedata = nodedata;
            this.nodedata = nodedata;
            this.lefttree = null;
            this.righttree = null;
        }
        public void Insert(T item)
        {
            T currentnodevalue = this.nodedata;
            if ((currentnodevalue.CompareTo(item)) > 0)
            {
                if (this.lefttree == null)
                    this.lefttree = new Binary<T>(item);
                else
                    this.lefttree.Insert(item);
            }
            else
            {
                if (this.righttree == null)
                    this.righttree = new Binary<T>(item);
                else
                    this.righttree.Insert(item);
            }
        }
        public void Display()
        {
            if (this.lefttree != null)
            {
                this.leftcount++;
                this.lefttree.Display();
            }
            Console.WriteLine(this.nodedata.ToString());
            if (this.righttree != null)
            {
                this.rightcount++;
                this.righttree.Display();
            }
        }
        public void Size()
        {
            Console.WriteLine("Size of Binary Serach Tree " + (1 + leftcount + rightcount));
        }
    }
}