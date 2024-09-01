using static System.Console;

namespace BuilderFacets
{
  public class Program
  {
    static void Main(string[] args)
    {
      var pb = new PersonBuilder();
      Person person = pb
        .Lives
          .At("Via Spallanzani")
          .In("Roma")
          .WithPostcode("00139")
        .Works
          .At("PTV")
          .AsA("Developer")
          .Earning(30000);

      WriteLine(person);
    }
  }
}
