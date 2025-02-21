namespace switch_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Digit : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("select the operaator : ");
            char operation = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the Digit : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            

            switch (operation)
            {
                case '+':
                    Console.WriteLine ( "result :" + (num1 + num2 )); 
                    break;
                case '-':
                    Console.WriteLine("result :" + (num1 - num2));
                    break;
                case '/':
                    Console.WriteLine("result :" + (num1 / num2));
                    break;
                case '*':
                    Console.WriteLine("result :" + (num1 * num2));
                    break;
                default: Console.WriteLine("operation");
                    break;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
