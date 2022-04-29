using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktra_Chieu_Cao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // height < 152 : lùn
            // H >= 1m52 && < 1m65: cao trung bình
            //H >165 && <=175 : cao
            //H > 175 : Cao bất thường
            Console.Write("Nhap height: ");
            int height = Int32.Parse(Console.ReadLine());

            if (height < 152.0)
            {
                Console.WriteLine("thuoc kieu nguoi lun! ");
            }else if(height>152.0 && height <= 165.0)
            {
                Console.WriteLine("thuoc kieu nguoi cao trung binh! ");

            }else if(height>165.0 && height < 175.0)
            {
                Console.WriteLine("thuoc kieu nguoi cao! ");
            }else
            {
                Console.WriteLine("thuoc kieu nguoi cao bat thuong! ");
            }
            
        }
    }
}
