namespace ConvertitoreTemperature.Tests;

public class TemperatureConverterTests
{
    [Fact]
    public void CelsiusToFahrenheit_ZeroCelsius_Returns32Fahrenheit()
    {
        var result = TemperatureConverter.CelsiusToFahrenheit(0);
        Assert.Equal(32, result, 2);
    }

    [Fact]
    public void CelsiusToFahrenheit_100Celsius_Returns212Fahrenheit()
    {
        var result = TemperatureConverter.CelsiusToFahrenheit(100);
        Assert.Equal(212, result, 2);
    }

    [Fact]
    public void CelsiusToKelvin_ZeroCelsius_Returns27315Kelvin()
    {
        var result = TemperatureConverter.CelsiusToKelvin(0);
        Assert.Equal(273.15, result, 2);
    }

    [Fact]
    public void FahrenheitToCelsius_32Fahrenheit_ReturnsZeroCelsius()
    {
        var result = TemperatureConverter.FahrenheitToCelsius(32);
        Assert.Equal(0, result, 2);
    }

    [Fact]
    public void FahrenheitToKelvin_32Fahrenheit_Returns27315Kelvin()
    {
        var result = TemperatureConverter.FahrenheitToKelvin(32);
        Assert.Equal(273.15, result, 2);
    }

    [Fact]
    public void KelvinToCelsius_27315Kelvin_ReturnsZeroCelsius()
    {
        var result = TemperatureConverter.KelvinToCelsius(273.15);
        Assert.Equal(0, result, 2);
    }

    [Fact]
    public void KelvinToFahrenheit_27315Kelvin_Returns32Fahrenheit()
    {
        var result = TemperatureConverter.KelvinToFahrenheit(273.15);
        Assert.Equal(32, result, 2);
    }

    [Fact]
    public void CelsiusToFahrenheit_NegativeValue_ConvertsCorrectly()
    {
        var result = TemperatureConverter.CelsiusToFahrenheit(-40);
        Assert.Equal(-40, result, 2);
    }
}