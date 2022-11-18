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

}