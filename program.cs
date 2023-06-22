using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, n = 30;
            Console.Write(n1 + " " + n2 + " ");   
            for (i = 2; i <= n; ++i) 
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
