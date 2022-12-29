namespace Problem2469;

public abstract class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(ConvertTemperature(36.50));
    }
    
    private static double[] ConvertTemperature(double celsius)
    {
        var answer = new double[2];

        answer[0] = ConvertCelsiusToKelvin(celsius);
        answer[1] = ConvertCelciusToFahrenheit(celsius);

        return answer;
    }

    private static double ConvertCelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }

    private static double ConvertCelciusToFahrenheit(double celsius)
    {
        return celsius * 1.8 + 32;
    }
}