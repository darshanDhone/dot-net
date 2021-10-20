using System;

namespace DelegateDemoMastek
{
    //1
    delegate int CalculatorDelegate(int first, int second);

    class Program
    {
        //2
        static int AddNumbers(int number1,int number2)
        {
            return number1 + number2;
        }
        static int MultiplyNumbers(int number1,int number2)
        {
            return number1*number2;
        }
        static void Main(string[] args)
        {
            //3
            //CalculatorDelegate demo1 = new CalculatorDelegate(AddNumbers);
            CalculatorDelegate demo1 = AddNumbers;
            CalculatorDelegate demo2 = MultiplyNumbers;
            int result = demo1(10, 20);
            
            Console.WriteLine("Addition: "+result);
            Console.WriteLine("Multiplication "+ demo2(2, 5));

            //merge step 2 and 3
            CalculatorDelegate demo3 = (a, b) => a + b;
            int result3 = demo3(4,5);
            Console.WriteLine(result3);

            demo3 = (a, b) => a - b;
            int result4 = demo3(6, 2);
            Console.WriteLine(result4);

            CalculatorDelegate demo5 = (a, b) => a * b;
            int result5 = demo5(10, 5);
            Console.WriteLine(result5);

            CalculatorDelegate demo6 = (a, b) => a / b;
            int result6 = demo6(20, 5);
            Console.WriteLine(result6);
        }
    }
}
