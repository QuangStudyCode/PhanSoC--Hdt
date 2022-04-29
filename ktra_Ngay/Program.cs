using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktra_Ngay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so trong khoang (1-7): ");

            int ngay = int.Parse(Console.ReadLine());


            switch (ngay)
            {
                case 1:
                    Console.WriteLine("Ngay thu hai!");
                    break;
                case 2:
                    Console.WriteLine("Ngay thu ba!");
                    break;
                case 3:
                    Console.WriteLine("Ngay thu tu!");
                    break;
                case 4:
                    Console.WriteLine("Ngay thu nam!");
                    break;
                case 5:
                    Console.WriteLine("Ngay thu sau!");
                    break;
                case 6:
                    Console.WriteLine("Ngay thu bay!");
                    break;
                case 7:
                    Console.WriteLine("Ngay chu nhat!");
                    break;
                default:
                    Console.WriteLine("Ngay khong hop le!");
                    break ;
            }
        }
    }
}
