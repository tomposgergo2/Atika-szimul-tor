﻿namespace PLC
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            int[] statok = { 1, 2, 3, 4, };
            int kedv = 100;
            int aksi = 100;
            int aksiadat = 0;
            int kedvadat = 0;

            Console.WriteLine("Megérkeztél a PLC órára! \n");

            Random random = new Random();
            int asitas = random.Next(1, 11);

            if (asitas == 1 || asitas == 2 || asitas == 3)
            {
                Console.WriteLine("Flóri: A tiszteletlen paraszt!\nNem említettem urak, hogy ezt nem bírom elviselni?\nBeleásít a pofámba, konkrétan leláttam a gyomráig.");
                Console.WriteLine("Csizma: Jó nagy paraszt vagy Atika...");
                Console.WriteLine("Atika: Kussoljmá");
                Console.WriteLine("*Flórinak tetszik Atika flegmasága*");
                Console.WriteLine("Flóri: Na jolvan urak mára ennyit terveztem, nem akarok év vége előtt izmozni. A viszont látásra!");

            }


            if (asitas == 10)
            {
                Console.WriteLine("Flóri: A tiszteletlen paraszt!\nNem említettem urak, hogy ezt nem bírom elviselni?\nBeleásít a pofámba, konkrétan leláttam a gyomráig.");
                Console.WriteLine("Atika: *Pislog*");
                Console.WriteLine("Atika: *Pislog mégegyet (ritka)");
                Console.WriteLine("Egész osztály: Odafigyeljen tanárúúúr!!! Atika pislogott, ráadásul kettőt!!");

            }

            if (asitas == 4 || asitas == 5 || asitas == 6 || asitas == 7 || asitas == 8 || asitas == 9)
            {

                Console.WriteLine("Nem nedves a pince, nem boldog...\n");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("*Atika nagyon fél a tanárúrtól, ezért egész órán behúzza a nyakát és csendben dolgozik egész órán...");

                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\n   ");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("--> Milyen pólus tartozik a színhez?");

                string valasz1 = Console.ReadLine();

                Console.WriteLine();


                if (valasz1 == "+" || valasz1 == "pozitív" || valasz1 == "pozitiv")
                {
                    Console.WriteLine("Ügyes vagy kismackó, most pislogj egyet!");
                    kedv += 20;
                }

                else if (valasz1 == "-" || valasz1 == "negatív" || valasz1 == "negativ")
                {
                    Console.WriteLine("Majdnem... 50-50 volt, maradj inkább a tiktoknál!");
                    Console.WriteLine("Na de előtte van mégegy esélyed...");

                    kedv -= 10;
                    aksi -= 10;

                    aksiadat += 10;
                    kedvadat += 10;
                }

                else
                {
                    Console.WriteLine("Jóóbutavagy, maradj inkább a tiktoknál");
                    Console.WriteLine("Na de előtte van mégegy esélyed...");

                    kedv -= 10;
                    aksi -= 10;

                    aksiadat += 10;
                    kedvadat += 10;
                }

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n   ");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("--> Milyen pólus tartozik a színhez?");


                Console.BackgroundColor = ConsoleColor.Black;

                string valasz2 = Console.ReadLine();

                Console.WriteLine();

                if (valasz2 == "-" || valasz2 == "negatív" || valasz2 == "negativ")
                {
                    Console.WriteLine("Ügyes vagy kismackó, most pislogj egyet!");
                    kedv += 20;
                }

                else if (valasz2 == "+" || valasz2 == "pozitív" || valasz2 == "pozitiv")
                {
                    Console.WriteLine("Ez sem jött össze... Most már tényleg maradj inkább a tiktoknál!");

                    kedv -= 10;
                    aksi -= 10;

                    aksiadat += 10;
                    kedvadat += 10;
                }
                else
                {
                    Console.WriteLine("Jóóbutavagy, most már tényleg maradj inkább a tiktoknál");

                    kedv -= 10;
                    aksi -= 10;

                    aksiadat += 10;
                    kedvadat += 10;
                }

                Console.WriteLine("\nAz órának vége !\n");

                if (kedvadat == 10)
                {
                    Console.WriteLine($"{kedvadat} kedvpontot veszítettél :(");
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("| | |\n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (kedvadat == 20)
                {
                    Console.WriteLine($"{kedvadat} kedvpontot veszítettél :(");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("| | | | |");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (aksiadat == 10)
                {
                    Console.WriteLine();
                    Console.WriteLine($"\n{aksiadat}%-ot merült a telefonod :(");
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("| | |");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (aksiadat == 20)
                {
                    Console.WriteLine() ;
                    Console.WriteLine($"\n{aksiadat}%-ot merült a telefonod :(");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("| | | | |\n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;



                }

            }
        }
    }
}