using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiPhuongDung_31231027780_24C1INF50900503
{
    internal class Session_04
    {
        static void Session04_mau()
        {
            do
            {
                //1. may nghi ngau nhien 1 so
                Random rnd = new Random();
                int comp_num = rnd.Next(0, 10) + 1; //lenh next(0,10) chi lay gia tri tu 0 den 9, cong 1 de lay dung gia tri
                                                    //2. keu ng dung dua 1 so
                                                    // doan den khi dung
                int count = 0;
                bool isContinue = true;
                do
                {
                    count++;
                    Console.Write("ban doan so may? <1..10> ");
                    int user_num = int.Parse(Console.ReadLine());
                    //3. kiem tra ket qua
                    if (user_num == comp_num)
                    {
                        Console.WriteLine($"ban da doan trung sau {count} lan ");
                        isContinue = false;
                    }
                    else
                    {
                        if (user_num > comp_num)
                            Console.WriteLine("so ban nhap lon hon so may nghi");
                        else
                            Console.WriteLine("so ban nhap be hon so may nghi");
                    }
                }
                while (isContinue);
                Console.WriteLine("_______________________");
                Console.WriteLine("choi nua hog <C/K>: ");
                string tl = Console.ReadLine();
                if (tl.ToUpper().Equals("K"))
                {
                    Console.WriteLine("thang ma hog cho go. lan sau hog choi nua!");
                    return;
                }
            } while (true);
        }
        static void Session04_ex01()
            //Write a C# Sharp program to check whether a given number is even or odd
        {
            Console.WriteLine("Nhap vao 1 so:");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine(" day la so chan");
            else Console.WriteLine(" day la so le ");
        }
        static void Session04_ex02()
        //Write a C# Sharp program to find the largest of three numbers
        {
            Console.Write("Nhap vao so a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so b:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so c:");
            int c = int.Parse(Console.ReadLine());
            if (a >= b && a >= c)
                Console.WriteLine($"so lon nhat la {a}");
            else
            {
                if (b >= a && b >= c)
                    Console.WriteLine($"so lon nhat la {b}");
                else Console.WriteLine($"so lon nhat la {c}");
            }
        }
        static void Session04_ex03()
            //Write a C# Sharp program to accept a coordinate point in an XY
            //coordinate system and determine in which quadrant the coordinate
            //point lies.
        {
            Console.WriteLine("nhap toa do X:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap toa do Y:");
            int y = int.Parse(Console.ReadLine());
            if ( x>0 && y>0 ) { Console.WriteLine("Toa do thuoc phan tu thu nhat"); }
            else if (x < 0 && y > 0) { Console.WriteLine("Toa do thuoc phan tu thu hai"); }
            else if (x < 0 && y < 0) { Console.WriteLine("Toa do thuoc phan tu thu ba"); }
            else if (x > 0 && y < 0) { Console.WriteLine("Toa do thuoc phan tu thu bon"); }
        }
        static void Session04_ex04()
            //Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
        {
            Console.WriteLine(" nhap so do canh a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(" nhap so do canh b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(" nhap so do canh c:");
            int c = int.Parse(Console.ReadLine());
            // kiem tra co phai tam giac ko
            if ((a+b)>c && (a+c)>b && (b+c)>a) { Console.Write()}

        }
        static int Main()
        {
            //Session04_mau();
            //Session04_ex01();
            //Session04_ex02();
            Session04_ex03();
            return 1;
        }
    }
}

