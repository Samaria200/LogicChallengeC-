//Accept Passenger name 
Console.WriteLine("Enter the passenger name : ");
string? passengerName = Console.ReadLine();

//Accept total miles travelled 
Console.WriteLine("Enter the total miles travelled : ");
int milesTravelled = Convert.ToInt32(Console.ReadLine());


switch (milesTravelled)
{
    case (>= 10000 and < 20000):
        Console.WriteLine("You are awarded with 10 flyer points!");
        break;
    case (>= 20000 and < 30000):
        Console.WriteLine("You are awarded with 20 flyer points!");
        break;
    case (>= 50000 and < 100000):
        Console.WriteLine("You are awarded with 30 flyer points!");
        break;
    case (>= 100000):
        Console.WriteLine("You are awarded with 50 flyer points!");
        break;
    default:
        Console.WriteLine(+milesTravelled + "is not right!");
        break;

}

