namespace CoreSchool.Entities
{
  class School {
    string name;
    public string Name {
      get { return "Copia: " + name; }
      set { name = value.ToUpper(); }
    }

    public int yearFoundation { get;set; }

    public string country { get; set; }
    public string city { get; set; }

    public TypeSchool type { get; set; }

    // Igualacion por Tuplas, clasico en lenguajes funcionales
    public School(string name, int year) => (Name, yearFoundation) = (name, year);

    public School(
      string name, 
      int yearFoundation, 
      TypeSchool type, 
      string country="", 
      string city=""
    )
    {
      (Name, yearFoundation, type) = (name, yearFoundation, type);
      this.country = country;
      this.city = city;
    }

    public override string ToString() 
    {
      return $"Name: \"{Name}\", TypeSchool: {type} {System.Environment.NewLine}Country: {country}, City: {city}";
    }
  }
}