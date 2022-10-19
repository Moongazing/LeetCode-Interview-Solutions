using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSheetColumnNumber
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*
       Given a string columnTitle that represents the column title as appears in an Excel sheet, return its corresponding column number.

        For example:

        A -> 1
        B -> 2
        C -> 3
        ...
        Z -> 26
        AA -> 27
        AB -> 28
       
       */
    }

    public int TitleToNumber(string columnName)
    {
      if (string.IsNullOrEmpty(columnName)) throw new ArgumentNullException("columnName");

      columnName = columnName.ToUpperInvariant();

      int sum = 0;

      for (int i = 0; i < columnName.Length; i++)
      {
        sum *= 26;
        sum += (columnName[i] - 'A' + 1);
      }

      return sum;
    }
  }
}
