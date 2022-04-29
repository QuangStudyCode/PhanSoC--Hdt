using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pt_bac2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            double dental,x1,x2;

            Console.Write("Nhap a,b,c : ");
            a=int.Parse(Console.ReadLine());
            b= int.Parse(Console.ReadLine());
            c=int.Parse(Console.ReadLine());

            dental = b * b - 4 * a * c;

            if (dental > 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem phan biet: ");
                x1 = (-b + Math.Sqrt(dental)) / 2 * a;
                x2 = (-c - Math.Sqrt(dental)) / 2 * a;
                Console.WriteLine("X1 la = {0}", x1);
                Console.Write("X2 la = {0}", x2);
            }else if (dental == 0)
            {
                Console.WriteLine("Phuong trinh co nghiem duy nhat: ");
                x1 = x2 = -b / (2 * a);
                Console.Write("X1=X2= " + x1);
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem!!");
            }
        }
    }
}
