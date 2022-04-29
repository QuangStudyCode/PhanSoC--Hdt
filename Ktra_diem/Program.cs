
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktra_diem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so diem toan: ");
            double toan = double.Parse(Console.ReadLine());

            Console.Write("Nhap so diem ly: ");
            double ly = double.Parse(Console.ReadLine());


            Console.Write("Nhap so diem hoa: ");
            double hoa = double.Parse(Console.ReadLine());

            double tong = toan + ly + hoa;
            double TlyHoa= ly + hoa;
            if (tong > 16.0)
            {
                Console.WriteLine("Ban da do!");
            }else if (TlyHoa > 14.0)
            {
                Console.WriteLine("Ban da do!");
            }
            else
            {
                Console.WriteLine("You fail!!");
            }

        }
    }
}
