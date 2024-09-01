namespace BuilderInheritance
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var me = Person.New
        .Born(DateTime.UtcNow)
        .WorksAsA("Developer")
        .Called("Javad")
        .Build();
      Console.WriteLine(me);
    }
  }
}