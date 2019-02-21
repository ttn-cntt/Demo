using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.Entity
{
    class XuLy
    {
        public int diemso(double diem)
        {
            int d;
            if (diem >= 8.5)
                d = 4;
            else if (diem >= 7)
                d = 3;
            else if (diem >= 5.5)
                d = 2;
            else if (diem >= 4)
                d = 1;
            else
                d = 0;
            return d;
        }
        public String diemchu(double diem)
        {
            String d;
            if (diem >= 8.5)
                d = "A";
            else if (diem >= 7)
                d = "B";
            else if (diem >= 5.5)
                d = "C";
            else if (diem >= 4)
                d = "D";
            else
                d = "F";
            return d;
        }
        public String XL(double diem)
        {
            String x;
            if (diem >= 3.6)
                x = "Xuất sắc";
            else if (diem >= 3.2)
                x = "Giỏi";
            else if (diem >= 2.5)
                x = "Khá";
            else if (diem >= 2)
                x = "TB";
            else
                x = "Yếu";
            return x;
        }
    }
}
