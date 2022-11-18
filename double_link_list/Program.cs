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
                    Console.WriteLine("\nDuplicate roll numbers not allowed);
                        return;
                }
            }

        }
      
    }
}