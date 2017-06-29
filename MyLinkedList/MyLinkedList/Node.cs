using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class Node
    {
        public object Value { get; set; }
        public Node NextElement { get; set; }

        public Node(object value, Node nextElement)
        {
            Value = value;
            NextElement = nextElement;
        }
    }
}
