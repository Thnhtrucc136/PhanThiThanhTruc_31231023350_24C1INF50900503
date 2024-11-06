using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanThiThanhTruc_31231023350_24C1INF50900503
{
    internal class Session_03
    {
        //static void Main(string[] args)
        //{
        //Bai4_Ex01_P1();
        //Bai4_Ex02_P1();
        //Bai4_Ex03_P1();
        //Bai4_Ex01_P2();
        //Bai4_Ex02_P2();
        //Bai4_Ex03_P2();
        //Bai4_Ex06_P2();
        //Bai4_Ex07_P2();
        //Bai4_Ex08_P2();
        //Bai4_Ex04_01_P2();
        //Bai4_Ex04_02_P2();
        //Bai4_Ex04_03_P2();
        //}
        /// <summary>
        /// Control flow statements exercises <br/>
        /// 1. Write a C# Sharp program to check whether a given number is even or odd.
        /// </summary>
        /// 
        static void Bai4_Ex01_P1()
        {
            Console.Write("Nhap vao so nguyen: ");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine($"So {a} la so chan");
            }
            else
            {
                Console.WriteLine($"So {a} la so le");
            }
        }
        /// <summary>
        /// 2. Write a C# Sharp program to find the largest of three numbers.
        /// </summary>
        public static void Bai4_Ex02_P1()
        {
            Console.WriteLine("Vui long nhap vao ba so: ");
            Console.Write("Nhap vao so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu ba: ");
            int c = int.Parse(Console.ReadLine());
            int max = a;

            if (b > max)
            {
                if (c > max)
                {
                    max = c;
                }
                else
                {
                    max = b;
                }
            }
            Console.WriteLine($"So lon nhat trong ba so la {max}");
        }
        /// <summary>
        /// 3. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
        /// </summary>
        public static void Bai4_Ex03_P1()
        {
            Console.WriteLine("Vui long nhap toa do diem: ");
            Console.Write("Nhap toa do X: "); int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap toa do Y: "); int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Toa do da cho thuoc phan tu thu nhat");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Toa do da cho thuoc phan tu thu hai");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Toa do da cho thuoc phan tu thu ba");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Toa do da cho thuoc phan tu thu tu");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Toa do da cho nam tai goc toa do");
            }
        }
        /// <summary>
        /// 1. Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
        /// </summary>
        public static void Bai4_Ex01_P2()
        {
            do
            {
                Console.WriteLine("Vui long nhap ba canh tam giac: ");
                Console.Write("Nhap canh a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Nhap canh b: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Nhap canh c: ");
                int c = int.Parse(Console.ReadLine());

                if (a + b > c && b + c > a && a + c > b)
                {
                    if (a == b || b == c || c == a)
                    {
                        if (a == b && b == c)
                        {
                            Console.WriteLine(" Tam giac do la tam giac deu");
                        }
                        else
                        {
                            Console.WriteLine("Tam giac do la tam giac can");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tam giac do la tam giac khong can");
                    }
                }
                else
                {
                    Console.WriteLine("Ba canh nay khong phai tam giac, vui long nhap lai.");
                }
                Console.WriteLine("Ban co muon tiep tuc nhap <y/n>?");
                string tiepTuc = Console.ReadLine();
                if (tiepTuc.ToLower() != "y")
                {
                    break;
                }

            } while (true);
        }
        /// <summary>
        /// 2. Write a program to read 10 numbers and find their average and sum.
        /// </summary>
        public static void Bai4_Ex02_P2()
        {
            double tong = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nhap so thu {i + 1}: ");
                double number = Convert.ToDouble(Console.ReadLine());
                tong += number;
            }
            double tb = tong / 10;
            Console.WriteLine($"Tong cua 10 so: {tong}");
            Console.WriteLine($"Trung binh cua 10 so: {tb}");
        }
        /// <summary>
        /// 3. Write a program to display the multiplication table of a given integer.
        /// </summary>
        public static void Bai4_Ex03_P2()
        {
            Console.WriteLine("Vui long nhap so nguyen cho truoc: ");
            int song = int.Parse(Console.ReadLine());
            Console.WriteLine($"BANG CUU CHUONG CUA {song}");
            int ketqua = 0;
            for (int i = 1; i < 11; i++)
            {
                ketqua = song * i;
                Console.WriteLine($"{song}*{i}={ketqua}");
            }
        }
        /// <summary>
        /// 4. Write a program to display a pattern like triangles with number.
        /// </summary>
        public static void Bai4_Ex04_01_P2()
        //Pattern 1
        {
            Console.Write("Nhap so dong ket thuc cua day: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) // lap theo chieu doc
            {
                for (int j = 1; j <= i; j++) // lap theo chieu ngang
                {
                    Console.Write(j); // In cac so tu 1 den i
                }
                Console.WriteLine(); // Xuong dong sau moi hang
            }
        }
        public static void Bai4_Ex04_02_P2()
        //Pattern 2
        {
            int n = 1;
            Console.Write("Nhap so dong cua mau: ");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{n} ");
                    n++; // Tang gia tri n sau moi lan in
                }
                Console.WriteLine();
            }
        }
        public static void Bai4_Ex04_03_P2()
        //Pattern 3
        {
            int n = 1;
            int rows = 4;

            for (int i = 1; i <= rows; i++) // Vòng lặp chiều dọc từ 1 đến rows
            {
                for (int s = 1; s <= rows - i; s++) // Vòng lặp in khoảng trắng
                {
                    Console.Write(" "); // In khoảng trắng để căn giữa
                }
                for (int j = 1; j <= i; j++) // Vòng lặp in các số
                {
                    Console.Write($"{n} "); // In giá trị của n kèm khoảng trắng
                    n++; // Tăng giá trị của n cho lần in tiếp theo
                }
                Console.WriteLine(); // Xuống dòng sau khi in xong một hàng
            }
        }
        /// <summary>
        /// 6. Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
        /// </summary>
        public static void Bai4_Ex06_P2()
        {
            int n;
            double Tong = 0;

            do
            {
                Console.Write("Nhap so luong so hang n: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Gia tri khong hop le. Vui long nhap lai");
                }
            } while (n <= 0);
            for (int i = 1; i <= n; i++)
            {
                Tong += 1.0 / i;
            }
            Console.WriteLine($"Tong cua {n} so hang dieu hoa la: {Tong}");
        }
        /// <summary>
        /// 7. Write a program to find the ‘perfect’ numbers within a given number range.
        /// </summary>
        public static void Bai4_Ex07_P2()
        {
            int gioihanduoi;
            int gioihantren;

            Console.Write("Nhap gioi han duoi: ");
            gioihanduoi = int.Parse(Console.ReadLine());

            Console.Write("Nhap gioi han tren: ");
            gioihantren = int.Parse(Console.ReadLine());

            Console.WriteLine($"Cac so hoan hao trong khoang tu {gioihanduoi} đen {gioihantren} la:");
            for (int number = gioihanduoi; number <= gioihantren; number++)
            {
                int Tong = 0;
                for (int i = 1; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        Tong += i;
                    }
                }
                if (Tong == number)
                {
                    Console.WriteLine(number);
                }
            }
        }
        /// <summary>
        /// 8. Write a program to determine whether a given number is prime or not.
        /// </summary>
        public static void Bai4_Ex08_P2()
        {
            int number;

            do
            {
                Console.Write("Nhap vao so nguyen: ");
                number = int.Parse(Console.ReadLine());
            }
            while (number <= 0);
            if (number <= 1)
            {
                Console.WriteLine($"{number} khong phai la so nguyen to");
            }
            else
            {
                for (int i = 2; i <= (int)Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine($"{number} khong phai so nguyen to");
                        return;
                    }
                }
                Console.WriteLine($"{number} la so nguyen to");
            }
        }
    }
}
