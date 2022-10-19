using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

      An input string is valid if:

          Open brackets must be closed by the same type of brackets.
          Open brackets must be closed in the correct order.
          Every close bracket has a corresponding open bracket of the same type.
      */
    }
    public bool IsValid(string s)
    {
      Stack<char> ch = new Stack<char>();
      foreach (var item in s.ToCharArray())
        if (item == '(')
          ch.Push(')');
        else if (item == '<')
          ch.Push('>');
        else if (item == '[')
          ch.Push(']');
        else if (item == '{')
          ch.Push('}');
        else if (ch.Count == 0 || ch.Pop() != item)
          return false;

      return ch.Count == 0;
    }
  }
}
