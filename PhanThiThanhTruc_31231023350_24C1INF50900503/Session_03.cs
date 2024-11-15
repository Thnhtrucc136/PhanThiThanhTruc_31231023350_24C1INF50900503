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
        //    //Excercises unit 3 Data types
        //    //Bai3_Ex01();
        //    //Bai3_Ex02();
        //    //Bai3_Ex03();
        //    //Excercises unit 4 Operators and control flow
        //    //Bai4_Ex01();
        //    //Bai4_Ex02();
        //    //Bai4_Ex03();
        //    //Bai4_Ex04();
        //    //Bai4_Ex05();
        //}
        /// <summary>
        /// Data Types excercises <br/>
        /// 1. Create a C# program to convert from degrees Celsius to Kelvin and Fahrenheit.
        /// </summary>
        public static void Bai3_Ex01()
        {
            Console.Write("Please enter Celsius degrees: ");
            int Cel = int.Parse(Console.ReadLine());
            int Kel = Cel + 273;
            int Fah = Cel * 18 / 10 + 32;
            Console.WriteLine($"Celsius to Kalvin: {Kel}");
            Console.WriteLine($"Celsius to Fahrenheit: {Fah}");
        }
        /// <summary>
        /// 2. Create a program in C# for calculate the surface and volume of a sphere, given its radius.
        /// </summary>
        public static void Bai3_Ex02()
        {
            Console.Write("Please enter radius: ");
            double r = float.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * Math.Pow(r, 2);
            double volume = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Surface: {surface}");
            Console.WriteLine($"Volume: {volume}");
        }
        /// <summary>
        /// 3. Write a program in C# that calculates the result of adding, subtracting, multiplying and dividing two numbers entered by the user.
        /// </summary>
        public static void Bai3_Ex03()
        {
            Console.Write("Nhap vao so dau tien: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            int cong = a + b;
            int tru = a - b;
            int nhan = a * b;
            int chiang = a / b;
            double chiadu = a % b;
            Console.WriteLine("Ket qua phep tinh: ");
            Console.WriteLine($"{a} + {b} = {cong}");
            Console.WriteLine($"{a} - {b} = {tru}");
            Console.WriteLine($"{a} * {b} = {nhan}");
            Console.WriteLine($"{a} / {b} = {chiang}");
            Console.WriteLine($"{a} mod {b} = {chiadu}");
        }
        /// <summary>
        /// Operators exercises <br/>
        /// 1. Write a C# Sharp program that takes two numbers as input and performs an operation(+,-,*, x,/) on them and displays the result of that operation.
        /// </summary>
        public static void Bai4_Ex01()
        {
            Console.Write("Nhap vao so dau tien: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            int cong = a + b;
            int tru = a - b;
            int nhan = a * b;
            int chia = a / b;
            Console.WriteLine("Ket qua phep tinh hai so: ");
            Console.WriteLine($"{a} + {b} = {cong}");
            Console.WriteLine($"{a} - {b} = {tru}");
            Console.WriteLine($"{a} * {b} = {nhan}");
            Console.WriteLine($"{a} / {b} = {chia}");
        }
        /// <summary>
        /// 2. Write a C# Sharp program to display certain values of the function x = y2+ 2y + 1 (using integer numbers for y, ranging from -5 to +5).
        /// </summary>
        public static void Bai4_Ex02()
        {
            Console.Write("Nhap gia tri y: ");
            int y = int.Parse(Console.ReadLine());

            if (y <= 5 && y >= -5)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"Voi y = {y}, thi x = {x}");
            }
            else
            {
                Console.WriteLine("Vui long nhap lai gia tri y");
            }
        }
        /// <summary>
        /// 3. Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour(km/h) and miles per hour(miles/h).
        /// </summary>
        public static void Bai4_Ex03()
        {
            Console.Write("Nhap vao khoang cach (km): ");
            double kc = double.Parse(Console.ReadLine());//km
            Console.WriteLine("Nhap vao thoi gian: ");
            Console.Write("Nhap so gio: ");
            float gio = float.Parse(Console.ReadLine());
            Console.Write("Nhap so phut: ");
            float phut = float.Parse(Console.ReadLine());
            Console.Write("Nhap so giay: ");
            float giay = float.Parse(Console.ReadLine());
            double time = gio + (phut / 60.0) + (giay / 3600.0);
            double Tocdo = kc / time;
            Console.WriteLine($"Toc do theo km/h: {Tocdo} km/h");
            Console.WriteLine($"Toc do theo miles/h: {Tocdo * 0.621371} miles/h");
        }
        /// <summary>
        /// 4. Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere.V = 4/3*π* r
        /// </summary>
        public static void Bai4_Ex04()
        {
            Console.Write("Nhap ban kinh hinh cau: ");
            double r = float.Parse(Console.ReadLine());
            double Dt = 4 * Math.PI * Math.Pow(r, 2);
            double Tt = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Dien tich be mat cua hinh cau ban kinh {r}: {Dt}");
            Console.WriteLine($"The tich hinh cau ban kinh {r}: {Tt}");
        }
        /// <summary>
        /// 5. Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
        /// </summary>
        public static void Bai4_Ex05()
        {
            Console.Write("Nhap mot ky tu: ");
            char kytu = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if ("AEIOUaeiou".IndexOf(kytu) >= 0)
            {
                Console.WriteLine($"{kytu} la mot nguyen am.");
            }
            else if (char.IsDigit(kytu))
            {
                Console.WriteLine($"{kytu} la mot chu so.");
            }
            else
            {
                Console.WriteLine($"{kytu} la mot ky hieu khac.");
            }
        }
    }
}
