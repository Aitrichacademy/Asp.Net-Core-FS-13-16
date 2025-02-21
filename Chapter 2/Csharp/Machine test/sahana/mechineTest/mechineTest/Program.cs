namespace mechineTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] sales= new double[7];
            double totalsale = 0;
            double high = 0;
            double low = 0;
            double sum = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"enter the week:{i+1}");
                sales[i] = double.Parse( Console.ReadLine() );
                totalsale += sales[i];
                
            }

            
            foreach(double temp in sales)
            {
                if(temp < high)
                {
                    high = temp;
                }
                high = sales.Max();
                if(temp > low)
                {
                    low = temp;
                }
                low = sales.Min();

             sum=sum + temp;
                
            }
            double avg = sum / 7;
            Console.WriteLine($"highest is week:{high}");
            Console.WriteLine($"lowest is week:{low}");
            Console.WriteLine($"average :{avg}");
            
        }
    }
}
