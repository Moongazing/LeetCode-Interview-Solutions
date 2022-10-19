using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

      You may assume that each input would have exactly one solution, and you may not use the same element twice.

      You can return the answer in any order.*/
    }
    public int[] TwoSum(int[] nums, int target)
    {
      var numsDictionary = new Dictionary<int, int>();

      int complement = 0;

      for (int i = 0; i < nums.Count(); i++)
      {
        complement = target - nums[i];
        int index = 0;
        if (numsDictionary.TryGetValue(complement, out index))
        {
          int[] twoSumSolution = { index, i };
          return twoSumSolution;
        }

        if (!numsDictionary.ContainsKey(nums[i]))
        {
          numsDictionary.Add(nums[i], i);
        }
      }

      return null;
    }
  }
}
