using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhuslikku numbrit ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;
            bool LoopActive = true;

            while (LoopActive)
            {
                Console.WriteLine("Sisesta number:");
                int guessedNumber = Convert.ToInt32(Console.ReadLine());

                if(guessedNumber == cpuNumber)
                {
                    Console.WriteLine("Palju Õnne, võitsid mängu!");
                    LoopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Proovi uuesti.");
                }
            }
            
        }
    }
}
