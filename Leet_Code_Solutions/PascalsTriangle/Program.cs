using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalsTriangle
{
  internal class Program
  {
    static void Main(string[] args)
    {/*
      Given an integer numRows, return the first numRows of Pascal's triangle.

      In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:


      Example 1:

      Input: numRows = 5
      Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
      */
    }
    public IList<IList<int>> Generate(int numRows)
    {
      IList<IList<int>> myList = new List<IList<int>>();
      if (numRows == 0) return myList;
      myList.Add(new List<int>() { 1 });
      if (numRows == 1) return myList;
      myList.Add(new List<int>() { 1, 1 });
      if (numRows == 2) return myList;
      int prev = 1;
      while (numRows != 2)
      {
        IList<int> addMe = new List<int>();
        addMe.Add(1);
        for (int i = 0; i < myList[prev].Count() - 1; i++)
        {
          addMe.Add(myList[prev][i] + myList[prev][i + 1]);
        }
        addMe.Add(1);
        myList.Add(addMe);
        prev++;
        numRows--;
      }


      return myList;
    }

  }
}
