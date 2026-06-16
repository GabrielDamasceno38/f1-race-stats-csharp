string driver1Name = "Max Verstappen";
double driver1Lap1 = 78.5;
double driver1Lap2 = 77.9;
double driver1Lap3 = 78.1;

string driver2Name = "Lewis Hamilton";
double driver2Lap1 = 79.0;
double driver2Lap2 = 78.4;
double driver2Lap3 = 78.7;

string driver3Name = "Kimi Antonelli";
double driver3Lap1 = 79.6;
double driver3Lap2 = 79.1;
double driver3Lap3 = 78.9;

string driver4Name = "Fernando Alonso";
double driver4Lap1 = 79.8;
double driver4Lap2 = 79.3;
double driver4Lap3 = 79.0;

string driver5Name = "Charles Leclerc";
double driver5Lap1 = 78.2;
double driver5Lap2 = 77.8;
double driver5Lap3 = 78.3;

double driver1FuelPerLap = 1.85;
int driver1PitStops = 2;

double driver2FuelPerLap = 1.90;
int driver2PitStops = 2;

double driver3FuelPerLap = 1.95;
int driver3PitStops = 3;

double driver4FuelPerLap = 1.88;
int driver4PitStops = 3;

double driver5FuelPerLap = 1.82;
int driver5PitStops = 2;

double driver1TotalTime = driver1Lap1 + driver1Lap2 + driver1Lap3;
double driver1TotalFuel = driver1FuelPerLap * 3;

double driver2TotalTime = driver2Lap1 + driver2Lap2 + driver2Lap3;
double driver2TotalFuel = driver2FuelPerLap * 3;

double driver3TotalTime = driver3Lap1 + driver3Lap2 + driver3Lap3;
double driver3TotalFuel = driver3FuelPerLap * 3;

double driver4TotalTime = driver4Lap1 + driver4Lap2 + driver4Lap3;
double driver4TotalFuel = driver4FuelPerLap * 3;

double driver5TotalTime = driver5Lap1 + driver5Lap2 + driver5Lap3;
double driver5TotalFuel = driver5FuelPerLap * 3;

Console.WriteLine("=== Corrida F1 - Resultado (3 voltas) ===\n");
Console.WriteLine("Piloto\t\t\tTempo Total\tCombustivel\tPit Stops");
Console.WriteLine($"{driver1Name}\t\t{driver1TotalTime:F1}s\t\t{driver1TotalFuel:F2}L\t\t{driver1PitStops}");
Console.WriteLine($"{driver2Name}\t\t{driver2TotalTime:F1}s\t\t{driver2TotalFuel:F2}L\t\t{driver2PitStops}");
Console.WriteLine($"{driver3Name}\t\t{driver3TotalTime:F1}s\t\t{driver3TotalFuel:F2}L\t\t{driver3PitStops}");
Console.WriteLine($"{driver4Name}\t\t{driver4TotalTime:F1}s\t\t{driver4TotalFuel:F2}L\t\t{driver4PitStops}");
Console.WriteLine($"{driver5Name}\t\t{driver5TotalTime:F1}s\t\t{driver5TotalFuel:F2}L\t\t{driver5PitStops}");
