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

    // public School(string name, int yearFoundation) {
    //   this.name = name;
    //   this.yearFoundation = yearFoundation;
    // }

    // Igualacion por Tuplas, clasico en lenguajes funcionales
    public School(string name, int year) => (Name, yearFoundation) = (name, year);

    public override string ToString() 
    {
      return $"Name: {Name}, TypeSchool: {type} \nCountry: {country}, City: {city}";
    }
  }
}