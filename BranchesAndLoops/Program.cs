// See https://aka.ms/new-console-template for more information

ExploreIf();
ExploreLoops();

void ExploreIf()
{
    var a = 5;
    var b = 6;
    a = 4;
    b = 7;
    if (a + b > 10)
    {
        Console.WriteLine("The answer is greater than 10");
    }

    a = 5;
    b = 3;
    if (a + b > 10)
    {
        Console.WriteLine("The answer is greater than 10");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
    }

    int c = 4;
    if ((a + b+c > 10) && (a==b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("And the first number is equal to the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("Or the first number is not equal to the second");
    }
    
    if ((a + b + c > 10) || (a > b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("Or the first number is greater than the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("And the first number is not greater than the second");
    }
}

void ExploreLoops()
{
    int counter = 0;
    // while
    while (counter < 10)
    {
        Console.WriteLine($"Hello World! The counter is {counter}");
        counter++;
    }

    // do while
    counter = 0;
    do
    {
        Console.WriteLine($"Hello World! the counter is : {counter}");
        counter++;
    } while (counter <  10);

    // for
    for (int idx = 0; idx < 10; idx++)
    {
        Console.WriteLine($"Hello World! the index is {idx}");
    }

    for (int row = 1; row < 11; row++)
    {
        Console.WriteLine($"The row is {row}");
    }

    for (char col = 'a'; col < 'k'; col++)
    {
        Console.WriteLine($"The col is {col}");
    }

    for (int row = 1; row < 11; row++)
    {
        for (char col = 'a'; col < 'k'; col++)
        {
            Console.WriteLine($"the cell is ({row}, {col})");
        }
    }
    
    // 计算 1 到 20 中所有可被 3 整除的整数的总和
    var sum = 0;
    for (int i = 1; i <= 20; i++)
    {
        if (i % 3 == 0)
        {
            sum += i;
        }
    }
    Console.WriteLine($"the sum is {sum}"); // 63
}