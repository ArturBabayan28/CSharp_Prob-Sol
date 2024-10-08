//Homework 1
// Task 1.1
List<int> list1 = new List<int>();
list1.Add(1);
list1.Add(2);
list1.Add(3);
list1.Add(4);
list1.Add(5);

// Task 1.2
Dictionary<string, int> dict1 = new Dictionary<string, int>();
dict1.Add("1", 1);
dict1.Add("2", 2);
dict1.Add("3", 3);
dict1.Add("4", 4);
dict1.Add("5", 5);

// Task 1.3
Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);

// Task 1.4
Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);

// Task 2.1
Console.WriteLine(list1.Sum());

// Task 2.2
Console.WriteLine(dict1.Sum(x => x.Value));

// Task 2.3
queue.Dequeue();
queue.Dequeue();
int[] arr = queue.ToArray();
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

// Task 2.4
stack.Pop();
stack.Pop();
int[] arr2 = stack.ToArray();
for (int i = 0; i < arr2.Length; i++)
{
    Console.WriteLine(arr2[i]);
}

// Task 3.1
List<int> list = new List<int>();
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}

// Task 3.2, 3.3
Console.WriteLine("Please enter 3-digit number.");
int num = Convert.ToInt32(Console.ReadLine());
int max = num / 100;
int min = num / 100;
if ((num % 100 - num % 10) / 10 > max)
{
    max = (num % 100 - num % 10) / 10;

}
if (num % 10 >= max)
{
    max = num % 10;
}

if ((num % 100 - num % 10) / 10 < min)
{
    min = (num % 100 - num % 10) / 10;

}
if (num % 10 < min)
{
    min = num % 10;
}

Console.WriteLine($"The largest digit is: {max}");
Console.WriteLine($"The smallest digit is: {min}");

// Task 3.4, 3.5
int Sum1 = 0;
double Sum2 = 0;
Console.WriteLine("Please enter the number of items.");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];
Console.WriteLine("Please enter the items of array");
for (int i = 0; i < count; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    Sum2 += array[i];
}
for (int i = 0; i < count; i++)
{
    if (array[i] % 2 == 0 && array[i] != 0)
    {
        Sum1 += array[i];
    }
}

Console.WriteLine(Sum1);
Sum2 /= count;
Console.WriteLine(Sum2);

//Homework 2
//Task 1
using System;
using System.Collections.Generic;

class RecursiveInsertionSort
{
    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        InsertionSort(array, n);

        Console.WriteLine("Sorted Array:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
    }

    static void InsertionSort(int[] array, int n)
    {
        //if the array has 1 element, it's already sorted
        if (n <= 1)
            return;

        //Sort the first n-1 elements
        InsertionSort(array, n - 1);

        //Insert the nth element into its correct position
        int last = array[n - 1];
        int j = n - 2;

        while (j >= 0 && array[j] > last)
        {
            array[j + 1] = array[j];
            j--;
        }

        array[j + 1] = last;
    }
}

//Task 2
using System;

class CustomQueue
{
    private int[] queueArray;
    private int front;
    private int rear;
    private int capacity;
    private int count;

    public CustomQueue(int size)
    {
        queueArray = new int[size];
        capacity = size;
        front = 0;
        rear = -1;
        count = 0;
    }

    // Enqueue: add an element to the rear of the queue
    public void Enqueue(int item)
    {
        if (IsFull())
        {
            Console.WriteLine("Queue is full! Cannot add more elements.");
            return;
        }

        rear = (rear + 1) % capacity;
        queueArray[rear] = item;
        count++;
    }

    // Dequeue: remove an element from the front of the queue
    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty! Cannot remove elements.");
            return -1;
        }

        int item = queueArray[front];
        front = (front + 1) % capacity;
        count--;
        return item;
    }

    // Check if the queue is empty
    public bool IsEmpty()
    {
        return count == 0;
    }

    // Check if the queue is full
    public bool IsFull()
    {
        return count == capacity;
    }

    // Display the queue contents
    public void DisplayQueue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty!");
            return;
        }

        Console.WriteLine("Queue elements:");
        for (int i = 0; i < count; i++)
        {
            int index = (front + i) % capacity;
            Console.Write(queueArray[index] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter the size of the queue: ");
        int size = Convert.ToInt32(Console.ReadLine());
        CustomQueue queue = new CustomQueue(size);

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Enqueue");
            Console.WriteLine("2. Dequeue");
            Console.WriteLine("3. Display Queue");
            Console.WriteLine("4. Exit");
            Console.Write("Your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the element to enqueue: ");
                    int element = Convert.ToInt32(Console.ReadLine());
                    queue.Enqueue(element);
                    break;
                case 2:
                    int dequeued = queue.Dequeue();
                    if (dequeued != -1)
                        Console.WriteLine($"Dequeued element: {dequeued}");
                    break;
                case 3:
                    queue.DisplayQueue();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please select again.");
                    break;
            }
        }
    }
}
