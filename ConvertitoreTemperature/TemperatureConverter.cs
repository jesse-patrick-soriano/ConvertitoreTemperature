namespace ConvertitoreTemperature;

public static class TemperatureConverter
{
    /// <summary>
    /// Converte una temperatura da Celsius a Fahrenheit.
    /// </summary>
    /// <param name="celsius">La temperatura in gradi Celsius.</param>
    /// <returns>La temperatura convertita in gradi Fahrenheit.</returns>
    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    /// <summary>
    /// Converte una temperatura da Celsius a Kelvin.
    /// </summary>
    /// <param name="celsius">La temperatura in gradi Celsius.</param>
    /// <returns>La temperatura convertita in Kelvin.</returns>
    public static double CelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }

    /// <summary>
    /// Converte una temperatura da Fahrenheit a Celsius.
    /// </summary>
    /// <param name="fahrenheit">La temperatura in gradi Fahrenheit.</param>
    /// <returns>La temperatura convertita in gradi Celsius.</returns>
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    /// <summary>
    /// Converte una temperatura da Fahrenheit a Kelvin.
    /// </summary>
    /// <param name="fahrenheit">La temperatura in gradi Fahrenheit.</param>
    /// <returns>La temperatura convertita in Kelvin.</returns>
    public static double FahrenheitToKelvin(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9 + 273.15;
    }

    /// <summary>
    /// Converte una temperatura da Kelvin a Celsius.
    /// </summary>
    /// <param name="kelvin">La temperatura in Kelvin.</param>
    /// <returns>La temperatura convertita in gradi Celsius.</returns>
    public static double KelvinToCelsius(double kelvin)
    {
        return kelvin - 273.15;
    }

    /// <summary>
    /// Converte una temperatura da Kelvin a Fahrenheit.
    /// </summary>
    /// <param name="kelvin">La temperatura in Kelvin.</param>
    /// <returns>La temperatura convertita in gradi Fahrenheit.</returns>
    public static double KelvinToFahrenheit(double kelvin)
    {
        return (kelvin - 273.15) * 9 / 5 + 32;
    }
}
