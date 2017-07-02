using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileÖvningSpel
{
    class Program
    {
        static void Main(string[] args)
        {
            ////detta gör att applikationen alltid är öppen så man slipper starta på nytt
            bool VisaMeny = true;
            while (VisaMeny)
            {
                VisaMeny = HuvudMeny();
            }
        }
        private static bool HuvudMeny()
        {
            Console.Clear();
            Console.WriteLine("Välj ett alternativ: \n");
            Console.WriteLine("1) Skriv ut nummer");
            Console.WriteLine("2) Gissa-spelet");
            Console.WriteLine("3) Exit");
            string resultat = Console.ReadLine();
            if (resultat == "1")
            {
                SkrivUtNummer();
                return true;
            }
            else if (resultat == "2")
            {
                GissaSpelet();
                return true;
            }
            else if (resultat == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Det nummer som skrivs in av användaren, skrivs ut med ett - mellan varje nummer. 
        /// </summary>
        private static void SkrivUtNummer()
        {
            Console.Clear();
            Console.WriteLine("--{Skriv ut nummer--}");
            Console.Write("Skriv ett nummer: ");
            int resultat = int.Parse(Console.ReadLine());
            int räknare = 1;
            while (räknare < resultat + 1)
            {
                Console.Write(räknare);
                Console.Write("-");
                räknare++;
            }
            Console.ReadLine();
        }

        /// <summary>
        /// ett random nummer väljs ut och användaren gissar fram nummret, antal gissningar skrivs ut. 
        /// </summary>
        private static void GissaSpelet()
        {
            Console.Clear();
            Console.WriteLine("--{Gissa-spelet--}");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);
            int gissningar = 0;
            bool fel = true;

            do
            {
                Console.WriteLine("Gissa ett nummer mellan 1 till 10: ");
                string resultatet = Console.ReadLine();
                gissningar++;
                if (resultatet == randomNumber.ToString())
                    fel = false;

                else
                    Console.WriteLine("Fel!");
            }
            while (fel);
            {
                Console.WriteLine("Du gissade rätt!!  Det tog dig {0} gissningar att gissa rätt.", gissningar);
            }

            Console.ReadLine();

        }
    }
}

