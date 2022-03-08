using System;
namespace Modul004
{
    public class Vehicle
    {
        
             // defining members
    public string _regno, _colour;
        protected Int32 _year;
        protected string _make, _model;
        private string v;

        // a constructor
        public Vehicle(string r, string c)
        {
            _regno = r;
            _colour = c;
        }
        // another constructor
        public Vehicle(string r, string c, Int32 y, string make, string model)
        {
            _regno = r;
            _colour = c;
            _year = y;
            _make = make;
            _model = model;
        }

        public Vehicle()
        {
        }

        public Vehicle(string r, string c, string v) : this(r, c)
        {
            this.v = v;
        }

        // properties to get and set regno
        public string regno
        {
            get
            { return _regno; }
            set
            {
                _regno = value;
            }
        }
        // properties to get and set colour
        public string colour
        {
            get
            {
                return _colour;
            }
            set
            {
                _colour = value;
            }
        }
        // a method to get year
        public Int32 getYear()
        {
            return _year;
        }
        // a method to get make
        public string getMake()
        {
            return _make;
        }
        // a method to get model
        public string getModel()
        {
            return _model;
        }
    }
}
