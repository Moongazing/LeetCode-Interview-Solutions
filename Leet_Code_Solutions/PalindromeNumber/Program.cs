using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
  internal class Program
  {
    public bool IsPalindrome(int num)
    {
        int sum = 0, temp, rem;
        temp = num;
        while (num > 0)
        {
          rem = num % 10;
          num = num / 10;
          sum = sum * 10 + rem;

        }
        if (temp == sum)
        {
          return true;
        }
        else
        {
          return false;
        }
    }
    static void Main(string[] args)
    {
      /*Question : Given an integer x, return true if x is palindrome integer.

      An integer is a palindrome when it reads the same backward as forward.

      For example, 121 is a palindrome while 123 is not.*/
      

    }
    
  }
}
