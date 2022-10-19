using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityElement
{
  internal class Program
  {
    static void Main(string[] args)
    {/*
      
      Given an array nums of size n, return the majority element.
  
      The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.
      Example 1:

      Input: nums = [3,2,3]
      Output: 3

      
      */
    }

    public int MajorityElement(int[] nums)
    {
      var map = new Dictionary<int, int>();
      var result = nums[0];
      for (var i = 0; i < nums.Length; i++)
      {
        var num = nums[i];
        if (map.ContainsKey(num))
        {
          map[num] += 1;
          if (map[num] > nums.Length / 2)
          {
            result = num;
            break;
          }
        }
        else
        {
          map.Add(num, 1);
        }
      }
      return result;

    }
  }
}
