using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    interface ILinkedList
    {
        Node Head { get; set; }
        int Length { get; set; }
        bool IsEmpty { get; set; }
        void Add(object elem);
        void Remove(int index);
    }
}
