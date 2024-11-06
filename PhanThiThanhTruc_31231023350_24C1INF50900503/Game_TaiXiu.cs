using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanThiThanhTruc_31231023350_24C1INF50900503
{
    internal class Game_TaiXiu
    {
        static int rollDice()
        {
            Random rnd = new Random();
            int die_1 = rnd.Next(6) + 1;
            int die_2 = rnd.Next(6) + 1;
            int die_3 = rnd.Next(6) + 1;
            int sum_of_dice = die_1 + die_2 + die_3;
            return sum_of_dice;
        }

        static bool playOneRound(ref int userMoney)
        {
            int betAmount;

            Console.Write("Ban cuoc bao nhieu tien?");
            while (!int.TryParse(Console.ReadLine(), out betAmount) || betAmount <= 0 || betAmount > userMoney)
            {
                Console.WriteLine("So tien cuoc khong hop le. Vui long nhap lai");
            }
            int com_dice = rollDice();
            Console.Write("Ban doan Tai hay Xiu <T/X>: ");
            string user_guessing = Console.ReadLine();
            bool isWin = false;

            if (user_guessing.ToUpper().Equals("T"))
            {
                if (com_dice >= 10) // tai
                {
                    Console.WriteLine("Ban thang");
                    userMoney += betAmount; //cong tien
                    isWin = true;
                }
                else
                {
                    Console.WriteLine("Ban thua.");
                    userMoney -= betAmount; // tru tien
                }
            }
            else if (user_guessing.ToUpper().Equals("X"))
            {
                if (com_dice < 10) // xiu
                {
                    Console.WriteLine("Ban thang");
                    userMoney += betAmount;
                    isWin = true;
                }
                else
                {
                    Console.WriteLine("Ban thua");
                    userMoney -= betAmount;
                }
            }
            else
            {
                Console.WriteLine("Vui long chon cho dung");
                return playOneRound(ref userMoney);
            }
            Console.WriteLine($"Ket qua xuc xac la: {com_dice}");
            Console.WriteLine($"So tien hien tai cua ban la: {userMoney}");
            return isWin;
        }

        static void game_engine()
        {
            int userMoney = 1000; //So tien cua nguoi dung
            int playCount = 0; //So lan choi
            int winCount = 0; //So lan thang
            int loseCount = 0; //So lan thua

            Console.WriteLine("Chao mung ban den voi tro choi Tai Xiu!");
            Console.WriteLine($"So tien ban dau cua ban la: {userMoney}");

            do
            {
                bool result = playOneRound(ref userMoney);
                playCount++;

                if (result)
                    winCount++;
                else
                    loseCount++;

                if (userMoney <= 0)
                {
                    Console.WriteLine("Ban da het tien. Tro choi ket thuc!");
                    break;
                }
                Console.Write("Ban co muon choi tiep khong? <C/K>: ");
                string choice = Console.ReadLine();
                if (choice.ToUpper().Equals("K"))
                    break;
            } while (true);

            // Thong ke ket qua sau ket thuc
            Console.WriteLine("\n----- Thong ke -----");
            Console.WriteLine($"So lan choi: {playCount}");
            Console.WriteLine($"So lan thang: {winCount}");
            Console.WriteLine($"So lan thua: {loseCount}");
            Console.WriteLine($"So tien con lai cua ban: {userMoney}");
            Console.WriteLine("--------------------");
            Console.WriteLine("Hen gap lai lan sau!");
        }

        public static void Main()
        {
            game_engine();
        }
    }
}
