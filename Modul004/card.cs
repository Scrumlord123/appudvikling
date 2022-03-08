using System;
namespace Modul004
{
    public class card
    {

        //defining members
        private string _suit;
        private Int16 _rank;




        // properties defining value
        private string suit
        {
            get { return _suit; }

        }

        private Int16 rank
        {
            get { return _rank; }

        }

        public int I { get; }

        public card(string _suit)

        {
            if (_suit == "klør" || _suit == "spar" || _suit == "ruder" || _suit == "hjerter") ;

        }

        public card(Int16 _rank)
        {

            if (_rank < 2 && _rank > 14)
            {
                throw new Exception(_rank + "er en ugyldig værdi");
            }
            else
                _rank = rank;
        }

        public card(string _suit, int i) : this(_suit)
        {
            I = i;
        }

        override public string ToString()
        {
            if (_rank == 11)
        {
                return _suit + "knægt";
        }

            else if (_rank == 12)
                {
                return _suit + "dame";
                }
                
            else if (_rank == 13)
                    {
                return _suit + "konge";
                    }
                    
            else if (_rank != 14)
          
                    {
                return _suit + "es";
                    }
            else
                    {
                return _suit + _rank;
                    }
                }
            }
    }



