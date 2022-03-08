using System;
namespace Modul004
{
    public class bus : Vehicle
    {
        
        //defining members
        private int _noOfPassengers;


        //constructor

        public bus(string r, string c, Int32 y, string make, string model, Int32 nop) : base(r, c, y, make, model)
        {
            _noOfPassengers = nop;
        }

        //properties for noOfPassengers

        public Int32 nop
        {
            get
            { return _noOfPassengers; }
            set
            { nop = value; }
        }

        }
    }

