using System;
using CoreSchool.Entities;

namespace step1
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School(
                "Platzi Academy", 
                2012, 
                TypeSchool.Preschool,
                city:"Bogota"
            );
            Console.WriteLine(school);
        }
    }
}
