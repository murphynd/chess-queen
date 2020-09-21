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

    public bool Stomp()
    {
      return _xCoor == eYCoor 
            || _yCoor == eYCoor
      {
        return true;
      }
      else
      {
        int temp = Array.IndexOf (x, _xCoor);
        
      }
      else
      {
        return false;
      }
    }
    private bool CheckDiagonal()
        {
            return CheckAllDiags(x => x + 1, y => y - 1)
                   || CheckAllDiags(x => x + 1, y => y + 1)
                   || CheckAllDiags(x => x - 1, y => y - 1)
                   || CheckAllDiags(x => x - 1, y => y + 1);
  }
}