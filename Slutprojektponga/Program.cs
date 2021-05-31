using System;
using System.Collections.Generic;


namespace Slutprojektponga
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> rum = new List<string>() { "rum1", "rum2", };


            Console.WriteLine("(läskig kosmisk röst) Yoooooo vad heter du");
            string spelare1 = Console.ReadLine();

            if (spelare1 == "Lukas")
            {

                Console.WriteLine("(Kosmisk röst)Coolt namn jag tycker Lukas låter som en cool person. Bara för att du har så coolt namn får du denhär Guldiga Scaren från det populära battle royal spelet Fortnite battle royal");
            }
            else if (spelare1 == "Joel")
            {
                Console.WriteLine("(Kosmisk röst)Wow cringe namn. Lukas är ett coolare namn. Bara för att du är cringe får du denhär tråkiga pinnen.Jag sparar mitt svärd för någon annan.");
            }
            else
            {
                Console.WriteLine("(Kosmisk röst)Skumt namn men visst.Det är farligt att gå ensam dock när jag tänker efter.Så ta dehär svärdet.");
            }

            Console.WriteLine("(Kosmisk röst) Oj här var de visst 2 dörrar. Vilket rum vill du gå in i rum1 eller rum2?");

            string rumInput = Console.ReadLine();

            if (rumInput == rum[0])
            {
                episkbossfight();
            }
            else if (rumInput == rum[1])
            {
                Console.WriteLine("Oj du gick in i fel rum och dog gud vad sorligt.");
            }
            else
            {
                Console.WriteLine("Dedär var inte svaret på frågan din knasboll.");
            }



            Console.ReadLine();
        }

        static void episkbossfight()
        {

            int spelare1hp = 100;
            int bosshp = 100;
            Random generator = new Random();


            while (spelare1hp >= 0 && bosshp >= 0)
            {

                int spelarskada = generator.Next(1, 20);
                int bosskada = generator.Next(1, 20);

                spelare1hp = spelare1hp - bosskada;
                bosshp = bosshp - spelarskada;

                Console.WriteLine("Du har nu " + (spelare1hp) + " hp");
                Console.WriteLine("Mr Boss har nu " + (bosshp) + " hp");
                Console.ReadLine();
            }

            if (spelare1hp < 0 && bosshp < 0)
            {
                Console.WriteLine("Oj sedär båda dog");
                Console.ReadLine();
            }
            else if (spelare1hp >= 0)
            {
                Console.WriteLine("Vilken överaskning du vann matchen");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" Mr boss vann. shit vad dålig du är.");
                Console.ReadLine();
            }
        }
    }
}

