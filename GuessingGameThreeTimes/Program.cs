using System;

namespace GuessingGameThreeTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on 3 katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti.
            //*programm genereerib juhuslikku numbrit ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta number:");
                int guessedNumber = Convert.ToInt32(Console.ReadLine());
                
                if(guessedNumber == cpuNumber)
                {
                    Console.WriteLine("Palju Õnne, võitsid mängu!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale arv, {3-i} katset on jäänud.");
                }
            }
        }
    }
}
