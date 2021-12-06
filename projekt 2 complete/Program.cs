using System;
using System.IO;

namespace projekuppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] låtar = new string[20];

            for (int i = 0; i < låtar.Length; i++)
            {
                låtar[i] = "tom";
            }

            string menyval = "0";
            while (menyval != "5")
            {

                Console.WriteLine("välj ett av följande alternativ");
                Console.WriteLine("1. Visa topplistan");
                Console.WriteLine("2. Ändra på hela topplistan");
                Console.WriteLine("3. Ändra på en Låt i topplistan");
                Console.WriteLine("4. Söka efter ett låtnamn");
                Console.WriteLine("5. Avsluta programmet");

                menyval = Console.ReadLine();

                switch (menyval)
                {
                    case "1":
                        Console.WriteLine($"här är alla låtar som finns inskrivna ");
                        for (int i = 0; i < låtar.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {låtar[i]} ");
                        }
                        break;


                    case "2":
                        for (int i = 0; i < låtar.Length; i++)
                        {
                            Console.WriteLine($"skriv in låt number {i + 1}");
                            låtar[i] = Console.ReadLine();

                        }

                        break;



                    case "3":
                        {
                            Console.WriteLine("Ändra en låt i din lista. Välj ett nummer i din topplista.");
                            int LåtVal = int.Parse(Console.ReadLine());
                            Console.WriteLine("Vad vill du ändra låten till?");
                            låtar[LåtVal - 1] = Console.ReadLine();
                        }
                        break;

                    case "4":
                        Console.WriteLine("Sök på ett ord från en låt.");
                        string Sök = Console.ReadLine();
                        string söksmå = Sök.ToLower();

                        int Räknare = 0;

                        for (int i = 0; i < låtar.Length; i++)
                        {
                            string låtsmå = låtar[i].ToLower();

                            if (låtsmå.Contains(söksmå))
                            {
                                Console.WriteLine($"{söksmå} finns i låt nummer {i + 1}");

                                Räknare++;
                            }

                        }

                        if (Räknare == 0)
                        {
                            Console.WriteLine("Ditt ord fanns inte med i en av låtarna");

                        }

                        break;

                    case "5":
                        break;
                }
                Console.WriteLine("");
            }






        }
    }
}