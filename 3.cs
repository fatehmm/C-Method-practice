using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Nece dene ad daxil etmek istediyinizi yazin");
            string adSayiStr = Console.ReadLine();
            int adSayi = Convert.ToInt32(adSayiStr);
            string[] names = new string[adSayi];
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Adi daxil edin");
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("Hansi adi yoxlamaq istediyinizi yazin");
            string wantedName = Console.ReadLine();

            bool checkName = CheckName(names, wantedName);
            Console.WriteLine(checkName);
            
        }
        static bool CheckName(string[] adlar, string ad)
        {
            bool check = false;
            for (int i = 0; i < adlar.Length; i++)
            {
                if (ad == adlar[i])
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        

    }
}
