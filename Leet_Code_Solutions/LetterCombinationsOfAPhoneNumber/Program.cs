using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCombinationsOfAPhoneNumber
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.

       A mapping of digits to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.*/
    }
    public IList<string> LetterCombinations(string digits)
    {
          List<String> result = new List<String>();
          if (String.IsNullOrEmpty(digits))
          {
            return result;
            throw new ArgumentNullException(nameof(digits));
          }
          Dictionary<Char, Char[]> lettersMap = new Dictionary<Char, char[]>();
          lettersMap.Add('1', null);
          lettersMap.Add('2', new[] { 'a', 'b', 'c' });
          lettersMap.Add('3', new[] { 'd', 'e', 'f' });
          lettersMap.Add('4', new[] { 'g', 'h', 'i' });
          lettersMap.Add('5', new[] { 'j', 'k', 'l' });
          lettersMap.Add('6', new[] { 'm', 'n', 'o' });
          lettersMap.Add('7', new[] { 'p', 'q', 'r', 's' });
          lettersMap.Add('8', new[] { 't', 'u', 'v' });
          lettersMap.Add('9', new[] { 'w', 'x', 'y', 'z' });
          lettersMap.Add('0', null);
          StringBuilder sb = new StringBuilder();
          int pos = 0;
          LetterCombinationsFunction(digits, sb, lettersMap, result, pos);
          return result;
    }
    private static List<String> LetterCombinationsFunction(String digits, StringBuilder sb,
                    Dictionary<Char, Char[]> lettersMap, List<String> result, int pos)
    {
          if (sb.Length == digits.Count())
          {
            result.Add(sb.ToString());
            return result;
          }
          lettersMap.TryGetValue(digits[pos], out char[] values);
          foreach (var v in values)
          {
            sb.Append(v);
            LetterCombinationsFunction(digits, sb, lettersMap, result, pos + 1);
            sb.Remove(sb.Length - 1, 1);
          }
          return result;
    }
  }
}
