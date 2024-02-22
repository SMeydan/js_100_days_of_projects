Console.WriteLine("Welcome, please enter your age:");
int age  = int.Parse(Console.ReadLine());
averageLifeSpan = 90;
weeksInLife = (averageLifeSpan - age) * 52;
daysInLife = (averageLifeSpan - age) * 365;
hoursInLife = daysInLife * 24;
minutesInLife = hoursInLife * 60;
secondsInLife = minutesInLife * 60;
Console.WriteLine($"You have {weeksInLife} weeks, {daysInLife} days, {hoursInLife} hours, {minutesInLife} minutes and {secondsInLife} seconds left in your life.");
