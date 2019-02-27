using static System.Console;

namespace CodeSchool.Util
{
  // A static class does not create new instances 
  public static class Printer {
    public static void DrawLine (int size = 10) 
    {
      var line = "".PadLeft(size, '=');
      WriteLine(line);
    }

    public static void DrawTitle (string title) 
    {
      DrawLine(title.Length + 4);
      WriteLine($"| {title} |");
      DrawLine(title.Length + 4);
      WriteLine();
    }
  }
}