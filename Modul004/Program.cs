using System;

namespace Modul004
{
    class Program
    {
        static void Main(string[] args)
        {

            // opgave 4.01
            /*
            Coin mønt = new Coin();
            Console.WriteLine(mønt.Throw());
            */

            //opgave 4.02 A
            /*
            Dice terning = new Dice();
            terning.Throw();
            Console.WriteLine(terning.show());
            */


            //opgave 4.02 B

            /*
            Console.WriteLine("Hvor mange gange skal terningen kastes?");

            int a = int.Parse(Console.ReadLine());

            Dice terning1 = new Dice();

            int one = 0;

            int two = 0;

            int three = 0;

            int four = 0;

            int five = 0;

            int six = 0;

            for (int i = 0; i < a; i++) 

            {
                terning1.Throw();

                switch (terning1.show())

                {
                    case 1:
                        one++;
                        break;

                    case 2:
                        two++;
                        break;

                    case 3:
                        three++;
                        break;

                    case 4:
                        four++;
                        break;

                    case 5:
                        five++;
                        break;

                    case 6:
                        six++;
                        break;


                }
            }

            Console.WriteLine($"Du fik {one} antal 1'ere");
            Console.WriteLine($"Du fik {two} antal 2'ere");
            Console.WriteLine($"Du fik {three} antal 3'ere");
            Console.WriteLine($"Du fik {four} antal 4'ere");
            Console.WriteLine($"Du fik {five} antal 5'ere");
            Console.WriteLine($"Du fik {six} antal 6'ere");

            */

            /*
            Vehicle bil = new Vehicle("1234", "Green");

            Console.WriteLine(bil.colour);
            Console.WriteLine(bil.regno);

            Vehicle nybil = new Vehicle("743", "red", 1997, "Lambo", "Aventador");
            Console.WriteLine(nybil.getYear());
            Console.WriteLine(nybil.getMake());
            Console.WriteLine(nybil.getModel());

            Console.Write(bil);
            Console.Write(nybil);
            */


            //Animal fatsvin = new Animal("Hello fatty");
            //fatsvin.speak();

            //Person dude = new Person();
            //dude.Getfullname();

            /*
            Personq robert = new Personq("Robert","Downey","Jr", "2511970355");
            Console.WriteLine(robert.getName());
            Console.WriteLine(robert.getSex());
            Console.WriteLine(robert.getAge());

            */

            //lav torsdag
            /*
            Deck_of_Cards senordub = new Deck_of_Cards();
            Console.WriteLine(senordub);
            */


            bus kenneth = new bus("555", "yellow", 2000, "mercedes", "stor", 23);
            Console.WriteLine(kenneth.nop);













        }
    }
}
