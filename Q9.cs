

DateTime[] DOB = new DateTime[10];

for(int i =0;i < DOB.Length; i++)
{
    Console.WriteLine("Enter the DOB :");
    DateTime passengerDob = Convert.ToDateTime(Console.ReadLine());
    DOB[i] = passengerDob;

}
foreach(DateTime item in DOB)
{
    Console.WriteLine(item);
}

DateTime today = DateTime.Now;
Console.WriteLine(today);

for(int i = 0;i < DOB.Length; i++)
{
    var year = DOB[i].Year;
    int age = today.Year - year;
    Console.WriteLine("Your age is : " +age);



    switch (age)
    {
        case (< 10):
            Console.WriteLine("You are just a kid!");
            break;

        case (>= 10 and < 30):
            Console.WriteLine("You are in your Youth!");
            break;

        case (>= 30 and < 60):
            Console.WriteLine("You are in your Youth!");
            break;

        case (> 60):
            Console.WriteLine("You are Old");
            break;

    }
}
    