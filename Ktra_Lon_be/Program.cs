using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktra_Lon_be
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ba so a,b,c: ");
            Int32 a = Int32.Parse(Console.ReadLine());
            Int32 b = Int32.Parse(Console.ReadLine());
            Int32 c = Int32.Parse(Console.ReadLine());

            if (a > b)
            {
                if(a > c)
                {
                    Console.WriteLine("A la so lon nhat!");
                }
                else
                {
                    Console.WriteLine("C la so lon nhat! ");
                }
            }else if (b > c)
            {
                Console.WriteLine("B la so lon nhat! ");

            }
            else
            {
                Console.WriteLine("So thu 3 la so lon nhat!");
            }
 
        }
    }
}
