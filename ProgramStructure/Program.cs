// See https://aka.ms/new-console-template for more information
// A skeleton of a C# program

// 以下为顶级语句，所以不需要写Main方法
// Your program starts here:

using System.Text;

Console.WriteLine("Hello, World!");

Console.WriteLine(Environment.Version);

StringBuilder builder = new();
builder.AppendLine("The following arguments are passed:");

// Display the command line arguments using the args variable.
foreach (var arg in args)
{
    builder.AppendLine($"Argument={arg}");
}

Console.WriteLine(builder.ToString());

// Return a success code.
return 0;

// 具有顶级语句的文件还可以包含命名空间和类型定义，但它们必须位于顶级语句之后。
namespace YourNamespace
{
    class YourClass
    {
    }

    struct YourStruct
    {
    }

    interface IYourInterface
    {
    }

    delegate int YourDelegate();

    enum YourEnum
    {
    }

    namespace YourNestedNamespace
    {
        class MyClass
        {
            
        }
    }

    // 库和服务不要求使用 Main 方法作为入口点，Main 方法是应用程序启动后调用的第一个方法
    // Main 在类或结构中声明。 Main 必须是 static，它不需要是 public
    // Main 的返回类型可以是 void、int、Task 或 Task<int>
    //     public static void Main() { }
    //     public static int Main() { }
    //     public static void Main(string[] args) { }
    //     public static int Main(string[] args) { }
    //     public static async Task Main() { }
    //     public static async Task<int> Main() { }
    //     public static async Task Main(string[] args) { }
    //     public static async Task<int> Main(string[] args) { }
    // 
    // 一个应用程序只能有一个入口点。 一个项目只能有一个包含顶级语句的文件。
    /*
    class Program
    {
        static void Main(string[] args)
        {
            //Your program starts here...
            Console.WriteLine("Hello world!");
        }
    }*/
    
    /*
    class AsyncMainReturnValTest
    {
        public static void Main()
        {
            return await AsyncConsoleWork();
            //等价于 return AsyncConsoleWork().GetAwaiter().GetResult();
        }

        private static async Task<int> AsyncConsoleWork()
        {
            // Main body here
            return 0;
        }
    }*/
}