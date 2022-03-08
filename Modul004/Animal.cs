using System;
namespace Modul004
{
    public class Animal
    {
        // Defining members
        public string _sound;

        // a constructor
        public Animal(string s)
        {
            sound = s;
        }
        // properties defining sound
        public string sound
        {
            get { return _sound; }
            set { _sound = value; }
        }

        //Method "hvad din property gør"
        public void speak()
        {
            Console.WriteLine($"the dog says {sound}");
        }

    }
}

