using System;
namespace Modul004
{
    public class Personq
    {


        // Defining members
        private string _firstname;
        private string _middlename;
        private string _lastname;
        private string _cprno;



        // a constructor
        public Personq(string f, string m, string l, string cpn)
        {
            firstname = f;
            middlename = m;
            lastname = l;
            cprno = cpn;


        }
        // properties defining sound
        protected string firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        protected string middlename
        {
            get { return _middlename; }
            set { _middlename = value; }
        }
        protected string lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        protected string cprno
        {
            get { return _cprno; }
            set { _cprno = value; }
        }


        //Method "hvad din property gør"
        public void getName()
        {
            Console.WriteLine($"{firstname} {middlename} {lastname} {cprno}");
        }



        // how to get sex
        public string getSex()
        {
            string gender;

            {
                if ((int.Parse(_cprno.Substring(9)) % 2) == 0)

                {
                    gender = "female";
                }
                else
                {
                    gender = "male";
                }
                return gender;
            }

        }

     

        public Byte getAge()

           
        {
            Byte age = byte.Parse(_cprno.Substring(4, 2));
                {
                return age;
                }

        }
    }
}
      


