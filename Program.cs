using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates

{
    delegate void Message();
    delegate int Operation(int x, int y);
    delegate T Operation<T, K>(K val);
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { };
            list.Add("aabmnlhh");
            list.Add("kabmnlllh");
            list.Add("kjurfh");
            list.Add("bmnlujfj");
            list.Add("lllmnlju");
            list.Add("lmhtaa");
            Console.WriteLine(list._LastOrDefault(x => x.Contains("mnl")));
            Console.WriteLine(list._Count(x => x.Contains("mnl")));

            Message mes;
            mes = Hello;
            mes();
            void Hello() => Console.WriteLine("Hello");
            Message message1 = Welcome.Print;
            Message message2 = new Hello().Display;
            message1();
            message2();

            Operation operation = Add;
            int result = operation(4, 5);
            Console.WriteLine(result);

            operation = Multiply;
            result = operation(4, 5);
            Console.WriteLine(result);

            Operation operation1 = Add;
            Operation operation2 = new Operation(Add);

            Message message = Hello;
            message += HowAreYou;
            message();
            void HowAreYou() => Console.WriteLine("How are you?");

            mes.Invoke();
            Operation op = Add;
            int n = op.Invoke(3, 4);
            Console.WriteLine(n);

            Operation<decimal, int> squareOperation = Square;
            decimal result1 = squareOperation(5);
            Console.WriteLine(result1);

            Operation<int, int> doubleOperation = Double;
            int result2 = doubleOperation(5);
            Console.WriteLine(result2);

            decimal Square(int k) => k * k;
            int Double(int k) => k + k;
            DoOperation(5, 4, Add);
            DoOperation(5, 4, Subtract);
            DoOperation(5, 4, Multiply);

            void DoOperation(int a, int b, Operation op1)
            {
                Console.WriteLine(op1(a, b));
            }
            int Add(int x, int y) => x + y;
            int Subtract(int x, int y) => x - y;
            int Multiply(int x, int y) => x * y;

        }
        class Welcome
        {
            public static void Print() => Console.WriteLine("Welcome");
        }
        class Hello
        {
            public void Display() => Console.WriteLine("Привет");
        }
    }
}

