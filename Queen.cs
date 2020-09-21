using System;

namespace asdfasdf
{
  public class Queen
  {
    private string _xCoor;
    private string _yCoor;

    public Queen(string qXInput, string qYInput)
    {
      _xCoor = qXInput;
      _yCoor = qYInput;
    }

    public string[] x = {"1","2","3","4","5","6","7","8"};
    public string[] y = {"a","b","c","d","e","f","g","h"};

    public bool Stomp(string eX,string eY)
    {
      // return _xCoor == eYCoor 
      //       || _yCoor == eYCoor
      //       || CheckDiagonal();
      //   return true;
      // }
      if (_xCoor == eX || _yCoor == eY)
      {
        return true;
      }
      else if
      {
        int temp = Array.IndexOf (x, _xCoor);
        int temp2 = Array.IndexOf (y, _yCoor);
        for (int i=0; i<8; i++)
        {
          temp++;
          temp2++;
          if (x[temp] == _xCoor && y[temp2] == _yCoor)
          {
            return true;
          }
        }
        for (int i=0; i<16; i++)
        {
          temp--;
          temp2--;
          if (x[temp] == _xCoor && y[temp2] == _yCoor)
          {
            return true;
          }
        }
      }
      else
      {
        return false;
      }
    }
  }
  //   private bool CheckDiagonal()
  //       {
  //           return CheckAllDiags(x => x + 1, y => y - 1)
  //                  || CheckAllDiags(x => x + 1, y => y + 1)
  //                  || CheckAllDiags(x => x - 1, y => y - 1)
  //                  || CheckAllDiags(x => x - 1, y => y + 1);
  // }
}