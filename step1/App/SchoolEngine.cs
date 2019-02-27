using System.Collections.Generic;
using CoreSchool.Entities;

namespace CoreSchool
{
  public class SchoolEngine
  {
    public School School { get; set; }


    public SchoolEngine() {
      
    }

    public void initialization () {
      School = new School(
          "Platzi Academy",
          2012,
          TypeSchool.Primary,
          city: "Bogota",
          country: "Colombia"
      );

      School.courses = new List<Course>(){
        new Course() { Name = "101", typeWorkDay=TypeWorkDay.Morning },
        new Course() { Name = "201", typeWorkDay=TypeWorkDay.Morning },
        new Course() { Name = "301", typeWorkDay=TypeWorkDay.Morning },
        new Course() { Name = "401", typeWorkDay=TypeWorkDay.Afternoon },
        new Course() { Name = "501", typeWorkDay=TypeWorkDay.Afternoon },
      };
    }
  }
}

