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