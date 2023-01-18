// Accepting passenger date of birth

Console.WriteLine("Enter the date of birth : ");
int date = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the month : ");
int month = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the year : ");
int year = Convert.ToInt32(Console.ReadLine());

DateTime givenDate = new DateTime(year, month, date);
Console.WriteLine(givenDate);

DateTime today = DateTime.Now;//today's date
Console.WriteLine(today);
int age = today.Year - year;
Console.WriteLine("Your age is " +age);
//int age = Convert.ToInt32(Console.ReadLine());

int ageInHours = age * 8760;
Console.WriteLine("You are " + ageInHours + " Hours old!");
int ageInDays = age * 365;
Console.WriteLine("You are " + ageInDays + " Days old!");
double ageInWeeks = age * 52.176;
Console.WriteLine("You are " + ageInWeeks + " Weeks old!");
int ageInMonths = age * 12;
Console.WriteLine("You are " + ageInMonths + " Months old!");

bool f = false;
int match = Convert.ToInt32(f);
if(year % 4 == 0) { 
    Console.WriteLine("Leap Year Born!");
}
else
{
    Console.WriteLine("Not a Leap Year Born");
}
