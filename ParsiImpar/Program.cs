namespace ParsiImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("Numar intreg= ");
            x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Numarul este par");
            }
            else
            {
                Console.WriteLine("Numarul este impar");
            }
        }
    }
}