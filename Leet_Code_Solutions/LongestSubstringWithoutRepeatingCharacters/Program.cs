using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstringWithoutRepeatingCharacters
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*Given a string s, find the length of the longest substring without repeating characters.*/
    }
    public int LengthOfLongestSubstring(string str)
    {
          int curSize = 0;
          int maxSize = 0;
          int end = 0;
          bool[] present = new bool[256];


          for (int start = 0; start < str.Length; start++)
          {
            end = start;
            while (end < str.Length)
            {
              if (!present[str[end]] && end < str.Length)
              {
                curSize++;
                present[str[end]] = true;
                end++;
              }
              else
                break;
            }
            if (curSize > maxSize)
            {
              maxSize = curSize;
            }
            //reset current size and the set all letter to false
            curSize = 0;
            for (int i = 0; i < present.Length; i++)
              present[i] = false;
          }

          return maxSize;
    }
  }
}
