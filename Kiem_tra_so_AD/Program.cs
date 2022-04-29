using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiem_tra_so_AD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so: ");
            int s = int.Parse(Console.ReadLine());

            //nếu số lớn hơn 0 thì hiển thị ra 1, nhỏ hơn thì hiển thị ra âm 1,bằng thì hiển thị ra không
            if (s != 0)
            {
                if (s > 0)
                {
                    Console.WriteLine("hien thi: 1");
                }
                else
                {
                    Console.WriteLine("hien thi: -1");
                }
            }
            else
            {
                    Console.WriteLine("hien thi: 0");
            }
        }
    }
}
