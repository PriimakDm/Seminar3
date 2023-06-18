internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход число (N) 
        // и выдаёт таблицу кубов чисел от 1 до N.
        void Cube(int numN)
        {
            int current = 1;
            while (current <= numN)
            {
                double result = Math.Pow(current, 3);
                Console.Write($"{result:f0}, ");
                current++;
            }
            Console.WriteLine("\b\b.");
        }
        void CubeNeg(int numN)
        {
            int current = 1;
            while (current >= numN)
            {
                double result = Math.Pow(current, 3);
                Console.Write($"{result:f0}, ");
                current--;
            }
            Console.WriteLine("\b\b.");
        }
        Console.Write("Input namber: ");
        int nam = Convert.ToInt32(Console.ReadLine());
        if (nam > 0)
            Cube(nam);
        else CubeNeg(nam);
    }
}