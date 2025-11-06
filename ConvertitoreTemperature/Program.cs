using ConvertitoreTemperature;

Console.WriteLine("=== Convertitore di Temperature ===");
Console.WriteLine();

while (true)
{
    Console.WriteLine("Seleziona la conversione:");
    Console.WriteLine("1. Celsius -> Fahrenheit");
    Console.WriteLine("2. Celsius -> Kelvin");
    Console.WriteLine("3. Fahrenheit -> Celsius");
    Console.WriteLine("4. Fahrenheit -> Kelvin");
    Console.WriteLine("5. Kelvin -> Celsius");
    Console.WriteLine("6. Kelvin -> Fahrenheit");
    Console.WriteLine("0. Esci");
    Console.WriteLine();
    Console.Write("Scelta: ");

    string? scelta = Console.ReadLine();

    if (scelta == "0")
    {
        Console.WriteLine("Arrivederci!");
        break;
    }

    Console.Write("Inserisci la temperatura: ");
    string? input = Console.ReadLine();

    if (!double.TryParse(input, out double temperatura))
    {
        Console.WriteLine("Errore: inserisci un numero valido.");
        Console.WriteLine();
        continue;
    }

    double risultato = 0;
    string unitaOrigine = "";
    string unitaDestinazione = "";

    switch (scelta)
    {
        case "1":
            risultato = TemperatureConverter.CelsiusToFahrenheit(temperatura);
            unitaOrigine = "°C";
            unitaDestinazione = "°F";
            break;
        case "2":
            risultato = TemperatureConverter.CelsiusToKelvin(temperatura);
            unitaOrigine = "°C";
            unitaDestinazione = "K";
            break;
        case "3":
            risultato = TemperatureConverter.FahrenheitToCelsius(temperatura);
            unitaOrigine = "°F";
            unitaDestinazione = "°C";
            break;
        case "4":
            risultato = TemperatureConverter.FahrenheitToKelvin(temperatura);
            unitaOrigine = "°F";
            unitaDestinazione = "K";
            break;
        case "5":
            risultato = TemperatureConverter.KelvinToCelsius(temperatura);
            unitaOrigine = "K";
            unitaDestinazione = "°C";
            break;
        case "6":
            risultato = TemperatureConverter.KelvinToFahrenheit(temperatura);
            unitaOrigine = "K";
            unitaDestinazione = "°F";
            break;
        default:
            Console.WriteLine("Scelta non valida.");
            Console.WriteLine();
            continue;
    }

    Console.WriteLine($"Risultato: {temperatura:F2} {unitaOrigine} = {risultato:F2} {unitaDestinazione}");
    Console.WriteLine();
}
