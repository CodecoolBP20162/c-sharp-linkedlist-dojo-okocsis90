using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class SinglyLinkedList : ILinkedList
    {
        private Node CurrentNode;

        public Node Head { get; set; }
        public int Length { get; set; }
        public bool IsEmpty { get; set; }

        public void Add(object elem)
        {
            if (Length == 0)
            {
                Head = new Node(elem, null);
                CurrentNode = Head;
            }
            else if (Length > 0)
            {
                CurrentNode.NextElement = new Node(elem, null);
                CurrentNode = CurrentNode.NextElement;
            }
            IsEmpty = false;
            Length += 1;
        }


        public void Remove(int index)
        {
            
        }

        public override string ToString()
        {
            Node actualNode = Head;
            string result = "";
            
            for (int i = 0; i < Length; i++)
            {
                result += actualNode.Value.ToString();
                actualNode = actualNode.NextElement;
            }
            return result;
        }
    }
}
