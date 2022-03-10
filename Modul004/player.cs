using System;
using System.Collections.Generic;
using System.Text;

namespace Modul004
{
    internal class player
    {
        private string _name;
        private int _points;

        public player(string n, int points)
        {
            _name = n;
            points = 0;
        }

        public int point
        {
            get { return _points; }
        }

            public string name
        {
            get { return _name; }
            set { _name = value; }
        } 
     }

    }

