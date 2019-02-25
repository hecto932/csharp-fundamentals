﻿using System;
using CoreSchool.Entities;
using static System.Console;

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
          city: "Bogota"
      );

      school.courses = new Course[] {
        new Course() { Name = "101" },
        new Course() { Name = "201" },
        new Course() { Name = "301" }
      };
      // school.courses = null;
      printSchoolCourses(school);

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

    private static void WhilePrintCourses(Course[] arrayCourses)
    {
      int i = 0;
      while (i < arrayCourses.Length)
      {
        WriteLine(arrayCourses[i]);
        i++;
      }
    }

    private static void DoWhilePrintCourses(Course[] arrayCourses)
    {
      int i = 0;

      do
      {
        WriteLine(arrayCourses[i]);
        i++;
      } while (i < arrayCourses.Length);
    }

    private static void ForPrintCourses(Course[] arrayCourses)
    {
      for (int i = 0; i < arrayCourses.Length; i++)
      {
        WriteLine(arrayCourses[i]);
      }
    }

    private static void ForEachPrintCourses(Course[] arrayCourses)
    {
      foreach (var course in arrayCourses)
      {
          WriteLine(course);
      }
    }
  }
}
