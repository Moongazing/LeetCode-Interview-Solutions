using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusOne
{
  internal class Program
  {
    static void Main(string[] args)
    {/*
      
      You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

        Increment the large integer by one and return the resulting array of digits.

 

        Example 1:

        Input: digits = [1,2,3]
        Output: [1,2,4]
        Explanation: The array represents the integer 123.
        Incrementing by one gives 123 + 1 = 124.
        Thus, the result should be [1,2,4].

      
      */
    }
    public int[] PlusOne(int[] digits)
    {
      var plus = 1;
      for (var i = digits.Length - 1; i >= 0; i--)
      {
        var digit = digits[i];
        var newDigit = digit + plus;
        if (newDigit == 10)
        {
          digits[i] = 0;
          plus = 1;
        }
        else
        {
          digits[i] = newDigit;
          plus = 0;
        }
      }

      if (plus == 1)
      {
        var newDigits = new int[digits.Length + 1];
        newDigits[0] = 1;
        return newDigits;
      }
      return digits;
    }
  }
}
