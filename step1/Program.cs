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

            var course1 = new Course() 
            {
                Name="101"
            };

            var course2 = new Course() 
            {
                Name="201"
            };

            var course3 = new Course() 
            {
                Name="301"
            };

            Console.WriteLine(school);
            System.Console.WriteLine("=================================");
            Console.WriteLine(course1);
            Console.WriteLine(course2);
            Console.WriteLine(course3);
        }
    }
}
