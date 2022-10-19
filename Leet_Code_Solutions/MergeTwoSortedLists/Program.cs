using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedLists
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*You are given the heads of two sorted linked lists list1 and list2.

        Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.

        Return the head of the merged linked list.*/
    }
  }

  public ListNode MergeTwoLists(ListNode l1, ListNode l2)
  {
    ListNode head = null;
    if (l1 == null && l2 == null) return null;
    if (l1 == null || l2 == null) { head = (l1 == null) ? l2 : l1; return head; }
    if (l1.val < l2.val) { head = new ListNode(l1.val); l1 = l1.next; }
    else { head = new ListNode(l2.val); l2 = l2.next; }

    ListNode l = head;
    while (l1 != null || l2 != null)
    {
      if (l1 == null) { head.next = l2; return l; }
      if (l2 == null) { head.next = l1; return l; }
      if (l1.val < l2.val) { head.next = new ListNode(l1.val); head = head.next; l1 = l1.next; }
      else { head.next = new ListNode(l2.val); head = head.next; l2 = l2.next; }
    }
    return l;
  }
}
