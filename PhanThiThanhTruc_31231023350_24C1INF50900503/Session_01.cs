using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanThiThanhTruc_31231023350_24C1INF50900503
{
    internal class Session_01
    {
        //static void Main (string[] args)
        //{
        //    //Bai2_Ex01();
        //    //Bai2_Ex02();
        //    //Bai2_Ex03();
        //    //Bai2_Ex04();
        //    //Bai2_Ex05();
        //    //Bai2_Ex06();
        //    //Bai2_Ex07();
        //    //Bai2_Ex08();
        //    //Bai2_Ex09();
        //    //Bai2_Ex10();
        //}
        /// <summary>
        /// C# Structure Programming Language Fundamentals exercises <br/>
        /// 1. Write programs to Add / Sum Two Numbers.
        /// </summary>
        public static void Bai2_Ex01()
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"{a}+{b}={c}");
        }
        /// <summary>
        /// 2. Write programs to Swap Values of Two Variables.
        /// </summary>
        public static void Bai2_Ex02()
        {
            Console.Write("Nhap bien a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap bien b: ");
            int b = int.Parse(Console.ReadLine());
            int hoanvi = a;
            a = b;
            b = hoanvi;
            Console.WriteLine($"Gia tri cua bien a:{a}");
            Console.WriteLine($"Gia tri cua bien b:{b}");
        }
        /// <summary>
        /// 3. Write programs to Multiply two Floating Point Numbers
        /// </summary>
        public static void Bai2_Ex03()
        {
            Console.Write("Nhap so thu nhat: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            float b = float.Parse(Console.ReadLine());
            float ketqua = a * b;
            Console.WriteLine($"Ket qua nhan hai so: {ketqua}");
        }
        /// <summary>
        /// 4. Write programs to convert feet to meter.
        /// </summary>
        public static void Bai2_Ex04()
        {
            Console.Write("Nhap gia tri feet: ");
            double feet = double.Parse(Console.ReadLine());
            double meter = feet * 0.3048;
            Console.WriteLine($"Gia tri meter nhan duoc: {meter} m");
        }
        /// <summary>
        /// 5. Write programs to convert Celsius to Fahrenheit and vice versa.
        /// </summary>
        public static void Bai2_Ex05()
        {
            Console.Write("Nhap nhiet do theo do C: ");
            double C = double.Parse(Console.ReadLine());
            double F = (C * 9 / 5) + 32;
            Console.WriteLine($"Nhiet do theo do F: {F}");

            Console.Write("Nhap nhiet do theo do F: ");
            double f = double.Parse(Console.ReadLine());
            double c = (f - 32) * 5 / 9;
            Console.WriteLine($"Nhiet do theo do C: {c}");
        }
        /// <summary>
        /// 6. Write programs to find the Size of data types.
        /// </summary>
        public static void Bai2_Ex06()
        {
            Console.WriteLine("Kich thuc cua int: " + sizeof(int) + " bytes");
            Console.WriteLine("Kich thuc cua float: " + sizeof(float) + " bytes");
            Console.WriteLine("Kich thuc cua double: " + sizeof(double) + " bytes");
            Console.WriteLine("Kich thuc cua char: " + sizeof(char) + " bytes");
            Console.WriteLine("Kich thuc cua bool: " + sizeof(bool) + " bytes");
            Console.WriteLine("Kich thuc cua long: " + sizeof(long) + " bytes");
            Console.WriteLine("Kich thuc cua short: " + sizeof(short) + " bytes");
            Console.WriteLine("Kich thuc cua byte: " + sizeof(byte) + " bytes");
        }
        /// <summary>
        /// 7. Write programs to Print ASCII Value (tip: read character, print number of this char)
        /// </summary>
        public static void Bai2_Ex07()
        {
            Console.Write("Nhap vao ky tu: ");
            char c = char.Parse(Console.ReadLine());
            int num = c;
            Console.WriteLine($"{c} in ASCII = {num}");
        }
        /// <summary>
        /// 8. Write programs to Calculate Area of Circle
        /// </summary>
        public static void Bai2_Ex08()
        {
            Console.Write("Nhap ban kinh: ");
            float r = float.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Dien tich hinh tron ban kinh {r} la: {area}");
            //Math.Pow(r, 10);// r mu 10
            //Math.Sqrt(r);// can bac hai
        }
        /// <summary>
        /// 9. Write programs to Calculate Area of Square
        /// </summary>
        public static void Bai2_Ex09()
        {
            Console.Write("Nhap canh hinh vuong: ");
            float a = float.Parse(Console.ReadLine());
            double area = Math.Pow(a, 2);
            Console.WriteLine($"Dien tich hinh vuong canh {a} la: {area}");
        }
        /// <summary>
        /// 10. Write programs . to convert days to years, weeks and days
        /// </summary>
        public static void Bai2_Ex10()
        {
            Console.Write("Nhap so ngay: ");
            int ngay = int.Parse(Console.ReadLine());
            int nam = ngay / 365;
            Console.WriteLine($"So nam la: {nam}");
            int tuan = (ngay - nam * 365) / 7;
            Console.WriteLine($"So tuan la: {tuan}");
            int ngayle = (ngay - nam * 365) % 7;
            Console.WriteLine($"So ngay le: {ngayle}");
        }
    }
}
