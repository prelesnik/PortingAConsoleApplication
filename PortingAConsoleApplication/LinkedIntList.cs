// Mike Prelesnik
// Porting a Java Assignment to C#
// Assignment 2

using System;
using System.Collections.Generic;
using System.Text;

namespace PortingAConsoleApplication
{
    class LinkedIntList
    {
        //fields
        private Node front;
        private int size;

        //constructor
        public LinkedIntList()
        {
            this.front = null;
            this.size = 0;
        }

        //contains method
        public Boolean contains(int target)
        {
            Node current = front;
            while (current != null)
            {
                if (current.data == target)
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        //add method
        public void add(int data)
        {
            if (front == null)
            {
                front = new Node(data, front, null);
            }
            else
            {
                Node current = front;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node(data, null, current);
            }
            size++;
        }

        //size method
        public int getSize()
        {
            return size;
        }

        //get method
        public int get(int index)
        {
            if (isEmpty())
            {
                throw new Exception("List is empty!");
            }

            if (index < 0 || index >= size)
            {
                throw new Exception("Index must be in range of 0 to " + (size - 1));
            }

            Node current = front;
            for (int i = 0; i < index; i++)
            {
                current = current.next;
            }
            return current.data;
        }
        
        //isEmpty method
        public Boolean isEmpty()
        {
            return size == 0;
        }

        //removes from the end of a list
        public int removeLast()
        {
            if (front == null)
            {
                throw new Exception("List is empty!");
            }

            Node current = front;

            while (current.next != null)
            {
                current = current.next;
            }

            int result = current.next.data;
            current.next = null;

            return result;
        }

        //remove by index
        public int remove(int index)
        {
            if (isEmpty())
            {
                throw new Exception("List is empty!");
            }

            //validate index
            if (index < 0 || index >= size)
            {
                throw new Exception("Index must be in range of 0 to " + (size - 1));
            }

            Node current = front;

            for (int i = 0; i < index - 1; i++)
            {
                current = current.next;
            }
            //save data of the next
            int result = current.next.data;

            //reset the next pointer 
            current.next = current.next.next;

            return result;
        }

        //toString
        public String toString()
        {
            String output = "";
            Node current = front;

            if (current == null)
            {
                output = "Linked List is currently empty";
                return output;
            }
            else
            {
                output += current.data; //post in ground for fence-post problem
                current = current.next;
            }

            while (current != null)
            {
                output += " => " + current.data;
                current = current.next;
            }
            return output;
        }

        private class Node
        {
            //fields
            internal int data;
            internal Node next;
            internal Node prev;

            //constructor
            public Node(int data, Node next, Node prev)
            {
                this.data = data;
                this.next = next;
                this.prev = prev;
            }
        } //end of inner class

    }//end of outer class
}//end of program