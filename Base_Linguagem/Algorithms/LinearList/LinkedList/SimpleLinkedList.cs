using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Linguagem.Algorithms.LinearList.LinkedList
{
    public class SimpleLinkedList
    {
        private Node head;

        public void AddAtFirstPosition(int data)
        {
            Node newFirst = new Node();

            newFirst.data = data;
            newFirst.next = head;

            head = newFirst;
        }

        public void AddAtLastPosition(int data)
        {
            if (head is not null)
            {
                Node newLast = new Node();
                newLast.data = data;

                Node currentHead = head;

                while (currentHead.next is not null)
                    currentHead = currentHead.next;

                currentHead.next = newLast;
            }
        }

        public int getTotalNodes()
        {
            int count = 0;
            Node currentHead = head;

            while (currentHead is not null)
            {
                currentHead = currentHead.next;
                count++;
            }

            return count;
        }

        public int getIndexOf(int data)
        {
            int index = 0;
            int totalNodes = getTotalNodes();
            Node currentHead = head;

            while (index < totalNodes)
            {
                if (currentHead.data == data)
                    return index;

                index++;
                currentHead = currentHead.next;
            }

            return -1;
        }

        public int getDataByIndex(int index)
        {
            int totalNodes = getTotalNodes();

            if (index < 0 || index >= totalNodes)
                return -1;

            int count = 0;
            Node currentHead = head;

            while (count != index)
            {
                currentHead = currentHead.next;
                count++;
            }

            return currentHead.data;
        }

        //for practice
        public Node getNodeByIndex(int index)
        {
            int totalNodes = getTotalNodes();

            if (index < 0 || index >= totalNodes)
                return null;

            int count = 0;
            Node currentHead = head;

            while (count != index)
            {
                currentHead = currentHead.next;
                count++;
            }

            return currentHead;
        }


        public int addByIndex(int index, int value)
        {
            int totalNodes = getTotalNodes();

            if (index < 0 || index >= totalNodes)
                return -1;
            else if (index == 0)
            {
                AddAtFirstPosition(value);
                return 0;
            }
            else if (index == totalNodes-1)
            {
                Node newLast = getNodeByIndex(index);
                Node beforeLast = getNodeByIndex(index-1);

                Node newNode = new Node();
                newNode.data = value;
                newNode.next = newLast;
                beforeLast.next = newNode;

                return 0;
            }

            Node currentNode = getNodeByIndex(index);
            Node beforeHead = getNodeByIndex(index - 1);
            Node newHead = new Node();
            newHead.data = value;
            newHead.next = currentNode;
            beforeHead.next = newHead;

            return 0;

        }

        public int removeByIndex(int index)
        {
            int totalNodes = getTotalNodes();
            if (index < 0 || index >= totalNodes)
                return -1;
            else if (index == 0)
            {
                head = getNodeByIndex(1);
                return 0;
            }
            else if (index == totalNodes - 1)
            {
                Node beforeLast = getNodeByIndex(index - 1);
                beforeLast.next = null;
                return 0;
            }

            Node AfterNode = getNodeByIndex(index + 1);
            Node beforeHead = getNodeByIndex(index - 1);

            beforeHead.next = AfterNode;

            return 0;

        }

        public void showAllNodes()
        {
            Node currentHead = head;

            while (currentHead is not null)
            {
                Console.WriteLine(currentHead.data);

                if(currentHead.next is not null)
                    currentHead = currentHead.next;
            }
        }

    }
}
