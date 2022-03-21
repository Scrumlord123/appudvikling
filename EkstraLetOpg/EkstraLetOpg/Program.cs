

using System;
namespace EkstraLetOpg
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Indtast antal minutter");

            int a = int.Parse(Console.ReadLine());
        }
        Convert
        public int _minutter;

        public Program(int m)
        {
            _minutter = m;
        }

        public int minutter
        {
            get { return minutter; }
            set { minutter = value / 60; }
        }
    }
    public void ShowMinutes()
      Console.WriteLine($"Dette er {minutter} antal sekunder");
       
    }



   
      
    

    

