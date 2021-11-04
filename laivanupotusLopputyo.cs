using System;

public class Class1
{
    public static int peliX;
  public static int peliY;
  public static void Main()
  {
    int x, y,botX,botY, syoteX, syoteY;
    Random newRandom = new Random();

    botX = newRandom.Next(1, 5);
    botY = newRandom.Next(1, 5);
    start();

    //voidissa kysytään laivan kordinaatit
    void start()
    {
      //kysytään kordinaatit
      Console.WriteLine("Anna laivan X kordinaatti, Pelilauta on 5 x 5");
      syoteX = int.Parse(Console.ReadLine());
      if (syoteX < 6 && syoteX > 0)
      {
        x = syoteX;
      }
      else
      {
        Console.WriteLine("Pelilaudan koko on 5 x 5, anna pienempi arvo");
        syoteX = int.Parse(Console.ReadLine());
        start();
      }

      Console.WriteLine(" ");
      Console.WriteLine("Anna laivan Y kordinaatti");
      syoteY = int.Parse(Console.ReadLine());

      if (syoteY < 6 && syoteY > 0)
      {
        y = syoteY;
        peli();

      }
      else
      {
        Console.WriteLine("Pelilaudan koko on 5 x 5, anna pienempi arvo");
        syoteY = int.Parse(Console.ReadLine());
        start();
      }
    }
     //botin tulitus
    void botTulitus()
    {
      int newBotX, newBotY;
      Random randomEl = new Random();
      newBotX = randomEl.Next(1, 5);
      newBotY = randomEl.Next(1, 5);

      if(newBotX==x && newBotY == y)
      {
        Console.WriteLine("Laivaasi osui, Hävisit pelin");
      }
      else
      {
        Console.WriteLine(" ");
        Console.WriteLine("Vastustaja ei osunut, sinun vuorosi");
        peli();
      }

    }

    //pelaajan tulitus
    void peli()
    {
      if (peliX == botX && peliY == botY)
      {
        Console.WriteLine("Voitit pelin");
      }
      else {
       

        int tryY,tryX;
        Console.WriteLine("Anna X kordinaatti jota tulitetaan");
        tryX = int.Parse(Console.ReadLine());

        if (tryX < 6 && tryX > 0)
        {
          peliX = tryX;
        }
        else
        {
          Console.WriteLine("Pelilaudan koko on 5 x 5, anna pienempi arvo");
          peli();
        }

        Console.WriteLine(" ");
        Console.WriteLine("Anna Y kordinaatti jota tulitetaan");
        tryY = int.Parse(Console.ReadLine());

        if (tryY < 6 && tryY > 0)
        {
          peliY = tryY;
        

        }
        else
        {
         Console.WriteLine("Pelilaudan koko on 5 x 5, anna pienempi arvo");
          peli();
        }

          Console.WriteLine("Ei osumia");
          botTulitus();

      }


    }
  
  }

}
