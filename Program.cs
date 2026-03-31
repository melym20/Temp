using System;

class WeatherApp
{
    static void Main()
    {
        // 1. Define variables with the required test values
        double[] testValues = { 35.5, 30.5, 22.2, 16.1, 7.3, -1.0 };

        foreach (double celsius in testValues)
        {
            // 2. Call the conversion function
            int fahrenheit = ConvertCelsiusToFahrenheit(celsius);

            // 3. Call the weather statement function
            string statement = GetWeatherStatement(fahrenheit);

            // 4. Display the results
            Console.WriteLine($"The temperature is {celsius}C or {fahrenheit}F. {statement}");
        }
    }

    /// <summary>
    /// Converts Celsius to Fahrenheit and rounds to the nearest integer.
    /// </summary>
    static int ConvertCelsiusToFahrenheit(double celsius)
    {
        // Formula: TempF = TempC * 9/5 + 32
        double rawFahrenheit = (celsius * 9 / 5) + 32;

        // Applying the hint: add 0.5 before converting to int for rounding
        return (int)(rawFahrenheit + 0.5);
    }

    /// <summary>
    /// Returns a weather advisory string based on Fahrenheit temperature.
    /// </summary>
    static string GetWeatherStatement(int fahrenheit)
    {
        if (fahrenheit >= 95)
            return "A heat advisory has been issued.";
        if (fahrenheit >= 85)
            return "Pleasant but warm.";
        if (fahrenheit >= 70)
            return "Very pleasant weather today.";
        if (fahrenheit >= 50)
            return "Pleasant but cool.";
        if (fahrenheit >= 33)
            return "Cold weather.";
        else
            return "A freeze warning has been issued.";
    }
}
