using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    class Program
    {
        readonly int r = _getVal();
        Program()
        {
            r = 3;
        }
        public static int _getVal()
        {
            return 9;
        }
        static void Main(string[] args)
        {
            int a, A;
            a = 2;
            A = 3;
            int @abstract = 1;
            int group = 3;
            string _val = "";
            if(a==A && _val.IsNormalized() && group == 1)
            {

            }

            dynamic s = "str";
            //if(s==1)
            //{

            //}

            const int c = 2;// _getVal();

            //c = 34;
            Program p = new Program();
            int v1 = 10, v2 = 20;
            p.Swap(ref v1,ref v2);
            int z1=9, z2;
            p.GetVal(out z1,out z2);
            int[] arr = { 1, 2, 3, 4, 5 };
            p.ParamsAdd(arr);
            ////int[,] mdArr=new int
            ///
            Ex st = new Ex(1);
            st.print();
            //int val = vals.one;
            Console.WriteLine(st.id+st.name);
            Console.WriteLine((int)vals.three);
            Console.WriteLine();
            Console.ReadKey();
        }
        public void Swap(ref int x,ref int y)
        {
            int tmp;
            tmp = x;
            x = y;
            y = tmp;
        }
        public void GetVal(out int a,out int b)
        {
            a = 1;
            b = 2;
        }

        public void ParamsAdd(params int[] arr)
        {
            int sum = 0;
            foreach (var i in arr)
                sum += i;
            Console.WriteLine(sum);
        }
    }

    enum vals {
        one=1,
        two=2,
        three='s'
    }

    struct Ex:IContract
    {
        public Ex(int i)
        {
            this.id = 2;
            this.name = "sd";
        }
        public int id;
        public string name;

        public void print()
        {
            Console.WriteLine("inside struct");
        }
    }

    interface IContract
    {
        void print();
    }
}
