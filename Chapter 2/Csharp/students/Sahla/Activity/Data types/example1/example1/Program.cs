namespace example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> num1 = new List<int> { 1,2,3,4};
            List<int> num2 = num1;
            num2.Add(5);
            num2.Remove(3);
            Console.WriteLine(string.Join(", ", num2));


            Dictionary<int,string> Students = new Dictionary<int,string>();
            Students.Add(1, "sahana");
            Students.Add(2, "Sahla");
            Students.Add(3, "Karthik");
            Students.Add(4, "Akhil");
            Students.Add(5, "Basith");
            Students.Add(6, "Ajmal");
            Students.Add(7, "Arjun");

            Console.WriteLine("Student Names :");
            foreach (var item in Students)
            {
                Console.WriteLine($"Id : {item.Key} Name : {item.Value}");
            }

          
        }
    }
}
