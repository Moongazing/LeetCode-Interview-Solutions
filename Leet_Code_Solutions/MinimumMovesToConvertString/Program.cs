using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumMovesToConvertString
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*You are given a string s consisting of n characters which are either 'X' or 'O'.

      A move is defined as selecting three consecutive characters of s and converting them to 'O'. Note that if a move is applied to the character 'O', it will stay the same.

      Return the minimum number of moves required so that all the characters of s are converted to 'O'.*/
    }
    public int MinimumMoves(string s)
    {
        int res = 0;
        if (s.Length >= 3 && s.Length <= 1000)
        {
          for (int i = 0; i < s.Length; i++)
          {
            // whenever we see X
            if (s[i] == 'X')
            {
              // make a move by assuming converted all 3 char to 'O'
              res++;
              i += 2;
            }
          }

        }
        return res;
    }


  }
}
