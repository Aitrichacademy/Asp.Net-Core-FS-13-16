namespace loop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n=Convert.ToInt32(Console.ReadLine());

            //int count = 0;
            //while (n != 0)
            //{
            //    n = n / 10;
            //    count++;
            //}
            //Console.WriteLine("Count= "+count);

            //int firstnum = 0;
            //int secondnum = 1;
            //int nextnum;
            //for (int i = 1;i <= n;i++)
            //{
            //    Console.Write(firstnum+" ");
            //    nextnum=firstnum+secondnum;
            //    secondnum = firstnum;
            //    firstnum = nextnum;

            //}

            int rev = 0;
            int temp = n;
            while (n>0)
            {
                rev = rev * 10+n % 10;
                n=n/ 10;
            }
            if (rev == temp)
            {
                Console.WriteLine(temp+ "is a Palindrome");
            }
            else
            {
                Console.WriteLine(temp+ "is not a palindrome");
            }
        }
    }
}
