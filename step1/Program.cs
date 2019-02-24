using System;
using CoreSchool.Entities;

namespace step1
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School("Platzi Academy", 2012);
            school.country = "Colombia";
            school.city = "Bogota";
            school.type = TypeSchool.Primary;
            Console.WriteLine(school);
        }
    }
}
