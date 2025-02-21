namespace arrayqstn2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers=new int[5];
            numbers[0] = 12;
            numbers[1] = 13;
            numbers[2] = 14;
            numbers[3] = 15;
            numbers[4] = 16;
            int n=numbers.Length;
            int sum = 0;
            for (int i = 0; i <n ; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
            int avg=sum/n;
            Console.WriteLine(avg);

            Console.ReadLine();
        }
    }
}
