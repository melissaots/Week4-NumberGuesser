using System;

namespace PINInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi;
            //programm võrdelb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast"!;
            //kui sisestatud PIN-kod on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti";
            //katsete arv on piiramatu.

            bool LoopActive = true; //boolen --> true/false
            int i = 0;

            while(LoopActive)
            {
                Console.WriteLine("sisesta PIN:"); //cw+touble TAB
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    LoopActive = false;
                }
                else
                {
                    i++; 
                    Console.WriteLine("Vale PIN. Proovi uuesti!");
                    Console.WriteLine($"Oled vale PIN-kood {i} korda sisestanud.");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
