using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingStairs
{
  internal class Program
  {
    static void Main(string[] args)
    {/*
      
        You are climbing a staircase. It takes n steps to reach the top.

        Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

 

        Example 1:

        Input: n = 2
        Output: 2
        Explanation: There are two ways to climb to the top.
        1. 1 step + 1 step
        2. 2 steps

      
      */
    }
    public int ClimbStairs(int n)
    {
      var zero = 1;
      var one = 1;
      for (int i = 2; i <= n; i++)
      {
        var temp = one;
        one = one + zero;
        zero = temp;
      }
      return one;
    }
  }
}
