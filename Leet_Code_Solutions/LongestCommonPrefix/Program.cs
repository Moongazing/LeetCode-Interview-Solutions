using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*Write a function to find the longest common prefix string amongst an array of strings.

      If there is no common prefix, return an empty string "".*/
    }
    public string LongestCommonPrefix(string[] strs)
    {
          if (strs.Length == 0) return String.Empty;
          Array.Sort(strs);

          var first = strs[0];
          var last = strs[strs.Length - 1];
          var strbuilder = new StringBuilder();
          for (int i = 0; i < first.Length; i++)
          {
            if (first[i] != last[i])
            {
              break;
            }
            strbuilder.Append(first[i]);
          }

          return strbuilder.ToString();
    }

  }
}
