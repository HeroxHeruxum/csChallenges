namespace services;

public class FizzBuzzService
{
    public static void PrintFizzBuzzFor(int maxNumber)
    {
        for (int i = 0; i <= maxNumber; i++)
        {
            var resultToPrint = CreateFizzBuzzForNumber(i);
            Console.WriteLine(resultToPrint);
        }

    }

    public static string CreateFizzBuzzForNumber(int numberToEvaluate)
    {
        string result = numberToEvaluate + ": ";
        if (IsDividableBy3(numberToEvaluate))
        {
            result += "Fizz";
        }
        if ((numberToEvaluate % 5) > 0)
        {
            result += "Buzz";
        }
        // trim result for beauty :)
        return result.Trim();
    }
    public static Boolean IsDividableBy3(int number)
    {
        return !((number % 3) > 0);
    }
}