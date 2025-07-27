namespace fizzBuzz;

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
        if (IsDividableBy(numberToEvaluate, 3))
        {
            result += "Fizz";
        }
        if (IsDividableBy(numberToEvaluate, 5))
        {
            result += "Buzz";
        }
        // trim result for beauty :)
        return result.Trim();
    }
    public static bool IsDividableBy(int number, int divider)
    {
        return number % divider == 0;
    }
}
