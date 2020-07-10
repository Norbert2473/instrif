using System;

namespace instrif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj cene: ");
            int cena = int.Parse(Console.ReadLine());
            if (cena > 400)
            {
                cena -= 80;
                Console.WriteLine("rabat to 80");


            }
            else
            {
                if (cena > 200)
                {
                    cena -= 35;
                    Console.WriteLine("rabat 35");
                }
                else
                {
                    if (cena > 100)
                    {
                        cena -= 15;
                        Console.WriteLine("rabat 15");

                    }
                    else { Console.WriteLine("brak rabatu"); }
                }
               

            }

            Console.WriteLine("cena koncowa: ");
            Console.WriteLine(cena);
        }

    }
}
