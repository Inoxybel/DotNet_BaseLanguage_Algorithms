using Base_Linguagem.Algorithms.LinearList.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Language_Test
{
    public class LinkedListTests
    {
        SimpleLinkedList linkedList = new SimpleLinkedList();

        [Fact]
        public void GetTotalNodes_With_No_Item()
        {
            Assert.Equal(0, linkedList.getTotalNodes());
        } 
        
        [Fact]
        public void GetTotalNodes_With_One_Item()
        {
            linkedList.AddAtFirstPosition(10);
            Assert.Equal(1, linkedList.getTotalNodes());
        }
        
        [Fact]
        public void GetTotalNodes_With_Two_Items()
        {
            linkedList.AddAtFirstPosition(10);
            linkedList.AddAtLastPosition(20);
            Assert.Equal(2, linkedList.getTotalNodes());
        } 
        
        [Fact]
        public void GetTotalNodes_With_Three_Items()
        {
            linkedList.AddAtFirstPosition(20);
            linkedList.AddAtFirstPosition(10);
            linkedList.AddAtLastPosition(30);
            Assert.Equal(3, linkedList.getTotalNodes());
        }

        [Fact]
        public void GetIndexOf_First_Item()
        {
            linkedList.AddAtFirstPosition(10);
            linkedList.AddAtLastPosition(20);
            Assert.Equal(0, linkedList.getIndexOf(10));
        }

        [Fact]
        public void GetIndexOf_Last_Item()
        {
            linkedList.AddAtFirstPosition(10);
            linkedList.AddAtLastPosition(20);
            Assert.Equal(1, linkedList.getIndexOf(20));
        }

        [Fact]
        public void GetDataByIndex_First_Item()
        {
            linkedList.AddAtFirstPosition(10);
            linkedList.AddAtLastPosition(20);
            Assert.Equal(10, linkedList.getDataByIndex(0));
        }

        [Fact]
        public void GetDataByIndex_Last_Item()
        {
            linkedList.AddAtFirstPosition(10);
            linkedList.AddAtLastPosition(20);
            Assert.Equal(20, linkedList.getDataByIndex(1));
        }

        [Fact]
        public void AddByIndex_At_FirstPosition()
        {
            linkedList.AddAtFirstPosition(20);
            linkedList.AddAtFirstPosition(10);
            linkedList.AddAtLastPosition(30);
            Assert.Equal(0, linkedList.addByIndex(0, 15));
            Assert.Equal(15, linkedList.getDataByIndex(0));
            Assert.Equal(10, linkedList.getDataByIndex(1));
        }

        [Fact]
        public void AddByIndex_At_LastPosition()
        {
            linkedList.AddAtFirstPosition(20);
            linkedList.AddAtFirstPosition(10);
            linkedList.AddAtLastPosition(30);
            Assert.Equal(0, linkedList.addByIndex(2, 15));
            Assert.Equal(15, linkedList.getDataByIndex(2));
            Assert.Equal(30, linkedList.getDataByIndex(3));
        }

        [Fact]
        public void AddByIndex_At_MidPosition()
        {
            linkedList.AddAtFirstPosition(20);
            linkedList.AddAtFirstPosition(10);
            linkedList.AddAtLastPosition(30);
            Assert.Equal(0, linkedList.addByIndex(1, 15));
            Assert.Equal(15, linkedList.getDataByIndex(1));
            Assert.Equal(10, linkedList.getDataByIndex(0));
            Assert.Equal(20, linkedList.getDataByIndex(2));
        }

        [Fact]
        public void RemoveByIndex_First_Item()
        {
            linkedList.AddAtFirstPosition(10);
            linkedList.AddAtLastPosition(20);
            Assert.Equal(0, linkedList.removeByIndex(0));
            Assert.Equal(1, linkedList.getTotalNodes());
            Assert.Equal(20, linkedList.getDataByIndex(0));            
        }

        [Fact]
        public void RemoveByIndex_Last_Item()
        {
            linkedList.AddAtFirstPosition(10);
            linkedList.AddAtLastPosition(20);
            Assert.Equal(0, linkedList.removeByIndex(1));
            Assert.Equal(1, linkedList.getTotalNodes());
            Assert.Equal(10, linkedList.getDataByIndex(0));
        }


    }
}
