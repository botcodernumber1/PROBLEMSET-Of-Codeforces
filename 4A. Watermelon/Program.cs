namespace Watermelon_4A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            if (n <= 2 || n % 2 != 0)
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES");
        }
    }
}