using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third.p
{
    internal class Program
    {
        public void Division()
        {
            int a, b, c;
            a = 10; b = 5; c = a / b;
            Console.WriteLine("Division=" + c);

        }



        static void Main(string[] args)
        {
            Program p = new Program();
            p.Division();
            Console.ReadLine();
        }
        
    }
}
