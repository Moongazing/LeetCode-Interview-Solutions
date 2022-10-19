using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateParentheses
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.*/
    }
    public IList<string> GenerateParenthesis(int n)
    {

      string s = "";
      generater(n, n, s);
      List<string> ans = new List<string>();
      foreach (var t in result)
      {
        ans.Add(t);
      }
      ans.Reverse();
      return ans;
    }
    Stack<string> result = new Stack<string>();
    void generater(int l, int r, string s)
    {
      if (l == 0 && r == 0)
      {
        result.Push(s);
      }
      if (l > 0)
      {
        generater(l - 1, r, s + '(');
      }
      if (r > 0 && l < r)
      {
        generater(l, r - 1, s + ')');
      }
    }
  }
}
