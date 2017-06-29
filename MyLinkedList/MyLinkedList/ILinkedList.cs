using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    interface ILinkedList<T>
    {
        Node<T> Head { get; set; }
        int Length { get; set; }
        bool IsEmpty { get; set; }
        void Add(T elem);
        void Remove(int index);
    }
}
