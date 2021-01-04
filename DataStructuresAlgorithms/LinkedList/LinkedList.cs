using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int value)
        {
            this.data = value;
        }
    }
    class LinkedList
    {
        private Node head;
        public LinkedList()
        {
           
        }
        public LinkedList(int firstValue)
        {
            head = new Node(firstValue);
        }

        //GeeksforGeeks - Introduction to Linked List
        // https://www.geeksforgeeks.org/linked-list-set-1-introduction/
        public void PrintList()
        {
            //Print logic has been changed little bit because of => symbol after the last node.
            Node temp = head;
            while(temp.next != null)
            {
                Console.Write(temp.data + " => ");
                temp = temp.next;
            }
            Console.WriteLine(temp.data);
        }

        // GeeksforGeeks - Linked List Insertions
        // https://www.geeksforgeeks.org/linked-list-set-2-inserting-a-node/
        // Time complexity - O(1)
        public void Push(int value)
        {
            Node newNode = new Node(value);
            newNode.next = head;
            head = newNode;
        }

        // Add a node after a give node
        // Time Complexity - o(1)
        public void InsertAfter(Node prevNode, int value)
        {
            if (prevNode == null)
            {
                Console.WriteLine("Previous node cannot be null");
                return;
            }
            
            Node newNode = new Node(value);
            newNode.next = prevNode.next;
            prevNode.next = newNode;
        }

        // Add a node at last.
        // Time Complexity - O(n)
        public void Append(int value)
        {
            if (head == null)
            {
                head = new Node(value);
                return;
            }
            Node temp = head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            Node newNode = new Node(value);
            temp.next = newNode;
        }

        // https://www.geeksforgeeks.org/linked-list-set-3-deleting-node/
        // GeeksforGeeks - Deleting a node
        //  Given a key, deletes the first occurrence of key in linked list 
        public void DeleteValue(int value)
        {
            if (head == null)
            {
                Console.WriteLine("No values in linked list");
                return;
            }
            if (head.data == value)
            {
                head = head.next;
                return;
            }
            Node temp = head;
            Node prev = null;
            while(temp != null && temp.data != value)
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp == null) return;
            
            prev.next = temp.next;
        }

        //Delete a Linked List node at a given position
        // https://www.geeksforgeeks.org/delete-a-linked-list-node-at-a-given-position/
        public void DeletePosition(int position)
        {
            if (head == null) return;

            Node temp = head;            
            if (position == 0)
            {
                head = temp.next;
            }

            while(position > 1 && temp != null)
            {
                temp = temp.next;
                position--;
            }

            if (temp == null || temp.next == null) return;

            temp.next = temp.next.next;
        }

        // 7. Length of a linked list - Iterative
        // https://www.geeksforgeeks.org/find-length-of-a-linked-list-iterative-and-recursive/
        // Time Complexity - O(n)
        public int GetLength()
        {
            Node temp = head;
            int length = 0;
            while(temp != null)
            {
                length++;
                temp = temp.next;
            }
            return length;
        }

        // Length of a linked list - Recursive
        private int GetLengthRec(Node methodhead)
        {
            if (methodhead == null) return 0;

            return 1 + GetLengthRec(methodhead.next);
        }
        public int GetLengthRecursive()
        {
            return GetLengthRec(head);
        }

        // https://www.geeksforgeeks.org/search-an-element-in-a-linked-list-iterative-and-recursive/
        // GeeksforGeeks - Searching a value
        // 8 - Search an element in a Linked List (Iterative and Recursive)
        public bool Search(int value)
        {
            Node temp = head;
            while(temp != null)
            {
                if (temp.data == value) return true;
                temp = temp.next;
            }
            return false;
        }
        private bool SearchRecursive(Node node, int value)
        {
            if (node == null) return false;
            if (node.data == value) return true;
            return SearchRecursive(node.next, value);
        }

        //Wrapper
        public bool SearchRecursive(int value)
        {
            return SearchRecursive(head, value);
        }

        // https://www.geeksforgeeks.org/write-a-function-to-get-nth-node-in-a-linked-list/
        // 9 - Function to get Nth node in a Linked List
        public int GetNthValue(int NthValue)
        {
            Node temp = head;
            while(NthValue != 0 && temp != null)
            {
                temp = temp.next;
                NthValue--;
            }
            if (temp == null) return 0;
            return temp.data;
        }

        // Wrapper
        public int GetNthValueRecursion(int NthValue)
        {
            return GetNthValue(head, NthValue);
        }

        // Function to get Nth node in a Linked List
        private int GetNthValue(Node node, int NthValue)
        {
            if (NthValue == 0) return node.data;
            if (node.next != null)
            {
                return GetNthValue(node.next, NthValue - 1);
            }
            return 0;
        }

        // 10. n’th node from the end of a Linked List
        // https://www.geeksforgeeks.org/nth-node-from-the-end-of-a-linked-list/
        // Time Complexity - O(n)
        public int GetNthValueFromLast(int value)
        {
            int length = GetLength();
            if (value > length) Console.WriteLine("Wrong Input");
            return GetNthValue(length-value-1);
        }

        // Using two pointers
        public int GetNthValueFromLast2ndApproach(int value)
        {
            Node temp = head;
            Node current = head;

            while(value != 0 && temp != null)
            {
                temp = temp.next;
                value--;
            }
            if (temp == null) return 0;
            while(temp.next != null)
            {
                temp = temp.next;
                current = current.next;
            }
            return current.data;
        }

        // https://www.geeksforgeeks.org/write-a-c-function-to-print-the-middle-of-the-linked-list/
        // 11. Geeks for Geeks - middle of a given linked list
        // 
        public int GetMiddleValue()
        {
            Node slow = head;
            Node fast = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow.data;
        }

        public int GetMiddleValueUsingLength()
        {
            int length = GetLength();
            return GetNthValue(length / 2);
        }

        //Traverse the list from head, while traversing increment the counter and change
        //mid to mid->next whenever the counter is odd. So the mid will move only half of 
        //the total length of the list.       
        public int GetMiddleValueUsing3rdApproach()
        {
            Node temp = head;
            Node mid = head;
            int counter = 0;
            while(temp != null)
            {                
                if (counter % 2 == 1) mid = mid.next;
                counter++;
                temp = temp.next;
            }
            return mid.data;
        }

        // 12. function that counts the number of times a given int occurs in a Linked List
        // https://www.geeksforgeeks.org/write-a-function-that-counts-the-number-of-times-a-given-int-occurs-in-a-linked-list/
        // Method 1- Iterative Approach
        public int SearchCount(int value)
        {
            int count = 0;
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == value) count++;
                temp = temp.next;
            }
            return count;
        }

        //Method 2- With Recursion
        public int SearchCountRecursive(int value)
        {
            return SearchCount(head, value);
        }
        private int SearchCount(Node node, int value)
        {
            if (node == null) return 0;

            if (node.data == value) return 1 + SearchCount(node.next, value);

            return SearchCount(node.next, value);
        }

        // 13. Detect loop in a linked list
        // https://www.geeksforgeeks.org/detect-loop-in-a-linked-list/
        // Using hashing
        public bool DetectLoop()
        {
            // this.head.next.next.next.next = this.head;
            Node temp = head;
            HashSet<Node> container = new HashSet<Node>();
            while(temp != null)
            {
                if (container.Contains(temp)) return true;
                container.Add(temp);
                temp = temp.next;
            }
            return false;
        }

        // Floyd’s Cycle-Finding Algorithm
        // Time Complexity: O(n) Auxiliary Space: O(1)
        public bool DetectLoop2()
        {            
            Node fast = head;
            Node slow = head;
            while(fast.next!=null && fast.next.next != null)
            {              
                slow = slow.next;
                fast = fast.next.next;
                if (fast == slow) return true;
            }
            return false;
        }

        // 14. Geeks for Geeks - Find length of loop in linked list
        // https://www.geeksforgeeks.org/find-length-of-loop-in-linked-list/
        public int LengthOfLoop()
        {
            this.head.next.next.next.next = this.head.next;

            Node fast = head;
            Node slow = head;
            while(fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (fast == slow) break;
            }
            fast = fast.next;
            int length = 1;
            while (fast != slow)
            {
                fast = fast.next;
                length++;
            }
            return length;
        }

        // 15. Function to check if singly linked list is palindrome
        // Geeks for geeks
        // https://www.geeksforgeeks.org/function-to-check-if-a-singly-linked-list-is-palindrome/
        public bool IsPalindrome()
        {
            Node temp = head;

            Stack<int> container = new Stack<int>();
            while(temp != null)
            {
                container.Push(temp.data);
                temp = temp.next;
            }
            temp = head;
            while(temp != null)
            {
                if (container.Pop() != temp.data) return false;
                temp = temp.next;
            }
            return true;
        }

        // 16 . Remove duplicates from a sorted linked list
        // https://www.geeksforgeeks.org/remove-duplicates-from-a-sorted-linked-list/
        // Time Complexity: O(n)
        public void RemoveDuplicates()
        {
            Node temp = head;
            while(temp.next!=null)
            {
                if (temp.data == temp.next.data)
                {
                    temp.next = temp.next.next;
                }
                else
                {
                    temp = temp.next;
                }
            }
        }

        //Approach 2
        public void RemoveDuplicatesRecursive()
        {
            RemoveDuplicates(head);
        }
        private void RemoveDuplicates(Node node)
        {
            if (node == null) return;

            if (node.next != null)
            {
                if (node.data == node.next.data)
                {
                    node.next = node.next.next;
                    RemoveDuplicates(node);
                }
                else
                {
                    RemoveDuplicates(node.next);
                }
            }           
        }

        // 17. Remove duplicates from an unsorted linked list
        // https://www.geeksforgeeks.org/remove-duplicates-from-an-unsorted-linked-list/
        // Method 1 - Using two loops
        // Time complexity - O(n*n)
        public void RemoveUnsortedDuplicates()
        {
            Node outer = head;
            Node inner;
            while(outer.next != null)
            {
                inner = outer;
                while(inner.next != null)
                {
                    if (outer.data == inner.next.data)
                    {
                        inner.next = inner.next.next;
                    }
                    else inner = inner.next;
                }
                outer = outer.next;
            }
        }

        // 17. Remove duplicates from an unsorted linked list
        // https://www.geeksforgeeks.org/remove-duplicates-from-an-unsorted-linked-list/
        // Method 3 - Using hashing
        // Time Complexity - O(n) , Space Complexity - O(n)
        public void RemoveUnsortedDuplicatesHashing()
        {
            HashSet<int> container = new HashSet<int>();
            Node current = head;
            Node prev = null;
            while(current != null)
            {
                if (container.Contains(current.data))
                {
                    prev.next = current.next;
                }
                else
                {
                    container.Add(current.data);
                    prev = current;
                }
                current = current.next;                
            }
        }

        // https://www.geeksforgeeks.org/swap-nodes-in-a-linked-list-without-swapping-data/
        // 18. Swap nodes in a linked list without swapping data
        // 
        public void SwapNodes(int first, int second)
        {
            if (first == second) return;
            Node current = head;
            Node previous = null;
            Node firstNode = null;
            Node secondNode = null;
            while (current != null)
            {
                if (current.data == first)
                {
                    firstNode = previous == null ? head :  previous.next;
                }
                if (current.data == second)
                {
                    secondNode = previous == null ? head : previous.next;
                }
                previous = current;
                current = current.next;
            }
            if (firstNode != null && secondNode != null)
            {
                firstNode.data = second;
                secondNode.data = first;
            }
        }

        // 19. Pairwise swap elements of a given linked list
        // https://www.geeksforgeeks.org/pairwise-swap-elements-of-a-given-linked-list/
        // Time Complexity - O(n)
        public void PairSwap()
        {
            Node temp = head;
            while(temp != null && temp.next != null)
            {
                int first = temp.data;
                temp.data = temp.next.data;
                temp.next.data = first;
                temp = temp.next.next;
            }
        }

        public void PairSwapRecursion()
        {
            PairSwap(head);
        }
        private void PairSwap(Node node)
        {
            if (node == null || node.next == null) return;

            int first = node.data;
            node.data = node.next.data;
            node.next.data = first;

            PairSwap(node.next.next);
        }


        // https://www.geeksforgeeks.org/move-last-element-to-front-of-a-given-linked-list/
        // 20. Move last element to front of a given Linked List
        public void MoveToFront()
        {
            if (head == null && head.next == null) return;
            Node temp = head;
            Node prev = null;
            while(temp.next != null)
            {
                prev = temp;
                temp = temp.next;
            }
            int data = temp.data;
            prev.next = null;
            Push(data);
        }


    }


}
