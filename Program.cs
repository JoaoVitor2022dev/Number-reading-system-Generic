namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many Values ?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x); 
            }

            printService.Print();
            Console.WriteLine();

            Console.WriteLine("First: " + printService.Fisrt());

            Console.WriteLine(); 
        }
    }
}
