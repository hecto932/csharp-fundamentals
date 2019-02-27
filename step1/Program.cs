using System;
using System.Collections.Generic;
using CodeSchool.Util;
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
      Printer.DrawTitle("Welcome to the School");

      printSchoolCourses(schoolEngine.School);
    }


    private static void printSchoolCourses(School school)
    {
      Printer.DrawTitle(school.Name);

      if (school != null && school.courses != null) {
        foreach (var course in school.courses)
        {
            WriteLine(course);
        }
      }
    }
  }
}
