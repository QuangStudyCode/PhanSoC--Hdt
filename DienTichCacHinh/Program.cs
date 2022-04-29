using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DienTichCacHinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Menu===");
            Console.WriteLine("1.Tinh dien tich hinh tron.");
            Console.WriteLine("2.Tinh dien tich hinh chu nhat.");
            Console.WriteLine("3.Tinh dien tich hinh tam giac.");

            Console.Write("Nhap lua chon: ");
            int lua_chon=int.Parse(Console.ReadLine());

            const double Pi = 3.1415;
            int r, chieu_dai, chieu_rong;
            int canh_huyen, chieu_cao_tg;

            double dientich;

            switch (lua_chon)
            {
                case 1:
                    Console.Write("Nhap ban kinh hinh tron: ");
                    r = int.Parse(Console.ReadLine());
                    dientich = Pi * r * r;
                    Console.Write("Dien tich hinh tron la: " + dientich);
                    break;

                case 2:
                    Console.Write("Nhap chieu cao hinh chu nhat: ");
                    chieu_dai = int.Parse(Console.ReadLine());
                    Console.Write("Nhap chieu rong hinh chu nhat: ");
                    chieu_rong = int.Parse(Console.ReadLine());

                    dientich = chieu_dai * chieu_rong;

                    Console.Write("Dien tich hinh chu nhat la: " + dientich);
                    break;
                case 3:
                    {
                        Console.Write("Nhap chieu cao tam giac: ");
                        chieu_cao_tg = int.Parse(Console.ReadLine());

                        Console.Write("Nhap canh huyen tam giac: ");
                        canh_huyen = int.Parse(Console.ReadLine());
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Khong hop le");
                        break;
                    }
                
            }

           


        }
    }
}
