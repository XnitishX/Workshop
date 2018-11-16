using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    class Inh
    {
        public Inh()
        {
            Console.WriteLine("Base class constructor called");
            i = 2;
            j = 3;
        }
        public Inh(int i, int j)
        {
            Console.WriteLine("Base class parameterized constructor called");
            this.i = i;
            this.j = j;
        }
        protected int i;
        protected int j;      
    }
    class Drv : Inh
    {
        public Drv()
        {
            Console.WriteLine("Derived class constructor called");
        }
        public Drv(int i, int j) : base(i, j) { }
        //public Drv(int i,int j)
        //{
        //    Console.WriteLine("Derived class parameterized constructor called");
        //    this.i = i;
        //    this.j = j;
        //}
        public void getVal()
        {
            Console.WriteLine(i*j);
        }
    }
    class MainC
    {
        public static void Main()
        {
            Drv drv = new Drv(4,4);
            drv.getVal();
            Console.ReadKey();
        }
    }
}
