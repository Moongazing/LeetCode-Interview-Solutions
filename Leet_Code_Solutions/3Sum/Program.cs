using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Sum
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

      Notice that the solution set must not contain duplicate triplets.*/
    }
    public IList<IList<int>> ThreeSum(int[] nums)
    {

      var reslist = new List<IList<int>>();
      Array.Sort(nums);
      var pre = 0;
      for (var i = nums.Length - 1; i > 1; i--)
      {
          if (i != nums.Length - 1 && nums[i] == pre)
          {
            continue;
          }
          var remain = 0 - nums[i];
          pre = nums[i];
          var prev = 0;
          for (var j = i - 1; j > 0; j--)
          {
            if (j != i - 1 && nums[j] == prev)
            {
              continue;
            }
            var last = remain - nums[j];
            prev = nums[j];
            var exist = Array.BinarySearch<int>(nums, 0, j, last);
            if (exist >= 0)
            {
              reslist.Add(new List<int>() { nums[i], nums[j], last });
            }
          }
      }
      return reslist;
    }
  }
}
