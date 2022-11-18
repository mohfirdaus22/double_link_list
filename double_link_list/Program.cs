using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_link_list
{
    class Node

    {
        /*Node class represent the node of doubly linked list
        *it consist of the information part and links to
        *its succeding and preceeding
        *in terms of the next and previouse*/
        public int noMhs;
        public string name;
        //point to the succeding node
        public Node next;
        //point to the preeceding node
        public Node prev;
    }

    class DoubleLinkedList
    {
        Node START;
        //Consttructor
        public void addNode()
        {
            int nim;
            string nm;
            Console.WriteLine("\nEnter The Role Number of student:");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter the nafe of student:");
            nm=Console.ReadLine();
            Node newNode = new Node();
            newNode.noMhs = nim;
            newNode.name = nm;

            //check if the list empty
            if(START == null||nim<= START.noMhs)
            {
                if((START!=null)&&(nim == START.noMhs))
                {
                    Console.WriteLine("\n Duplicade number not allowed");
                    return;
                }
                newNode.next = START;
                if(START != null)
                    START.prev = newNode;
                newNode.next = null;
                START = newNode;
                return;
            }
            // if the node is to be inserted at between two node
              Node previous, current;
            for(current = previous = START;
                current != null && nim>= current.noMhs;
                previous = current,current = current.next)
            {
                if(nim == current.noMhs)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                        return;
                }
            }
            /* On the execution of the above for loop, prev and
            * current will point to those nodes
            * between which the new node is to be inserted*/
            newNode.next = current;
            newNode.prev = previous;

            //if the node is to be inserted at the end of the list
            if (current == null)
            {
                newNode.next = null;
                previous.next = newNode;
                return;
            }
            current.prev = newNode;
            previous.next = newNode;

        }
        public bool Search(int rollNo, ref Node previous, ref Node current)
        {
            previous=current=START;
            while (current != null &&
                rollNo != current.noMhs)
            {
                previous = current;
                current = current.next;
            }
            return (current != null);

        }
        public bool dellNode(int rollNo)
        {
            Node previous, current;
            previous = current = null;
            if (Search(rollNo, ref previous, ref current) == false)
                return false;
            // the begining off data
            if (current.next== null)
            {
                previous.next = null;
                return true;
            }
            // Node between two node in the list
            if(current == START)
            {
                START = START.next;
                if (START != null)
                    START.prev = null;
                return true;
            }
            // if the to be delete is in between the list then the following lines of is exetited
            previous.next = current.next;
            current.next.prev = previous;
            return true;
        }

        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }

        public void ascending()
        {
            if (listEmpty())
                Console.WriteLine("\nList is Empty");
            else
            {
                Console.WriteLine("\n Record in the asscending order of" + "Roll number are: \n");
                Node currentNode;
                for (currentNode = START; currentNode != null; currentNode = currentNode.next)
                    Console.Write(currentNode.noMhs + currentNode.name + "\n");
            }
        }

        public void descending()
        {
            if (listEmpty())
                Console.WriteLine("\n List is Empty ");
            else
            {
                Console.WriteLine("\n Record in the descending order of" + "roll number are :\n");
                Node currentNode;
                //membawa current node epaling belakang 
                currentNode = START;
                while(currentNode != null)
                {
                    currentNode = currentNode.next;
                }

                //membaca data dari last node ke first node
                while (currentNode != null)
                {
                    Console.Write(currentNode.noMhs + " " + currentNode.name + "\n");
                    currentNode = currentNode.prev;
                }
            }
        }


    }
}