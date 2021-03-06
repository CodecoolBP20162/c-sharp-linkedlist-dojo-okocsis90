﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> NextElement { get; set; }

        public Node(T value, Node<T> nextElement)
        {
            Value = value;
            NextElement = nextElement;
        }
    }
}
