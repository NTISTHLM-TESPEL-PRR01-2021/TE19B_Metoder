using System;

namespace Metoder
{
  class Program
  {
    static void Main(string[] args)
    {

      SayThings();
      //Cursed(0);

      Console.ReadLine();

    }

    static void Cursed(int t)
    {
      Console.WriteLine("CURSED: " + t);
      Cursed(t+1);
    }

    static void DescribeLivingRoom()
    {
      Console.WriteLine("Vardagsrummet är stort och mörkt.");
      Console.WriteLine("Vardagsrummet är stort och mörkt.");
      Console.WriteLine("Vardagsrummet är stort och mörkt.");
      Console.WriteLine("Vardagsrummet är stort och mörkt.");
      Console.WriteLine("Vardagsrummet är stort och mörkt.");
      Console.WriteLine("Vardagsrummet är stort och mörkt.");
    }

    static void SayThings() {
      DescribeLivingRoom();
    }


  }
}
