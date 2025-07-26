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
        if ((numberToEvaluate % 3) > 0)
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
}