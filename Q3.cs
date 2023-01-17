using System;

//creating an array
double[] listsArray = new double[10];
for (int m = 0; m < listsArray.Length; m++)
{
    Console.WriteLine("Enter the fares : ");
    double names = Convert.ToDouble(Console.ReadLine());
    listsArray[m] = names;
    Console.WriteLine(names);
}
//array in ascending order
Array.Sort(listsArray);
foreach (double name in listsArray)
{
    Console.WriteLine(name);
}
//array in descending order
Array.Reverse(listsArray);
foreach (double name in listsArray)
{
    Console.WriteLine(name);
}
//search an array
bool res1 = false;//creating a flag
Console.WriteLine("Enter the fare price to be searched :");
double match = Convert.ToDouble(Console.ReadLine());
for (int k = 0; k < listsArray.Length; k++)
{

    if (match == listsArray[k])
    {
        res1 = true;
        Console.WriteLine("Match Found :" +match);
        break;
    }

}
if (!res1)
{
    Console.WriteLine("No match found");
}
// min 
Array.Sort(listsArray);
Console.WriteLine("Min value is : " +listsArray[0]);
//max
Array.Reverse(listsArray);
Console.WriteLine("Max value is : " +listsArray[0]);
//duplicates
bool res2 = false;
for (int z = 0; z < listsArray.Length; z++)
{
    for (int y = z + 1; y < listsArray.Length; y++)
    {
        if (listsArray[z] == listsArray[y])
        {
            res2 = true;
            Console.WriteLine("Duplicate Found : " + listsArray[z]);
        }
    }
}
if (!res2)
{
    Console.WriteLine("No Duplicates");
}