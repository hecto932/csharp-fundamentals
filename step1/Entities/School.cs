using System.Collections.Generic;

namespace CoreSchool.Entities
{
  public class School
  {
    string name;
    public string Name
    {
      get { return name; }
      set { name = value.ToUpper(); }
    }

    public int YearFundation { get; set; }

    public string Country { get; set; }
    public string City { get; set; }

    public TypeSchool TypeSchool { get; set; }

    public List<Course> Courses { get; set; }

    // Igualacion por Tuplas, clasico en lenguajes funcionales
    public School(string name, int year) => (Name, YearFundation) = (name, year);


    public School(string name, int year,
                   TypeSchool typeSchool,
                   string country = "", string city = "") : base()
    {
      (Name, YearFundation) = (name, year);
      Country = country;
      City = City;
    }

    public override string ToString()
    {
      return $"Name: \"{Name}\", TypeSchool: {TypeSchool} {System.Environment.NewLine}Country: {Country}, City: {City}";
    }
  }
}