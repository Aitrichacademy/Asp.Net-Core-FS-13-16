namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(int i=0;i<=5;i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 0;
            //while (i <= 6)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i < 10);

            //string[] names = { "sahla", "sahana", "Arjun", "Akhil", "Ajmal","Karthik" };
            //foreach(string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Questions
            //for(int i=2;i<=50;i++)
            //{
            //    if(i%2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            Console.WriteLine("Enter 2 digit number");
            int n = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            int rem;
            while (n > 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine(rev);

            //Console.WriteLine("Enter a number");
            //int num=Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int rem;
            //do
            //{
            //    rem = num % 10;
            //    sum += rem;
            //    num = num / 10;
            //}
            //while (num > 0);
            //Console.WriteLine(sum);

            //Console.WriteLine("Enter a number");
            //int n=Convert.ToInt32(Console.ReadLine());
            //double fact = 1;
            //for (int i = 2;i<=n;i++)
            //{
            //    fact *= i;
            //}
            //Console.WriteLine(fact);


            //Console.WriteLine("Enter numbers:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //while (n != 0)
            //{
            //    n = n / 10;
            //    count++;

            //}
            //Console.WriteLine(count);

            //Console.WriteLine("Enter a number:");
            //int n=Convert.ToInt32(Console.ReadLine());
            //int n1 = 0;
            //int n2 = 1;
            //int n3;
            //Console.WriteLine(n1+""+n2+"");
            //int i = 2;
            //do
            //{
            //    n3 = n1 + n2;
            //    n1= n2;
            //    n2 = n3;
            //}
            //while (i<n);
            //Console.WriteLine(n3+"");


            //int[] numbers = { 10,9,8,7,6 };
            //int sum = 0;
            //foreach (int number in numbers)
            //{
            //   sum+= number;
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 1, 2, 3, 4, 5, };
            //foreach (int number in numbers)
            //{
            //    if (number[0] > number)
            //    {

            //    }
            //}


            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            int rem;
            int temp = num;
            while (num != 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            if (temp == rev)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

            
        }
    }
}
