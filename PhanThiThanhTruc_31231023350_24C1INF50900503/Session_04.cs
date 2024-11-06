using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanThiThanhTruc_31231023350_24C1INF50900503
{
    internal class Session_04
    {
        //static void Main (string[] args)
        //{
        //    //Bai 1
        //    int m = maxOfThreeNumber(2, 3, 4);
        //    Console.WriteLine(m);
        //    Factorial(6);//Bai 2
        //    IsPrime(3);//Bai 3
        //    printPrimeNumberUnderN(10);//Bai 4.1
        //    printFirstNprime(10);//Bai4.2
        //    printAllPerfectNumberLessThan(1000); //Bai 5
        //    isPangram("The quick brown fox jumps over the lazy dog"); //Bai 6
        //    Console.ReadKey();
        //}
        /// <summary>
        /// <summary>
        /// 1. Write a C# function to find the maximum of three numbers.
        /// </summary>
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int maxOfThreeNumber(int a, int b, int c)
        {
            //return Math.Max(Math.Max(a, b), c); //Cach khac
            int max = 0;
            if (a > b && a > c)
            {
                max = a;
            }
            else if (b > a && b > c)
            {
                max = b;
            }
            else
            {
                max = c;
            }
            return max;
        }
        /// <summary>
        /// 2. Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        static void Factorial(int n)
        {
            int result = 1;
            if (n < 0)
            {
                Console.WriteLine("So phai la mot so nguyen khong am.");
                result = 0;
            }
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Giai thua cua {n} la: {result} ");
        }
        /// <summary>
        /// 3. Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
        /// </summary>
        /// <param name="number"></param>
        static void IsPrime(int number)
        {
            if (number < 2)
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
                    }
                }
                Console.WriteLine($"{number} la so nguyen to");
            }
        }

        /// <summary>
        /// 4. Write a C# function to print 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static bool isPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        /// <summary>
        /// 1. all prime numbers that less than a number(enter prompt keyboard).
        /// </summary>
        /// <param name="n"></param>
        static void printPrimeNumberUnderN(int n)
        {
            for (int i = 2; i <= n; i++)
                if (isPrime(i))
                    Console.Write(i + " ");
        }
        /// <summary>
        /// 2. the first N prime numbers
        /// </summary>
        /// <param name="n"></param>
        static void printFirstNprime(int n)
        {
            int so = 2;
            int dem = 0;
            while (dem < n)
            {
                if (isPrime(so))
                {
                    Console.Write(so + " ");
                    dem++;
                }
                so++;
            }
        }
        /// <summary>
        /// 5. Write a C# function to check whether a number is "Prefect" or not.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static bool isPerfect(int number)
        {
            if (number < 2) return false;
            int sumOfDivisors = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sumOfDivisors += i;
                }
            }
            return sumOfDivisors == number;
        }
        /// <summary>
        /// Then print all perfect number that less than 1000
        /// </summary>
        /// <param name="n"></param>
        static void printAllPerfectNumberLessThan(int limit)
        {
            Console.WriteLine("Cac so hoan hao nho hon 1000: ");
            for (int i = 1; i < limit; i++)
            {
                if (isPerfect(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
        /// <summary>
        /// 6. Write a C# function to check whether a string is a pangram or not.
        /// </summary>
        /// <param name="intput"></param>
        static void isPangram(string input)
        {
            input = input.ToLower();//Doi ve chu thuong

            for (char c = 'a'; c <= 'z'; c++)
            {
                if (!input.Contains(c))
                {
                    Console.WriteLine($"Chuoi '{input}' khong phai la mot pangram.");
                }
            }
            Console.WriteLine($"Chuoi '{input}' la mot pangranm.");
        }
    }
}
