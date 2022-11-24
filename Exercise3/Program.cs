using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Node
    {
        /*create Nodes for the circular nexted list*/
        public int rollNumber;
        public string name;
        public Node next;
    }
    class CircularList
    {
        Node LAST;

        public CircularList()
        {
            LAST = null;
        }
        //Menambahkan method insert
        public void insert()
        {
            int nim;
            string nm;
            Console.WriteLine("\nMasukkan nomer Mahasiswa: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nMasukkan nama Mahasiswa: ");
            nm = Console.ReadLine();

            Node nodebaru = new Node();
            nodebaru.rollNumber = nim;
            nodebaru.name = nm;

            //Node ditambahkan sebagai node pertama
            if (LAST == null || nim != LAST.rollNumber)
            {
                if ((LAST != null || nim == LAST.rollNumber))
                {
                    Console.WriteLine("\nNomer mahasiswa sama tidak diizinkan ");
                }
                nodebaru.next = LAST;
                LAST = nodebaru;
                return;
            }
            //Method untuk menghapus variabel tertentu didalam list
            public bool delete(int rollNo)
            {
                Node previous, current;
                previous = current = null;
                //check apakah node yang dimaksud ada di dalam list atau tidak
                if (Search(nim, ref previous, ref current) == false)
                    return false;
                previous.next = current.next;
                if (current == LAST)

                    LAST = LAST.next;
                return true;

            }

            public bool Search(int rollNo, ref Node previous, ref Node current)
            /*searches for the specified node*/
            {
                for (previous = current = LAST.next; current != LAST; previous =
                    current, current = current.next)
                {
                    if (rollNo == current.rollNumber)
                        return (true);/*return true if the node is founds*/
                }
                public bool listEmpty()
                {
                    if (LAST == null)
                        return true;
                    else
                        return false;
                }

                public void traverse()/*Traverse all the nodes of the list*/
                {
                    if (listEmpty())
                        Console.WriteLine("\nList is empty");
                    else
                    {
                        Console.WriteLine("\nRecord in the list are:\n");
                        Node currentNode;
                        currentNode = LAST.next;
                        while (currentNode != LAST)
                        {
                            Console.Write(currentNode.rollNumber + "  " + currentNode.name + "\n");
                            currentNode = currentNode.next;
                        }
                        Console.Write(LAST.rollNumber + "     " + LAST.name + "\n");
                    }
                }
                public void firstNode()
                {
                    if (listEmpty())
                        Console.WriteLine("\nList is Empty");
                    else
                        Console.WriteLine("\nThe first record in the list is:\n\n " +
                            LAST.next.rollNumber + "    " + LAST.next.name);
                }
    class Program
        {
            static void Main(string[] args)
            {
                CircularList obj = new CircularList();
                while (true)
                {
                    try
                    {
                        Console.WriteLine("\nMenu");
                        Console.WriteLine("1. View all the record in the list");
                        Console.WriteLine("2. Search for a record in the list");
                        Console.WriteLine("3. Display the first record in the list");
                        Console.WriteLine("4. Exit");
                        Console.WriteLine("\nEnter your choice (1-4):");
                        char ch = Convert.ToChar(Console.ReadLine());
                        switch (ch)
                        {
                            case '1':
                                {
                                    obj.traverse();
                                }
                                break;
                            case '2':
                                {
                                    if (obj.listEmpty() == true)
                                    {
                                        Console.WriteLine("\nList is empty");
                                        break;
                                    }
                                    Node prev, curr;
                                    prev = curr = null;
                                    Console.Write("\nEnter the roll number of the student whose record is to be searched :");
                                    int num = Convert.ToInt32(Console.ReadLine());
                                    if (obj.Search(num, ref prev, ref curr) == false)
                                        Console.WriteLine("\nRecord found");
                                    else
                                    {
                                        Console.WriteLine("\nRecord found");
                                        Console.WriteLine("\nRoll number: " + curr.rollNumber);
                                        Console.WriteLine("\nName: " + curr.name);

                                    }
                                }
                                break;
                            case '3':
                                {
                                    obj.firstNode();
                                }
                                break; ;
                            case '4':
                                return;
                            default:
                                {
                                    Console.WriteLine("Invalid option");
                                    break;
                                }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }
        }
    }
}

        }


               
