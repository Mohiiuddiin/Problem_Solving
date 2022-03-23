using System;
using System.Collections.Generic;


namespace Add_Two_Numbers
{
    public class LinkedList
    {

        ListNode head1, head2;

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        /* Adds contents of two linked lists
        and return the head node of resultant list */
        ListNode addTwoLists(ListNode first, ListNode second)
        {
            // res is head node of the resultant list
            ListNode res = null;
            ListNode prev = null;
            ListNode temp = null;
            int carry = 0, sum;

            // while both lists exist
            while (first != null || second != null)
            {
                // Calculate value of next digit in resultant
                // list. The next digit is sum of following
                // things (i) Carry (ii) Next digit of first
                // list (if there is a next digit) (ii) Next
                // digit of second list (if there is a next
                // digit)
                sum = carry + (first != null ? first.val : 0)
                      + (second != null ? second.val : 0);

                // update carry for next calculation
                carry = (sum >= 10) ? 1 : 0;

                // update sum if it is greater than 10
                sum = sum % 10;

                // Create a new node with sum as data
                temp = new ListNode(sum);

                // if this is the first node then set it as head
                // of the resultant list
                if (res == null)
                {
                    res = temp;
                }

                // If this is not the first
                // node then connect it to the rest.
                else
                {
                    prev.next = temp;
                }

                // Set prev for next insertion
                prev = temp;

                // Move first and second pointers to next nodes
                if (first != null)
                {
                    first = first.next;
                }
                if (second != null)
                {
                    second = second.next;
                }
            }

            if (carry > 0)
            {
                temp.next = new ListNode(carry);
            }

            // return head of the resultant list
            return res;
        }
        /* Utility function to print a linked list */

        void printList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
            Console.WriteLine("");
        }

        // Driver code
        public static void Main(String[] args)
        {
            LinkedList list = new LinkedList();

            // creating first list
            list.head1 = new ListNode(7);
            list.head1.next = new ListNode(5);
            list.head1.next.next = new ListNode(9);
            list.head1.next.next.next = new ListNode(4);
            list.head1.next.next.next.next = new ListNode(6);
            Console.Write("First List is ");
            list.printList(list.head1);

            // creating second list
            list.head2 = new ListNode(8);
            list.head2.next = new ListNode(4);
            Console.Write("Second List is ");
            list.printList(list.head2);

            // add the two lists and see the result
            ListNode rs = list.addTwoLists(list.head1, list.head2);
            Console.Write("Resultant List is ");
            list.printList(rs);
        }
    }

}
