using System;

namespace CoreEscuela
{
    class School 
    {
        public string name;
        public string address;
        public int yearFundation;
        public string ceo;

        public void Ring() 
        {
            // Todo
            Console.Beep(2000, 3000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var mySchool = new School();
            mySchool.name = "Platzi Academy";
            mySchool.address = "Cr 9 calle 72, Bogota";
            mySchool.yearFundation = 2012;
            
            Console.WriteLine("Timbrando");
            mySchool.Ring();

            // Console.WriteLine("Hello World!");
        }
    }
}
