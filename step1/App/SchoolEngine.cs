using System;
using System.Collections.Generic;
using System.Linq;
using CoreSchool.Entities;

namespace CoreSchool
{
  public class SchoolEngine
  {
    public School School { get; set; }


    public SchoolEngine()
    {

    }

    public void initialization()
    {
      School = new School(
          "Platzi Academy",
          2012,
          TypeSchool.Primary,
          city: "Bogota",
          country: "Colombia"
      );

      uploadCourses();
      uploadSubjects();

      foreach (var course in School.courses)
      {
        course.Students.AddRange(uploadStudents());
      }
      // uploadEvaluations();
    }

    private void uploadEvaluations()
    {
      throw new NotImplementedException();
    }

    private void uploadSubjects()
    {
      foreach (var course in School.courses)
      {
        List<Subject> listSubjects = new List<Subject>(){
          new Subject{Name="Matematicas"},
          new Subject{Name="Educacion Fisica"},
          new Subject{Name="Castellano"},
          new Subject{Name="Ciencias Naturales"}
        };
        course.Subjects.AddRange(listSubjects);
      }
    }

    private IEnumerable<Student> uploadStudents()
    {
      string[] name = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
      string[] lastname = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
      string[] secondName = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

      var listStudents =  from n1 in name
                          from n2 in secondName
                          from l1 in lastname
                          select new Student{ Name=$"{n1} {n2} {l1}"};

      return listStudents;
    }

    public void uploadCourses() => School.courses = new List<Course>(){
        new Course() { Name = "101", typeWorkDay=TypeWorkDay.Morning },
        new Course() { Name = "201", typeWorkDay=TypeWorkDay.Morning },
        new Course() { Name = "301", typeWorkDay=TypeWorkDay.Morning },
        new Course() { Name = "401", typeWorkDay=TypeWorkDay.Afternoon },
        new Course() { Name = "501", typeWorkDay=TypeWorkDay.Afternoon },
      };
  }
}

