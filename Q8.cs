//Flight fares Array

decimal[] flightFares = new decimal[3];
for (int i = 0; i < flightFares.Length; i++)
{
    Console.WriteLine("Enter the Flight Fares : ");
    decimal match = Convert.ToDecimal(Console.ReadLine());
    flightFares[i] = match;
}
    foreach(decimal item in flightFares)
    {
        Console.WriteLine(item);
    }

//Destination Array

String[] destination = new string[3];
for(int j = 0; j < destination.Length; j++)
{
    Console.WriteLine("Enter the destination of Choice : ");
    string? matches = Console.ReadLine();
    destination[j] = matches;
}
foreach(string items in destination)
{
    Console.WriteLine(items);
}

Console.WriteLine("Enter the nth index: ");
int indexing = Convert.ToInt32(Console.ReadLine());

if(indexing > 2)
{
    Console.WriteLine("Invalid index");
}
else
{
    Console.WriteLine("Desination: " + destination[indexing]);
    Console.WriteLine("Flight fare: " + flightFares[indexing]);
}
