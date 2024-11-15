using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanThiThanhTruc_31231023350_24C1INF50900503
{
    internal class Session_06
    {
        //static void Main(string[] args)
        //{
        //    //ArrayEx_01();
        //    AlgorithmsEx_01();
        //}
        /// <summary>
        /// 1. Declare an array N items. With N is entered from users. <br/>
        /// 1.1 Enter item values for this array. <br/>
        /// 1.2 Print the array to screen. <br/>
        /// 1.3 Write a function that increase each iteam of the array by adding it with 2. <br/>
        /// </summary>
        public static void ArrayEx_01()
        {
            //1.1
            Console.Write("Enter the quantity of items: ");
            int N=int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter a number: ");
                bool res = int.TryParse(Console.ReadLine(), out arr[i]);
                if (!res)
                {
                    Console.WriteLine("Please enter a number!");
                    i--;
                }
            }
            //1.2
            Console.WriteLine("Array: ");
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
            //1.3
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i]+ 2;
            }
            Console.WriteLine("New Array: ");
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
        }
        static void AlgorithmsEx_01()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            //Nhap(a);
            generateRandomArray(a);//ham nhap gia tri phan tu bang cach random
            Array.Sort(a); // Sap xep tang dan gia tri phan tu mang
            InMang(a); Console.WriteLine();//ham in gia tri cua tung phan tu

            Console.Write("Nhap so can tim kiem: ");
            int soCanTim = int.Parse(Console.ReadLine());
            //int pos = timkiem_linear(a, soCanTim);
            int pos = BinarySearchInterative(a, soCanTim);

            if (pos == -1)
            {
                Console.WriteLine($"So {soCanTim} khong co trong mang.");
            }
            else
            {
                Console.WriteLine($"So {soCanTim} xuat hien tai vi tri {pos}.");
            }
        }
        static void Nhap(int[] a) //Nguoi dung nhap gia tri mang
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap phan tu thu {i}: ");
                int v = int.Parse(Console.ReadLine());
                a[i] = v;
            }
        }
        static void generateRandomArray(int[] a) 
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(0, 100);
            }
        }
        static void InMang(int[] a)
        {
            foreach (int i in a)
            {
                Console.Write($"{i}, ");
            }
        }
        /// <summary>
        /// Tim 1 so co trong mang hay khong
        /// </summary>
        /// <param name="a">la mang so nguyen</param>
        /// <param name="soCanTim">la so can tim trong mang</param>
        /// <returns></returns Tra ve: <li-1 neu khong tim thay.
        /// <li>vi tri xuat hien neu tim thay</li>
        /// </returns>
        static int timkiem_linear(int[] a, int soCanTim) //ham tim kiem vi tri cua so can tim
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == soCanTim)
                {
                    return i;
                }
            }
            return -1;
        }
        static int BinarySearchInterative(int[] a, int soCanTim)
        {
            int min = 0;
            int max = a.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (soCanTim == a[mid])
                {
                    return ++mid;
                }
                else if (soCanTim < a[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
