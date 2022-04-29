using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_phanSo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PhanSo A = new PhanSo();
            PhanSo B = new PhanSo();
            PhanSo C=new PhanSo();

            int LuaChon;

            do
            {
                Console.WriteLine("***************MAIN MENU**********");
                Console.WriteLine("0.   Nhap hai phan so a va b.");
                Console.WriteLine("1.   Cong hai phan so.");
                Console.WriteLine("2.   Tru hai phan so.");
                Console.WriteLine("3.   Nhan hai phan so.");
                Console.WriteLine("4.   Chia hai phan so.");

                Console.WriteLine("5.   THOAT");
                Console.Write("    NHAP LUA  CHON CUA BAN VAO:");

                LuaChon = int.Parse(Console.ReadLine());
                switch (LuaChon)
                {
                    case 0:
                        Console.WriteLine("Nhap phan so a ");A.Nhap();
                        Console.WriteLine("Nhap phan so b ");B.Nhap();
                        break;
                    case 1:
                        C = A + B;
                        Console.Write("Cong hai phan so: "); A.Xuat(); Console.Write("+"); B.Xuat(); Console.Write("="); C.Xuat();
                        Console.ReadKey();
                        break;
                    case 2:
                        C = A - B;
                        Console.Write("Cong hai phan so: "); A.Xuat(); Console.Write("+"); B.Xuat(); Console.Write("="); C.Xuat();
                        Console.ReadKey();
                        break;
                    case 3:
                        C = A * B;
                        Console.Write("Nhan hai phan so: "); A.Xuat(); Console.Write("*");B.Xuat();Console.Write("=");C.Xuat();
                        Console.WriteLine();
                        C.RutGonPhanSo();
                        Console.ReadKey();
                        break;
                    case 4:
                        C = A / B;
                        Console.Write("Chia hai phan so: ");A.Xuat();Console.Write("/"); B.Xuat();Console.Write("=");C.Xuat();
                        Console.WriteLine();
                        C.RutGonPhanSo();
                        Console.ReadKey();
                        break;
                    case 5:

                        break;
                }
            } while (LuaChon != 5);

          

        }
    }
}
