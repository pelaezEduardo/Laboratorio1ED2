﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab02EDII.Models;

namespace Lab02EDII.BTree
{
    public class keyComparer : IComparer
    {
        public delegate int compare(object aux, object aux2);
        compare compareElements;
        public void compareElementsDelegate(compare cmp)
        {
            compareElements = cmp;
        }
        // Call CaseInsensitiveComparer.Compare with the parameters reversed.
        public int Compare(object x, object y)
        {
            return compareElements(x, y);
        }
    }
    public class Node<T>
    {
        private keyComparer keyComparer = new keyComparer();
        public T[] Data { get; set; }
        public Node<T>[] Children { get; set; }
        public Node<T> Father { get; set; }

        public Node(int order)
        {
            Data = new T[order - 1];
            Children = new Node<T>[order];            
        }

        public Node(int order, Node<T> nodeFather)
        {
            Data = new T[order];
            Children = new Node<T>[order];
            Father = nodeFather;
        }

        internal bool IsLeaf => Children[0] == null;

        internal bool Full => Data[Data.Length - 1] != null;

        //internal int AproxPosition(T data)
        //{
        //    int position = Data.Length;
        //    for (int i = 0; i < Data.Length; i++)
        //    {
        //        if ((keyComparer.Compare(Data[i], data) < 0) || (Data[i] == null))
        //        {
        //            position = i;
        //        }
        //    }
        //    return position;
        //}

        internal void InsertData(T data)
        {
            if (!Full)
            {
                for (int i = 0; i < Data.Length; i++)
                {
                    if (Data[i] == null)
                    {
                        Data[i] = data;
                        i = Data.Length;
                    }                    
                }                
            }
            else
            {
                SplitNode();
            }
        }
        
        internal void DeleteData(T data)
        {

        }
        
        private void SplitNode()
        {
            
        }
    }
}