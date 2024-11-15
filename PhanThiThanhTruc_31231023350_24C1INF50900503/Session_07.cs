using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PhanThiThanhTruc_31231023350_24C1INF50900503
{
    internal class Session_07
    {
        static void NhapMangBangCom(int[,] a, int rows, int cols)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine()); // nhap tay mang nxm
                }
            }
        }
        private static void XuatMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t "); //\t cach dong cho dep
                }
                Console.WriteLine();
            }
        }
        static void SearchLiner(int[,] a, int val)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == val)
                    {
                        Console.WriteLine($"{val} xuat hien tai dong {i} cot {j}\n");
                        return;
                    }
                }
            }
        }
        static void NhapMangNgauNhien(int[,] a, int rows, int cols)
        {
            Random rnd = new Random(); //Khai báo random
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rnd.Next(0, 100);
                }
            }
        }
        static void XuatDong(int[,] a, int dong)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (dong == i)
                    Console.Write(a[i, j] + "\t ");
                }
            }
        }
        static void XuatCot(int[,] a, int cot)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (cot == j)
                        Console.WriteLine(a[i,j] + " ");
                }
            }
        }
        static int MaxValue(int[,] a) //kieu int vi la gia tri
        {
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i,j] > max)
                    {
                        max = a[i,j];
                    }
                }
            }
            return max; //tra ve gia tri max
        }
        static int MinOfRows(int[,] a, int dong)
        {
            int minrow = a[dong, 0];
            for (int j = 1; j < a.GetLength(1); j++)
            {
                if (a[dong, j] < minrow)
                {
                    minrow = a[dong, j];
                }
            }
            return minrow;
        }
        static int MinOfCols(int[,] a, int cot)
        {
            int mincol = a[0, cot];
            for (int i = 1; i < a.GetLength(0); i++)
            {
                if (a[i, cot] < mincol)
                {
                    mincol = a[i, cot];
                }
            }
            return mincol;
        }
        static int[,] TransposeMaxtrix(int[,]a)
        {
            int transrow= a.GetLength(0); //lay gia do dai dong va cot ma tran a
            int transcol= a.GetLength(1);
            
            int [,] transposed = new int [transcol, transrow]; //tao ma tran moi voi so dong bang so cot ma tran a

            for (int i = 0; i < transrow; i++)
            {
                for (int j = 0; j < transcol; j++)
                {
                    transposed[j, i] = a[i, j];
                }
            }
            return transposed; //tra ve ma tran chuyen vi
        }
        static void PrintTheMainandSencondarydiagonal(int[,] a)
        {
            int rows = a.GetLength(0); 
            int cols = a.GetLength(1); 
            int limit = Math.Min(rows, cols);
            Console.WriteLine("Duong cheo chinh cua ma tran: ");
            for (int i = 0; i < limit; i++)
            {
                        Console.Write(a[i, i] + "\t ");
            }
            Console.WriteLine();
            Console.WriteLine("Duong cheo phu cua ma tran: ");
            for (int i = 0; i < limit; i++)
            {
                Console.Write(a[i, limit - 1 - i] + "\t");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Create a program with following functions <br/>
        /// - Create an integer  matrix NxM (N,M was prompted from user) randomly. <br/>
        /// - Print the maxtrix. <br/>
        /// - Print the ith row/col of the maxtrix. <br/>
        /// - Find the max value of the maxtrix <br/>
        /// - Find the min value of ith row/col of the maxtrix. <br/>
        /// - Tranpose the maxtrix. <br/>
        /// - Print the main/secondary diagonal values of the maxtrix. <br/>
        /// </summary>
        static void BaiTap_MangHaiChieu()
        {
            int[,] a; // khai báo trước vì không biết ng dùng tạo bao nhiêu
            Console.Write("Nhap so dong: "); int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: "); int cols = int.Parse(Console.ReadLine());
            //tao mang 2 chieu
            a = new int[rows, cols];
            //NhapMangBangCom(a,rows, cols);
            NhapMangNgauNhien(a, rows, cols);
            XuatMang(a);

            Console.Write("Nhap so can tim: "); int val = int.Parse(Console.ReadLine());
            SearchLiner(a, val);

            Console.Write("Ban muon xuat dong hay cot <D/C>?");
            string choice = Console.ReadLine();
            if (choice.ToUpper().Equals("D"))
            {
                Console.Write("Nhap so dong ban muon xuat: "); int dong = int.Parse(Console.ReadLine());
                XuatDong(a, dong);
                Console.WriteLine();
                int mindong = MinOfRows(a, dong);
                Console.WriteLine($"Gia tri phan tu nho nhat trong dong {dong} la: {mindong}");
            }
            else
            {
                Console.Write("Nhap so cot ban muon xuat: "); int cot = int.Parse(Console.ReadLine());
                XuatCot(a, cot);
                int mincot = MinOfCols(a, cot);
                Console.WriteLine();
                Console.WriteLine($"Gia tri phan tu nho nhat trong dong {cot} la: {mincot}");
            }

            int maxValue = MaxValue(a);
            Console.WriteLine($"Gia tri phan tu lon nhat trong mang la: {maxValue}");

            int[,] transposedMatrix = TransposeMaxtrix(a);
            Console.WriteLine("Mang sau khi chuyen vi: ");
            for (int i = 0; i < transposedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < transposedMatrix.GetLength(1); j++)
                {
                    Console.Write(transposedMatrix[i, j] + "\t");
                }
                Console.WriteLine();

            }

            PrintTheMainandSencondarydiagonal(a);
        }
        private static void NhapMangTuDong(int[][] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap so cot cho dong {i}: ");
                int cols = int.Parse(Console.ReadLine());
                a[i] = new int[cols]; //Cap phat vung nho cho dong
                for (int j = 0; j < cols; j++)
                {
                    a[i][j] = random.Next(100);
                    //Console.WriteLine($"a[{ i}][{ j}] =");
                    //a[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }
        private static void Inmang(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]}\t");
                }
                Console.WriteLine(); //Xuong hang khi het dong
            }
        }
        private static void SortArray(int[][] a)
        {
            foreach (int[] line in a) //Duyet qua tung hang trong a
            {
                for (int i = 0; i < line.Length; i++)
                {
                    for (int j = 0; j < line.Length - 1 - i; j++)
                    {
                        if (line[j] > line[j + 1])
                        {
                            int temp = line[j];
                            line[j] = line[j + 1];
                            line[j + 1] = temp;
                        }
                    }
                }
            }
        }
        static int[][] KhoiTaoMang()
        {
            int[][] b = new int[4][];
            b[0] = new int[] { 1, 1, 1, 1, 1 };
            b[1] = new int[] { 2, 2 };
            b[2] = new int[] { 3, 3, 3, 3 };
            b[3] = new int[] { 4, 4 };
            return b;
        }
        static void InMangTay(int[][] b)
        {
            Console.WriteLine("Mang b:");
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b[i].Length; j++)
                {
                    Console.Write(b[i][j] + " ");
                }
                Console.WriteLine(); 
            }
        }
        public static void BapTap_Manglomchom()
        {
            int[][] a;
            Console.Write("Nhap so dong: "); int rows = int.Parse(Console.ReadLine());
            a = new int[rows][];
            NhapMangTuDong(a);
            Inmang(a);
            Console.WriteLine();

            Console.WriteLine("Mang sau khi sort: ");
            SortArray(a);
            Console.WriteLine();
            Inmang(a);

            //Bai 1
            //int[][] b = KhoiTaoMang();
            //InMangTay(b);
        }
        private static void Main(string[] args)
        {
            //BaiTap_MangHaiChieu();
            BapTap_Manglomchom();
        }
    }
}
