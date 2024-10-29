/*
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
*/

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
