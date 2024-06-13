// See https://aka.ms/new-console-template for more information

WorkWithIntegers();
OrderPrecedence();

WorkWithDoubles();

WorkWithDecimals();

void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c); // 24
    
    a  = 18;
    b = 6;
    c = a - b;
    Console.WriteLine(c); // 12

    a  = 18;
    b = 6;
    c = a * b;
    Console.WriteLine(c); // 108

    a  = 18;
    b = 5;
    c = a / b;
    Console.WriteLine(c); // 3
    
    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of integers is {min} to {max}"); // -2147483648 to 2147483647

    int what = max + 3;
    Console.WriteLine($"An example of overflow: {what}"); // -2147483646
}

void OrderPrecedence()
{
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d); // 13

    d = (a + b) * c;
    Console.WriteLine(d); // 18

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d); // 25

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h); // 3

    a = 7;
    b = 4;
    c = 3;
    d = (a + b) / c;
    e = (a + b) % c;
    Console.WriteLine($" quotient: {d}"); //  quotient: 3
    Console.WriteLine($"remainder: {e}"); // remainder: 2
}

void WorkWithDoubles()
{
    double a = 5;
    double b = 4;
    double c = 2;
    double d = (a + b) / c;
    Console.WriteLine(d); // 4.5

    double e = 19;
    double f = 23;
    double g = 8;
    double h = (e + f) / g;
    Console.WriteLine(h); // 5.25

    double max = double.MaxValue;
    double min = double.MinValue;
    // -1.7976931348623157E+308 to 1.7976931348623157E+308
    Console.WriteLine($"The range of double is {min} to {max}");

    double third = 1.0 / 3.0;
    Console.WriteLine(third); // 0.3333333333333333

    float a1 = (float)3.2;
    float a2 = (float)3.4;
    Console.WriteLine($"a1 = {a1}, a2 = {a2}"); // a1 = 3.2, a2 = 3.4
}

void WorkWithDecimals()
{
    var min = decimal.MinValue;
    var max = decimal.MaxValue;
    // -79228162514264337593543950335 to 79228162514264337593543950335
    Console.WriteLine($"The range of the decimal type is {min} to {max}");

    double a = 1.0;
    double b = 3.0;
    Console.WriteLine(a / b); // 0.3333333333333333

    decimal c = 1.0M;
    decimal d = 3.0M;
    Console.WriteLine(c / d); // 0.3333333333333333333333333333

    double r = 2.5;
    Console.WriteLine(Math.PI * r * r); // 19.634954084936208

}