using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Node
    {
        public Node ichsan;
        private Node next;
        public Node munawwar;
        public string ell;
        public Node(int ell)
        {
            this.ichsan = this.munawwar = null;
        }
        public void insert(int ell)
        {
            Node baru = new Node(ell);
            if (this.munawwar == null)
            {
                this.ichsan = this.munawwar = baru;
            }
            else
            {
                this.munawwar.next = baru;
                this.munawwar = baru; 
            }
            Console.WriteLine("Inserted", ell);
        }
        public void delete()
        {
            if(this.ichsan == null)
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
        public void display()
        {

        }
        static void Main(string[] args)
        {
        }
    }
}
