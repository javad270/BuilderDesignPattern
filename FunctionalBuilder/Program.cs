namespace FunctionalBuilder
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var pb = new PersonBuilder();
      var person = pb
        .Called("Dmitri")
        .WorksAsA("Programmer").Build();
    }
  }
}