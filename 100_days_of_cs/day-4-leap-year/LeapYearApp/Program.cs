Console.WriteLine("Welcome to the Leap Year App");
Console.WriteLine("Please enter a year to check if it is a leap year:");
int year = int.Parse(Console.ReadLine());
if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
{
    Console.WriteLine($"{year} is a leap year.");
}
else
{
    Console.WriteLine($"{year} is not a leap year.");
}
