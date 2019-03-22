using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlisinhvien
{
    class SinhVien
    {
        public String maSV;
        float toan;
        float ly;
        float hoa;
        //default constructors
        public SV()
        {
            this.maSV = "01";
            this.toan = (float)7.5;
            this.ly = (float)8.5;
            this.hoa = (float)9.5;
        }
        //tham so hoa constructors
        public SV(String maSV, float toan, float ly, float hoa)
        {
            this.maSV = maSV;
            this.toan = toan;
            this.ly = ly;
            this.hoa = hoa;
        }
        //viet ham nhap
        //viet ham tinh diem trung binh
        // viet ham in
        public void nhapthongtin()
        {
            Console.WriteLine("nhap ma sinh vien");
            this.maSV = Console.ReadLine();
            Console.WriteLine("nhap diem toan");
            this.toan = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem ly");
            this.ly = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem hoa");
            this.hoa = float.Parse(Console.ReadLine());
        }
        public float tinhTb()
        {
            float S = 0;
            S = (this.toan + this.ly + this.hoa) / 3;
            return S;
        }
        public void In()
        {
            Console.WriteLine("Ma {0} co diem trung binh la{1}", this.maSV, this.tinhTb());
        }

    }
}
 class SinhVien
 {
	 int n;
            Console.WriteLine("Nhap so sinh vien");
            n = Int32.Parse(Console.ReadLine());
            // tao mang doi tuong Sv
            SV[] sinhvien = new SV[n];
            for (int i = 0; i < n; i++)
            {
                sinhvien[i] = new SV();
                sinhvien[i].nhapthongtin();
                sinhvien[i].tinhTb();
                sinhvien[i].In();
            }
            // tim ra sinh vien nao co diem tung binh thap nhap
            float min = sinhvien[0].tinhTb();
            for (int i = 1; i < n; i++)
            {
                if (sinhvien[i].tinhTb() < min) min = sinhvien[i].tinhTb();
            }
            Console.WriteLine("SV co diem thap nhat la {0}", min);
            //tim ra sinh vien co chua chu 18I
            for (int i = 0; i < n; i++)
            {
                if (sinhvien[i].maSV.Contains("18IT"))
                    Console.WriteLine("SV ma{0} co diem  Tb la {1} co chua chu 18IT", sinhvien[i].maSV, sinhvien[i].tinhTb());
            }
            // sap xep mang sv theo diem tb tang dan
            SV tmp;
            {
                for (int i = 1; i < n; i++)
                {
                    for (int j = 1; j < n; j++)
                        if (sinhvien[i].tinhTb() > sinhvien[j].tinhTb())
                        {
                            tmp = sinhvien[i];
                            sinhvien[i] = sinhvien[j];
                            sinhvien[j] = tmp;
                        }
                }
            }

            Console.WriteLine("sinh vien sap xep theo thu tu giam dan");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sinh vien ma{0} co diem tb {1} ", sinhvien[i].maSV, sinhvien[i].tinhTb());
            }
            Console.ReadLine();
 }