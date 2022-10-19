using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheDuplicateNumber
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*Given an array of integers nums containing n + 1 integers where each integer is in the range [1, n] inclusive.

      There is only one repeated number in nums, return this repeated number.

      You must solve the problem without modifying the array nums and uses only constant extra space.*/
    }
    public int FindDuplicate(int[] nums)
    {
        int len = nums.Length;
        int[] temp = new int[len + 1];
        for (int i = 0; i < len; i++)
        {
          temp[nums[i]]++;
          if (temp[nums[i]] > 1)
          {
            return nums[i];
          }
        }
        return len;

    }
  }
}
