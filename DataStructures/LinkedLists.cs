using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class ListNode //It's a node 
    {
        public int Value;
        public ListNode? Next;

    }

    public static class LinkedLists
    {
        public static ListNode First { get; set; } = new();

        public static void InsertNode(int val)
        {
            ListNode newNode = new()
            {
                Value = val,
                Next = First
            };
            First = newNode;
        }

        public static ListNode DeleteFirstNode()
        {
            ListNode temp = First; //Initial Node
            First = First.Next;
            return temp;
        }

        public static ListNode PlainReverse()
        {
            ListNode previous = null;
            ListNode current = First;
            while (current != null)
            {
                ListNode nextNode = current.Next; // Store the next node
                current.Next = previous;// Reverse the pointer
                previous = current; // Move 'previous' forward
                current = nextNode; // Move 'current' forward
            }
            return previous;
        }

        //Check if the node go cycle
        public static void HasCycle()
        {
            ListNode slow = First, fast = First;
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;// Move slow pointer one step
                fast =fast.Next.Next;// Move fast pointer two steps

                //Check if cycle exists
                if (slow == fast)
                    Console.WriteLine("Cycle exists");
            }
            Console.WriteLine("No cycle detected.");
        }

        public static void DeepDiveLinkedLists()
        {
            // Create the link list.
            string[] words = { "the", "fox", "jumps", "over", "the", "dog" };
            LinkedList<string> sentence = new(words);
            Display(sentence, "The linked list values:");

            // Add the word 'today' to the beginning of the linked list.
            sentence.AddFirst("today");
            Display(sentence, "Test 1: Add 'today' to beginning of the list:");

            //move the first node to the last node
            LinkedListNode<string> firstNode = sentence.First;
            sentence.RemoveFirst();
            sentence.AddLast(firstNode);
            Display(sentence, "Test 2: Move first node to be last node:");

            // Change the last node to 'yesterday'.
            sentence.RemoveLast();
            sentence.AddLast("Yesterday");
            Display(sentence, "Test 3: Change the last node to 'yesterday':");
        }

        private static void Display(LinkedList<string> words, string test)
        {
            Console.WriteLine(test);
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void IndicateNode(LinkedListNode<string> node, string test)
        {
            Console.WriteLine(test);
            if (node.List == null)
            {
                Console.WriteLine("Node '{0}' is not in the list.\n",
                    node.Value);
                return;
            }

            StringBuilder result = new StringBuilder("(" + node.Value + ")");
            LinkedListNode<string> nodeP = node.Previous;

            while (nodeP != null)
            {
                result.Insert(0, nodeP.Value + " ");
                nodeP = nodeP.Previous;
            }

            node = node.Next;
            while (node != null)
            {
                result.Append(" " + node.Value);
                node = node.Next;
            }

            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}
