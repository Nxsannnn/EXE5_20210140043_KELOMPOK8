using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Queue
    {
        public Node ichsan;
        public Node munawwar;

        public Queue()
        {
            this.ichsan = this.munawwar = null;
        }
        public void insert(int ell)
        {
            Node temp= new Node(ell);

            if (this.munawwar == null)
            {
                this.ichsan = this.munawwar = temp;
            }
            else
            {
                this.munawwar.next = temp;
                this.munawwar = temp; 
            }
            Console.WriteLine("Inserted", ell);
        }
        public void delete()
        {
            if (this.ichsan == null)
                return;
            {
                Console.WriteLine("Queue Empty");
                return;
            }
            Node temp = this.ichsan;
            this.ichsan = this.ichsan.next;

            if(this.ichsan == null)
            {
                this.munawwar = null;
            }
            Console.WriteLine("Item Deleted");
        }
        static void Main(string[] args)
        {
            Queue q = new Queue();
            char ch;
            while (true) 
            {
                try
                {
                    Console.WriteLine("menu");
                    Console.WriteLine("1. implement insert operation ");
                    Console.WriteLine("2. implement delete operation");
                    Console.WriteLine("3. Exit");
                    Console.WriteLine("\nEnter your choise");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            Console.WriteLine("Enter a name;");
                            string num = Convert.ToString(Console.ReadLine());
                            q.insert(num);
                            break;
                    }
                }
            }
        }
    }
}
