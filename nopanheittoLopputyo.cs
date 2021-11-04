using System;

public class Class1
{
  public static int total;
	public static void Main()
	{
    Random rnd = new Random();
    int noppa = rnd.Next(1, 7);
    
    int noppa1;
    int noppa2;
      for (int i = 0; i < 5; i++)
      {
      Console.WriteLine(" ");

      Console.WriteLine("Heitä noppaa painamalla näppäintä");
      Console.ReadKey();
      noppa1 = rnd.Next(1, 7);
      noppa2 = rnd.Next(1, 7);
      total += noppa1;
      total += noppa2;
      Console.WriteLine("Nopan1 silmäluku: " + noppa1);
      Console.WriteLine("Nopan2 silmäluku: " + noppa2);
      
      }
    Console.WriteLine(" ");
    Console.WriteLine("Kaikkien heittojen summa: "+total);

  }
}
