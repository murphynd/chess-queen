using System;

namespace asdf
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter Queen X-Coordinate:");
      string qXCoor = Console.ReadLine();
      Console.WriteLine("Enter Queen Y-Coordinate:");
      string qYCoor = Console.ReadLine();
      Console.WriteLine("Enter Enemy Chess Piece X-Coordinate:");
      string eXCoor = Console.ReadLine();
      Console.WriteLine("Enter Enemy Chess Piece Y-Coordinate:");
      string eYCoor = Console.ReadLine();

      Queen queenPos = new Queen(qXCoor,qYCoor);
      
    }
  }
  public class Queen
  {
    public bool Stomp(string eXCoor, string eYCoor)
    {
      if (qYCoor == eYCoor || qXCoor == eYCoor)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}