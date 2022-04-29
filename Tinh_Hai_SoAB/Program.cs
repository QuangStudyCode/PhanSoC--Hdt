using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_Hai_SoAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Menu===");
            Console.Write("Nhap so a: ");
            int a= int.Parse(Console.ReadLine());

            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap lua chon: ");
            char luachon;

            luachon=Convert.ToChar(Console.ReadLine());
            switch(luachon)
            {
                case '+':
                    Console.WriteLine("Tong hai so a&b la: " + (a + b));
                    break;
                default:
                    Console.WriteLine("Khong hop le!!!");
                    break;
            }    
        }
    }
}
