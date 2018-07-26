using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {

       static void Operation(Queue ob)
        {


            char ch = Console.ReadKey().KeyChar;
            switch (ch)
            {

                case 'a':

                    Console.WriteLine("Enter element");
                    int n = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter element");
                    ob.AddElement(n);
                    break;

                case 'r':

                    ob.RemElement();
                    break;


                case 's':

                    ob.Display();
                    break;

            }

        }

        static void Main(string[] args)
        {

            Console.WriteLine("What data structure want to work on\n" + "Press 'l' for linkedlist \n" + "Press 'q' for queue \n" + "Press 's' for stack \n");

         
            Console.WriteLine("What operation you want to  perform");

            Queue queue;
            LinkedList linkList;
            Stack stack;

            char c = Console.ReadKey().KeyChar;
            switch (c)
            {

                case 'q':
                    
                    queue = new Queue();

                    Operation(queue);

                    Console.WriteLine("What operation you want to  perform\n" + "Press 'a' for adding \n" + "Press 'r' for remove \n" + "Press 'd' for display \n");
                    

                    break;

                case 'l':

                    linkList = new LinkedList();
                    Operation(linkList);
                    break;


                case 's':
                    stack = new Stack();
                    Operation(stack);
                    break;

            }


          





        }

    }
    }

