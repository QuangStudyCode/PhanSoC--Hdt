using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktra_nguyenam_phuam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap hoc luc: ");

            char str1;
            str1=Convert.ToChar(Console.ReadLine().ToUpper());

            switch (str1)
            {
                case 'A':
                    Console.WriteLine("Hoc luc loai gioi!");
                    break;
                case 'B':
                    Console.WriteLine("kha");
                    break;
                case'C':
                    Console.WriteLine("trung binh");
                    break;
                case 'D':
                    Console.WriteLine("ngu");
                    break;
                default:
                    Console.WriteLine("Ban da nhap hang hoc luc khong dung. Xin thu lai!!!");
                    break;
            }

        }
    }
}
