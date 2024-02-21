Console.WriteLine("Welcome to the BMI calculator program");
float weight, height, bmi;

Console.WriteLine("Enter your weight in kg: ");
weight = float.Parse(Console.ReadLine());

Console.WriteLine("Enter your height in m: ");
height = float.Parse(Console.ReadLine());

bmi = weight / (height * height);

if (bmi < 18.5)
    Console.WriteLine($"Your BMI is {bmi}. You are underweight.");
else if( bmi < 24.9)
    Console.WriteLine($"Your BMI is {bmi}. You are normal weight.");
else if( bmi < 29.9)
    Console.WriteLine($"Your BMI is {bmi}. You are overweight.");
else if( bmi >= 30)
    Console.WriteLine($"Your BMI is {bmi}. You are obese.");
else
    Console.WriteLine("Invalid input");
