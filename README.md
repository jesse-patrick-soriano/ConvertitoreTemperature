# ConvertitoreTemperature

Un'applicazione console C# per Visual Studio 2022 che converte temperature tra diverse unità di misura (Celsius, Fahrenheit, Kelvin).

## Caratteristiche

L'applicazione supporta le seguenti conversioni:
- Celsius → Fahrenheit
- Celsius → Kelvin
- Fahrenheit → Celsius
- Fahrenheit → Kelvin
- Kelvin → Celsius
- Kelvin → Fahrenheit

## Requisiti

- .NET 8.0 SDK o superiore
- Visual Studio 2022 (opzionale)

## Come Compilare

```bash
dotnet build
```

## Come Eseguire

```bash
dotnet run --project ConvertitoreTemperature/ConvertitoreTemperature.csproj
```

## Come Testare

```bash
dotnet test
```

## Esempio di Utilizzo

Quando esegui l'applicazione, vedrai un menu interattivo:

```
=== Convertitore di Temperature ===

Seleziona la conversione:
1. Celsius -> Fahrenheit
2. Celsius -> Kelvin
3. Fahrenheit -> Celsius
4. Fahrenheit -> Kelvin
5. Kelvin -> Celsius
6. Kelvin -> Fahrenheit
0. Esci

Scelta: 1
Inserisci la temperatura: 100
Risultato: 100.00 °C = 212.00 °F
```

## Struttura del Progetto

- `ConvertitoreTemperature/` - Progetto principale con l'applicazione console
  - `TemperatureConverter.cs` - Classe statica con i metodi di conversione
  - `Program.cs` - Interfaccia utente console
- `ConvertitoreTemperature.Tests/` - Progetto di test unitari
- `ConvertitoreTemperature.sln` - File della soluzione Visual Studio

## Test Unitari

Il progetto include test unitari completi per tutte le funzioni di conversione, verificando:
- Conversioni con valori standard (0°C, 100°C, 32°F, 273.15K)
- Conversioni con valori negativi
- Accuratezza dei calcoli
