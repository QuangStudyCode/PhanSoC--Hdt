using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1_IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nhập hai số và kiểm tra xem nó cs bằng nhau hay không
            Console.WriteLine("Nhap hai so nguyen a va b: ");
            int a, b;
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Hai so bang nhauu");
            }
            else
            {
                Console.WriteLine("Hai so khong bang nhauu");
            }
        }
    }
}
