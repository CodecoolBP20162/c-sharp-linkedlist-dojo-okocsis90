using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class SinglyLinkedList<T> : ILinkedList<T>
    {
        public Node<T> Head { get; set; }
        public int Length { get; set; }
        public bool IsEmpty { get; set; }

        private Node<T> CurrentNode;

        public void Add(T elem)
        {
            if (Length == 0)
            {
                Head = new Node<T>(elem, null);
                CurrentNode = Head;
            }
            else if (Length > 0)
            {
                CurrentNode.NextElement = new Node<T>(elem, null);
                CurrentNode = CurrentNode.NextElement;
            }
            IsEmpty = false;
            Length += 1;
        }

        public void Remove(int index)
        {
            if (index == 0)
            {
                Head = Head.NextElement;
                Length -= 1;
            }
            else if (index < Length)
            {
                Node<T> actualNode = Head;
                for (int i = 0; i < Length; i++)
                {
                    if (i == index - 1)
                    {
                        if (actualNode.NextElement.NextElement == null)
                        {
                            actualNode.NextElement = null;
                            Length -= 1;
                            return;
                        }
                        else
                        {
                            actualNode.NextElement = actualNode.NextElement.NextElement;
                            Length -= 1;
                            return;
                        }
                    }
                    actualNode = actualNode.NextElement;
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index out of Range.");
            }
        }

        public override string ToString()
        {
            Node<T> actualNode = Head;
            string result = "";
            
            for (int i = 0; i < Length; i++)
            {
                result += " " + actualNode.Value;
                if (actualNode.NextElement != null)
                {
                    actualNode = actualNode.NextElement;
                }
            }
            return result;
        }
    }
}
