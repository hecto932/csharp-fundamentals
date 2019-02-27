using System;
using System.Collections.Generic;
using CoreSchool.Entities;
using static System.Console;

namespace CoreSchool
{
  class Program
  {
    static void Main(string[] args)
    {
      var schoolEngine = new SchoolEngine();
      schoolEngine.initialization();
      printSchoolCourses(schoolEngine.School);
    }


    private static void printSchoolCourses(School school)
    {
      WriteLine("f===========================");
      WriteLine($"School name: {school.Name}");
      WriteLine("School courses");
      WriteLine("============================");

      if (school != null && school.courses != null) {
        foreach (var course in school.courses)
        {
            WriteLine(course);
        }
      }
    }
  }
}
