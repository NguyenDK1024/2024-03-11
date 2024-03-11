using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_03_11
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            //Console.Write("nhap vao thang = ");
            //int A = int.Parse(Console.ReadLine()); //Ep kieu du lieu tu string sang int
            //Console.Write("nhap vao nam = ");
            //int B = int.Parse(Console.ReadLine());


            //string i= Console.ReadLine();
            //A = int.Parse(i);
            //if (A%3 == 0) Console.WriteLine("Day la so chia het cho 3");// Cu phap if 1 dong (voi dieu kien cho co 1 cau lenh moi duoc dung)
            //else Console.WriteLine("Day khong chia het cho 3");
            //Console.WriteLine(A % 3 == 0 ? "Day la so chia het cho 3" : "Day la so khong chia het cho 3");// Toan tu 3 ngoi

            //string kq = "So nay chia het cho 3"; //Gan gia tri mac dinh
            //if (A % 3 != 0) kq = "So nat chia het cho 3";
            //Console.Write(kq);

            //switch (A)
            //{
            //    case 1: case 2: case 3: case 4: case 5:case 6:case 7:case 8:case 9:case 10:case 11: case 12:
            //        int C = DateTime.DaysInMonth(B, A);
            //        int so_ngay = C;
            //        Console.WriteLine("So ngay trong thang {0} la {1}", A, so_ngay);
            //        break;
            //    default:
            //        Console.WriteLine("so thang nay khong hop le");
            //        break;
            //}

            //for (int i = 0; i < A; i++)
            //{
            //if (i % 2 ==0) Console.WriteLine(i);            
            //}

            //int s = 0;
            //for (int i = 0; i < 100; i += 2)
            //{
            //    s += i;
            //}
            //Console.WriteLine(s);

            int i = 1;

            while (i<=10)   
            {
                Console.WriteLine("3 X {0} = {1}",i,i*3);
                i++;
            }

            Console.ReadKey();
        }
    }
}
