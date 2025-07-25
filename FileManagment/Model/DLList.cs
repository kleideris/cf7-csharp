﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagment.Model
{
    internal class DLList<T>
    {
        public GenericNode<T>? Head { get; set; } = null;
        public GenericNode<T>? Tail { get; set; } = null;

        public void InsertFirst(T t) {
            GenericNode<T> tmp = new()
            {
                Value = t,
                Count = 1,
                Next = Head,
                Prev = null
            };

            Head = tmp;
            if (IsEmpty())
            {
                Tail = tmp;
            }
        }

        public void InsertLast(T t)
        {
            if (IsEmpty())
            {
                InsertFirst(t);
                return;
            }

            GenericNode<T> tmp = new()
            {
                Value = t,
                Count = 1,
                Next = null,
                Prev = Tail
            };

            if (Tail != null)
            {
                Tail!.Next = tmp;
                Tail = tmp;
            }
            
            
        }

        public void Traverse(int totalChars)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return;
            }

            GenericNode<T>? node = Head;
            while (node != null)
            {
                Console.WriteLine($"Value: {node.Value}, Frequency: {node.Count /(double) totalChars:P2}");
                node = node.Next;
            }
        }

        public GenericNode<T>? GetPosition(T t)
        {
            GenericNode<T> node = Head!;
            while (node != null)
            {
                if (node.Value.Equals(t))
                {
                    return node;
                }
                node = node.Next;
            }
            return null;
        }

        public void IncreaseCount(GenericNode<T> node)
        {
            if (node is null) return;
            node.Count++;
        }

        public void SortByCount()
        {
            for (GenericNode<T> iNode = Head!; iNode.Next is not null; iNode = iNode.Next)
            {
                int minVal = iNode.Count;
                GenericNode<T> minPos = iNode;

                for (GenericNode<T> jNode = iNode.Next; jNode is not null; jNode = jNode.Next!)
                {
                    if (jNode.Count < minVal)
                    {
                        minVal = jNode.Count;
                        minPos = jNode;
                    }
                    Swap(iNode, minPos);
                }

            }
        }

        public void Swap(GenericNode<T> iNode, GenericNode<T> jNode)
        {
            T? tmpVal = iNode.Value;
            int tmpCount = iNode.Count;

            iNode.Value = jNode.Value;
            iNode.Count = jNode.Count;

            jNode.Value = tmpVal;
            jNode.Count = tmpCount;


        }

        public bool IsEmpty()
        {
            return Head == null && Tail == null;
        }




    }
}
