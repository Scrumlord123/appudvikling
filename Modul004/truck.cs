using System;
namespace Modul004
{
    public class truck : Vehicle
    {
       //defining members
        private int _maxLoad;
        private int _totalWeight;

        //contructor

        public truck (string r, string c, Int32 y, string make, string model, Int32 ml, Int32 tw) : base(r, c, y, make, model)
        {
            _maxLoad = ml;
            _totalWeight = tw;
        }

        //properties to get maxLoad

        public Int32 ml
        {
            get
            { return _maxLoad; }
            set
            { ml = value; }
        } 

        //properties to get totalWeight
        public Int32 tw
        {
            get
            { return _totalWeight; }
            set
            { tw = value; }
        }

        }
    }

