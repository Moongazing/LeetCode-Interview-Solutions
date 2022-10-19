using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNthNodeFromEndofList
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*Given the head of a linked list, remove the nth node from the end of the list and return its head.*/
       
    }

    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {

      if (n == 0) return head;
      ListNode l1 = head, l2 = head;
      while (n != 0)
      {
        l2 = l2.next; n--;
      }
      if (l2 == null) return head.next;
      while (l2.next != null)
      {
        l1 = l1.next; l2 = l2.next;
      }
      l1.next = l1.next.next;
      return head;

    }
  }
}
