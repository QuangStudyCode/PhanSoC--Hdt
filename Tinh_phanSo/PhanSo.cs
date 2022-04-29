using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_phanSo
{
    internal class PhanSo
    {
        int TuSo, MauSo;
        public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            TuSo = int.Parse(Console.ReadLine());
            //TuSo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Mau so: ");
            MauSo = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.Write("{0}/{1}", TuSo, MauSo);
        }

        //Hàm ước chung lớn nhất để rút gọn phân số
        public int UCLN(int a, int b)
        {
            a = Math.Abs(TuSo);
            b=Math.Abs(MauSo);

            while (a!=b&&b!=0&&a!=0)
            {
                if (a > b)
                {
                    a -=b;
                }
                else {
                    b -= a;
                }
            }
            return a;
        }

        public void RutGonPhanSo() // rút gọn tử và mẫu
        {
            PhanSo rutgon = new PhanSo();
            int uoc = UCLN(TuSo, MauSo);
            if (uoc != 0)
            {
                rutgon.TuSo = TuSo / uoc;
                rutgon.MauSo = MauSo / uoc;
            }
            else
            {
                rutgon.TuSo = TuSo;
                rutgon.MauSo= MauSo;
            }

            Console.WriteLine(rutgon.TuSo+"/"+rutgon.MauSo);


            ///bỏ số 1 ở mẫu
            /*if (rutgon.MauSo == 1) {
                Console.WriteLine("Phan so sau khi rut gon la: " + rutgon.TuSo);
            }
            else
            {
                Console.WriteLine("Phan so sau khi rut gon la: " + rutgon.TuSo+"/"+rutgon.MauSo);
            }*/
        }


        //nạp chồng toán tử cộng hai phân số
        public static PhanSo operator + (PhanSo a,PhanSo b)
        {
            PhanSo kq=new PhanSo();
            kq.TuSo = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            kq.MauSo = a.MauSo*b.MauSo;
            return kq;
        }
        //nạp chồng toán tử trừ hai phân số
        public static PhanSo operator - (PhanSo a,PhanSo b)
        {
            PhanSo Kq = new PhanSo();
            Kq.TuSo = a.TuSo * b.MauSo - b.TuSo * b.MauSo;
            Kq.MauSo= a.MauSo*b.MauSo;
            return Kq;
        }
        //nạp chồng toán tử nhân hai phân số
        public static PhanSo operator * (PhanSo a,PhanSo b)
        {
            PhanSo Kq = new PhanSo();
            Kq.TuSo = a.TuSo * b.TuSo;
            Kq.MauSo = a.MauSo * b.MauSo;
            return Kq;
        }
        //hàm nạp chồng toán tử chia hai phân số
        public static PhanSo operator / (PhanSo a, PhanSo b)
        {
            PhanSo Kq = new PhanSo();
            Kq.TuSo = a.TuSo * b.MauSo;
            Kq.MauSo = a.MauSo * b.TuSo;
            return Kq;
        }
    }
}
