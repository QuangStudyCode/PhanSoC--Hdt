using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Năm nhuận là năm chia hết cho 4 và không chia hết cho 100, chia hết cho 400
            Console.WriteLine("Nhap nam: ");
            int nam = Int32.Parse(Console.ReadLine());

            if (nam % 400 == 0)
            {
                Console.WriteLine("Day la nam nhuan!");
            }else if(nam % 4==0 && nam % 100 != 0)
            {
                Console.WriteLine("Day la nam nhuan!");
            }
            else
            {
                Console.WriteLine("Day khong phai nam nhuan!");
            }
        }
    }
}
