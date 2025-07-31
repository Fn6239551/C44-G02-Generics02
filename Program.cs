using System;
using System.Collections;

namespace solv_Task_in_session__Assignment_02___Advanced_C_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Task in session 

            /*
            * Here's a hard but focused task combining List<T> and LinkedList<T> -great for advanced
            students to understand differences, use-cases, and manipulation of both collections.

            Task Title:
            Build a Mini Notification System Using List<T> and LinkedList<T>

            · Scenario:
            You're simulating a notification center:
            . List<T> stores all historical notifications (for logging).
            · LinkedList<T> stores live notifications (for fast insert/remove from start or end).
            . Students must manage both collections together.
            · Use:
            List<Notification> history = new List<Notification>();

            LinkedList<Notification> liveQueue = new LinkedList<Notification>();

            3. Implement features:
            . Add new notification to both history and to the front of liveQueue.
            . Display latest 3 live notifications (liveQueue.Take(3)).
            . Remove the oldest live notification (from end).
            . Count how many total notifications have been logged ( history.Count ).
            · Requirements:
            1. Create a class Notification :
            public class Notification
            {
            public string Message { get; set; }
            public DateTime CreatedAt { get; set; }
            }*/

            //List<Notification> history = new List<Notification>();
            //LinkedList<Notification> liveQueue = new LinkedList<Notification>();

            // void AddNotification(string message)
            //{
            //    Notification notification = new Notification(message);
            //    history.Add(notification);
            //    liveQueue.AddFirst(notification);
            //    Console.WriteLine($"Notification added: {notification}");
            //}


            //void DisplayLatestLiveNotifications()
            //{
            //    Console.WriteLine("Latest 3 live notifications:");
            //    foreach (var notification in liveQueue.Take(3))
            //    {
            //        Console.WriteLine(notification);
            //    }
            //}

            //void RemoveOldestLiveNotification()
            //{
            //    if (liveQueue.Count > 0)
            //    {
            //        var oldest = liveQueue.Last.Value;
            //        liveQueue.RemoveLast();
            //        Console.WriteLine($"[-] Removed: {oldest}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No live notifications to remove.");
            //    }
            //}

            //void DisplayTotalNotifications()
            //{
            //    Console.WriteLine($"Total notifications logged: {history.Count}");
            //}


            //AddNotification("Welcome to the notification system!");
            //AddNotification("New message received.");
            //AddNotification("System update available.");
            //DisplayLatestLiveNotifications();
            //RemoveOldestLiveNotification();
            //DisplayLatestLiveNotifications();
            //DisplayTotalNotifications();
            //Console.WriteLine("History Log Count: " + history.Count);

            #endregion

            #region Assignment 02 - Advanced C#
            #region Q1
            /*
            * 1. Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.
            Ex:
            Input
            3 3                    //Size of array , number of queries
            11 5 3             //Array 
            1                      //Query1
            5                     //Query2
            13                  //Query 3
            Output
            3                   //11,5,3
                       1                  //11
            0  */
            //string[] input = Console.ReadLine().Split();
            //int n = int.Parse(input[0]);
            //int q = int.Parse(input[1]);

            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //int[] queries = new int[q];
            //for (int i = 0; i < q; i++)
            //{
            //    queries[i] = int.Parse(Console.ReadLine());
            //}

            //List<int> results = new List<int>();
            //foreach (int x in queries)
            //{
            //    int count = 0;
            //    foreach (var item in arr)
            //    {
            //        if (item > x)
            //            count++;
            //    }
            //    results.Add(count);
            //}
            //Console.WriteLine("Output:");

            //foreach (var result in results)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion
            #region Q2
            /*  2. Given a number N and an array of N numbers. Determine if it's palindrome or not.
                Ex:
                Input:
                5
                1 3 2 3 1
                Output:
                YES */
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //bool isPalindrome = true;
            //for (int i = 0; i < n / 2; i++)
            //{
            //    if (arr[i] != arr[n - 1 - i])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}
            //Console.WriteLine("Output:");
            //Console.WriteLine(isPalindrome ? "YES" : "NO");
            #endregion
            #region Q3
            /* 3. Given a Queue, implement a function to reverse
               the elements of a queue using a stack. */
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue.Enqueue(6);
            //Stack<int> stack = new Stack<int>();
            //while (queue.Count > 0)
            //{
            //    stack.Push(queue.Dequeue());
            //}
            //while (stack.Count > 0)
            //{
            //    queue.Enqueue(stack.Pop());
            //}
            //Console.WriteLine("Output:");
            //foreach (var item in queue)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            #endregion
            #region Q4
            /*4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
            Ex:
            Input:
            [()]{}
            Output:
            Balanced */
            //string input = Console.ReadLine();
            //Stack<char> stack = new Stack<char>();
            //bool isBalanced = true;
            //foreach (char c in input)
            //{
            //    if (c == '(' || c == '{' || c == '[')
            //    {
            //        stack.Push(c);
            //    }
            //    else if (c == ')' || c == '}' || c == ']')
            //    {
            //        if (stack.Count == 0)
            //        {
            //            isBalanced = false;
            //            break;
            //        }
            //        char top = stack.Pop();
            //        if ((c == ')' && top != '(') ||
            //            (c == '}' && top != '{') ||
            //            (c == ']' && top != '['))
            //        {
            //            isBalanced = false;
            //            break;
            //        }
            //    }
            //}
            //if (stack.Count > 0)
            //{
            //    isBalanced = false;
            //}
            //Console.WriteLine("Output:");
            //Console.WriteLine(isBalanced ? "Balanced" : "Not Balanced");
            #endregion
            #region Q5
            /*5. Given an array, implement a function to remove duplicate elements from an array.
            */
            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //int[] unique = arr.Distinct().ToArray();
            //Console.WriteLine("Output:");
            //foreach (var item in unique)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion
            #region Q6
            /*6. Given an array list , implement a function to remove all odd numbers from it.
             */
            //ArrayList list = new ArrayList() { 1, 2, 3, 4, 5, 6 };
            //for (int i = list.Count - 1; i >= 0; i--)
            //{
            //    if ((int)list[i] % 2 != 0)
            //    {
            //        list.RemoveAt(i);
            //    }
            //}
            //Console.WriteLine("Output:");
            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion
            #region Q7
            /*  7. Implement a queue that can hold different data types. 
                And insert the following data:
                queue.Enqueue(1)
                queue.Enqueue(“Apple”)
                queue.Enqueue(5.28)
            */
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);
            //Console.WriteLine("Output:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q8
            /*8. Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack. If the target is found, print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message indicating that the target was not found(“Target was not found”).
              Note : take the target as input from the user */
            //Stack<int> stack = new Stack<int>(new[] { 10, 20, 30, 40, 50, 60 });
            //Console.WriteLine("Enter target integer:");
            //int target = int.Parse(Console.ReadLine());
            //int count = 0;
            //bool found = false;
            //while (stack.Count > 0)
            //{
            //    count++;
            //    int current = stack.Pop();
            //    if (current == target)
            //    {
            //        found = true;
            //        Console.WriteLine($"Target was found successfully and the count = {count}");
            //        break;
            //    }
            //}
            //if (!found)
            //{
            //    Console.WriteLine("Target was not found");
            //}
            #endregion
            #region Q9
            /*9. Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.
                Ex : 
                Input :
                5 , 3
                [1,2,3,4,4] , [10,4,4]
                Output : 
                [4,4]
             */
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());

            //List<int> list1 = Console.ReadLine().Trim('[', ']').Split(',').Select(int.Parse).ToList();
            //List<int> list2 = Console.ReadLine().Trim('[', ']').Split(',').Select(int.Parse).ToList();

            //List<int> intersection = new List<int>();

            //foreach (var item in list1)
            //{
            //    if (list2.Contains(item))
            //    {
            //        intersection.Add(item);
            //        list2.Remove(item);
            //    }
            //}

            //Console.WriteLine("[" + string.Join(",", intersection) + "]");
            #endregion
            #region Q10
            /*  10. Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.
                Ex : 
                Input : 
                [1, 2, 3, 7, 5]
                12
                Output : 
                [2, 3, 7]  */
            //ArrayList numbers = new ArrayList() { 1, 2, 3, 7, 5 };
            //int target = int.Parse(Console.ReadLine());

            //List<int> result = new List<int>();
            //bool found = false;

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    int sum = 0;
            //    result.Clear();
            //    for (int j = i; j < numbers.Count; j++)
            //    {
            //        int value = (int)numbers[j];
            //        sum += value;
            //        result.Add(value);
            //        if (sum == target)
            //        {
            //            found = true; break;
            //        }
            //        else if (sum > target)
            //        {
            //            break;
            //        }
            //    }
            //    if (found)
            //    {
            //        break;
            //    }
            //}
            //    if (found)
            //    {
            //        Console.WriteLine("[" + string.Join(", ", result) + "]");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No sublist found.");
            //    }
            #endregion
            #region Q11
            /*  11. Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 
                Ex : 
                Input : 
                [1 , 2 , 3 , 4 ,5]
                K = 3
                Output :
                [3 , 2 , 1 , 4 ,5]
             */
            //Console.WriteLine("Enter the queue elements separated by spaces:");
            //string[] input = Console.ReadLine().Trim('[', ']').Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //Queue<int> queue = new Queue<int>(input.Select(int.Parse));

            //Console.WriteLine("Enter the value of K:");
            //int k = int.Parse(Console.ReadLine());

            //if (k > queue.Count || k < 0) 
            //{
            //    Console.WriteLine("Invalid value of K");
            //}
            //else
            //{
            //    int originalSize = queue.Count;

            //    Stack<int> stack = new Stack<int>();
            //    for (int i = 0; i < k; i++) {
            //        stack.Push(queue.Dequeue());
            //    }

            //    while (stack.Count > 0) 
            //    {
            //        queue.Enqueue(stack.Pop());
            //    }
            //    int remaining = originalSize - k;
            //    for (int i = 0; i<remaining; i++) {
            //        queue.Enqueue(queue.Dequeue());
            //    }
            //    Console.WriteLine("Output:");
            //    Console.WriteLine("[" + string.Join(", ", queue) + "]");

            //}
            #endregion
            #endregion


        }
    }
}