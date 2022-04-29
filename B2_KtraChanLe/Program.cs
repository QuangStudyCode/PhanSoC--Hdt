using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2_KtraChanLe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a: ");

            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("So chan!");
            }
            else
            {
                Console.WriteLine("So le!");
            }
           
        }
    }
}
