using System;
namespace Modul004
{
    public class car : Vehicle
    {
        //defining members
        public int _noOfSeats;
        public int _noOfDoors;


        //constructor 
        public car(string r, string c, Int32 y, string make, string model, Int32 nos, Int32 nod) : base(r, c, y, make, model)
        {
            _noOfSeats = nos;
            _noOfDoors = nod;
        }

        //properties to get and set noOfSeats
        public Int32 nos
        {
            get
            { return _noOfSeats; }
            set
            {
                nos = value;
            }
        }


        //properties to get and set noOfDoors
        public Int32 nod
        {
            get
            { return _noOfDoors; }
            set
            {
                nod = value;
            }
        }

        public Int32 getDoors()
        {
            return nod;
        }

    }

}
    
        

    
    

