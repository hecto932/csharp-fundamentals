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
          city: "Bogota"
      );

      var arrayCourses = new Course[3];

      arrayCourses[0] = new Course()
      {
        Name = "101"
      };

      arrayCourses[1] = new Course()
      {
        Name = "201"
      };

      arrayCourses[2] = new Course()
      {
        Name = "301"
      };

      Console.WriteLine(school);
      System.Console.WriteLine("=================================");
      WhilePrintCourses(arrayCourses);
      Console.WriteLine();
      DoWhilePrintCourses(arrayCourses);
      Console.WriteLine();
      ForPrintCourses(arrayCourses);
      Console.WriteLine();
      ForEachPrintCourses(arrayCourses);

    }

    private static void WhilePrintCourses(Course[] arrayCourses)
    {
      int i = 0;
      while (i < arrayCourses.Length)
      {
        Console.WriteLine(arrayCourses[i]);
        i++;
      }
    }

    private static void DoWhilePrintCourses(Course[] arrayCourses)
    {
      int i = 0;

      do
      {
        Console.WriteLine(arrayCourses[i]);
        i++;
      } while (i < arrayCourses.Length);
    }

    private static void ForPrintCourses(Course[] arrayCourses)
    {
      for (int i = 0; i < arrayCourses.Length; i++)
      {
        Console.WriteLine(arrayCourses[i]);
      }
    }

    private static void ForEachPrintCourses(Course[] arrayCourses)
    {
      foreach (var course in arrayCourses)
      {
          Console.WriteLine(course);
      }
    }
  }
}
