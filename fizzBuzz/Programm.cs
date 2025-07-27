using fizzBuzz;

Console.WriteLine("Welcome to FizzBuzz! Please enter the Max Number for the FizzBuzz Logic!");

int maxNumber = Convert.ToInt32(Console.ReadLine());

FizzBuzzService.PrintFizzBuzzFor(maxNumber);