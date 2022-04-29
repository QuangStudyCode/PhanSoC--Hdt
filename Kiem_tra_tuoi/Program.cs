using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiem_tra_tuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap tuoi: ");
            int tuoi= Int32.Parse(Console.ReadLine());

            if (tuoi <= 18)
            {
                Console.WriteLine("Tuoi cua ban khong du!");
            }
            else
            {
                Console.WriteLine("Ban da du tuoi bau cu!");
            }
        }
    }
}
