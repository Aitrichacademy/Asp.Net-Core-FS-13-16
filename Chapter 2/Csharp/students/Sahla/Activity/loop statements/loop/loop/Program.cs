namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(int i=1; i<= 50;i++)
            //{
            //    if(i%2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            //int rev = 0;
            //while(n>0)
            //{
            //    rev = rev * 10 + n % 10;
            //    n = n / 10;
            //}
            //Console.WriteLine("Reverse of given number: "+rev);

            int sum = 0;
            int rem = 0;
            do
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }
            while (n > 0);
            Console.WriteLine("sum of digits = " + sum);

            //int fact = 1;
            //for (int i = 2; i <= n; i++)
            //{
            //    fact*=i;
            //}
            //Console.WriteLine("factorial = "+fact);


        }
    }
}
