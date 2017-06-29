using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList.Tests
{
    [TestClass()]
    public class SinglyLinkedListTests
    {
        [TestMethod()]
        public void AddTest_AddOneElement_HeadIsOne()
        {
            SinglyLinkedList<string> strList = new SinglyLinkedList<string>();
            strList.Add("One");
            Assert.AreEqual("One", strList.Head.Value);
        }

        [TestMethod()]
        public void AddTest_AddTwoElements_PrintsAllElements()
        {
            SinglyLinkedList<string> strList = new SinglyLinkedList<string>();
            strList.Add("One");
            strList.Add("Two");
            Assert.AreEqual(" One Two", strList.ToString());
        }

        [TestMethod()]
        public void RemoveTest_RemoveLastElement_LastElementRemoved()
        {
            SinglyLinkedList<string> strList = new SinglyLinkedList<string>();
            strList.Add("One");
            strList.Add("Two");
            strList.Add("Three");
            strList.Add("Four");

            strList.Remove(3);
            Assert.AreEqual(" One Two Three", strList.ToString());
        }

        [TestMethod()]
        public void RemoveTest_RemoveFirstElement_FirstElementRemoved()
        {
            SinglyLinkedList<string> strList = new SinglyLinkedList<string>();
            strList.Add("One");
            strList.Add("Two");
            strList.Add("Three");
            strList.Add("Four");

            strList.Remove(0);
            Assert.AreEqual(" Two Three Four", strList.ToString());
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Index out of Range.")]
        public void RemoveTest_HigherIndexRemoved_ThrowsException()
        {
            SinglyLinkedList<string> strList = new SinglyLinkedList<string>();
            strList.Add("One");
            strList.Add("Two");
            strList.Add("Three");
            strList.Add("Four");

            strList.Remove(10);
        }
    }
}