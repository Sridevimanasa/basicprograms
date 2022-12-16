namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Please enter the first number");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string secondNumber = Console.ReadLine();
            int first = Convert.ToInt32(firstNumber);
            int second = Convert.ToInt32(secondNumber);
            int sum = Calculator.Add(first, second);
            Console.WriteLine("sum = " + sum);
            AccesingFields.PrintStaticVariable();
            new AccesingFields().PrintInstanceVariable();
        }
    }
}