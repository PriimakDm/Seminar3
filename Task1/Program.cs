internal class NewBaseType
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход пятизначное число и проверяет, 
        // является ли оно палиндромом.
        Console.Write("Input five-digital namber: ");
        int namber = Convert.ToInt32(Console.ReadLine());
        int first = (namber / 10000);
        int last = (namber % 10);
        int second = (namber / 1000 % 10);
        int fourth = (namber % 100 / 10);
        if (first == last && second == fourth)
        {
            Console.WriteLine("Your namber is palindrome");
        }
        else
        {
            Console.WriteLine("Your namber is not palindrome");
        }
    }
}

internal class Program : NewBaseType
{
}