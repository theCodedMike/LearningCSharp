// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Collections.ObjectModel;

WorkWithStrings();
List<int> fibonacciNumbers = [1, 1];
var prev = fibonacciNumbers[fibonacciNumbers.Count - 1];
var prev2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
fibonacciNumbers.Add(prev + prev2);
foreach (var item in fibonacciNumbers)
{
    // 1
    // 1
    // 2
    Console.WriteLine(item);
}

// 试着编写代码，生成斐波那契数列中的前20个数字
Test();
// ArrayList  LinkedList
// HashSet    SortedSet
// Dictionary SortedDictionary
var names = new HashSet<string>();
names.Add("hello");
var contains = names.Contains("hell");
Console.WriteLine(contains); // False

var map = new Dictionary<int, string>();
map.Add(1, "Mike");
if (map.ContainsKey(1))
{
    Console.WriteLine("contains 2"); // contains 2
}


void WorkWithStrings()
{
    List<string> names = ["<name>", "Ana", "Felipe"];
    foreach (var name in names)
    {
        // Hello <NAME>!
        // Hello ANA! 
        // Hello FELIPE!
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }

    Console.WriteLine();
    names.Add("Maria");
    names.Add("Bill");
    names.Remove("Ana");
    foreach (var name in names)
    {
        // Hello <NAME>!
        // Hello FELIPE!
        // Hello MARIA!
        // Hello BILL!
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }

    Console.WriteLine($"My name is {names[0]}"); // <name>
    Console.WriteLine($"I've added {names[2]} and {names[3]} to the list"); // Maria and Bill
    Console.WriteLine($"The list has {names.Count} people in it."); // 4
    Console.WriteLine();

    var index = names.IndexOf("Felipe");
    if (index == -1)
    {
        Console.WriteLine($"When an item is not found, IndexOf returns {index}");
    }
    else
    {
        Console.WriteLine($"The name {names[index]} is at index {index}"); //  Felipe is at index 1
    }

    index = names.IndexOf("NotFound");
    if (index == -1)
    {
        Console.WriteLine($"When an item is not found, IndexOf returns {index}");
    }
    else
    {
        Console.WriteLine($"The name {names[index]} is at index {index}"); // -1
    }

    Console.WriteLine();
    names.Sort();
    foreach (var name in names)
    {
        // Hello <NAME>!
        // Hello BILL!
        // Hello FELIPE!
        // Hello MARIA!
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }
}

void Test()
{
    List<int> fibNums = new(20);
    fibNums.Add(1);
    fibNums.Add(1);
    for (int i = 2; i < fibNums.Capacity; i++)
    {
        fibNums.Add(fibNums[i - 1] + fibNums[i - 2]);
    }

    foreach (var num in fibNums)
    {
        Console.WriteLine(num);
    }
    // 1
    // 1
    // 2
    // 3
    // 5
    // 8
    // 13
    // 21
    // 34
    // 55
    // 89
    // 144
    // 233
    // 377
    // 610
    // 987
    // 1597
    // 2584
    // 4181
    // 6765

}