Console.WriteLine("Welcome, please enter your age:");
int age  = int.Parse(Console.ReadLine());
int averageLifeSpan = 90;
int weeksInLife = (averageLifeSpan - age) * 52;
int daysInLife = (averageLifeSpan - age) * 365;
int hoursInLife = daysInLife * 24;
int minutesInLife = hoursInLife * 60;
int secondsInLife = minutesInLife * 60;
Console.WriteLine($"You have {weeksInLife} weeks, {daysInLife} days, {hoursInLife} hours, {minutesInLife} minutes and {secondsInLife} seconds left in your life.");
