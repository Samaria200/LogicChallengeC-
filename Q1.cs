//Q1) 10 passenger names in an array

String[] listArray = new String[5];

for (int index = 0; index < listArray.Length; index++)
{
    Console.WriteLine("Enter the name : ");
    String name = Console.ReadLine();
    listArray[index] = name;
}
foreach (string name in listArray)
{
    Console.WriteLine(name);
}
// a) alphabetical order
Array.Sort(listArray);
foreach (string name in listArray)
{
   Console.WriteLine(name);
}
// b) Reverse Order
Array.Reverse(listArray);
foreach (string name in listArray)
{
   Console.WriteLine(name);
}
// Search and display name 
Console.WriteLine("Enter the name to be found : ");
String named = Console.ReadLine();
bool flag = false;
foreach (var name in listArray)
{
   if (named == name)
   {
       flag = true;
       break;
   }

}
if (flag == true)
{
   Console.WriteLine("Matching Name Found ");

}
else
{
   Console.WriteLine("No match found");
}
// Length of names in each element
foreach (var name in listArray)
{
   Console.WriteLine(name.Length);
}
//Duplicates
bool res = false;
for (int i = 0; i < listArray.Length; i++)
{
   for (int dup = i+1; dup < listArray.Length;dup++)
   {
       if (listArray[i] == listArray[dup])
       {
           res = true;
           Console.WriteLine("Duplicates found " + listArray[i]);
       }
   }
}
if (!res)
{
   Console.WriteLine("No duplicates found ");
}

//split between names
for (int i = 0; i < 10; i++)
{
    string[] splitted = listArray[i].Split(" ");
    foreach (var name in splitted)
    {
        Console.WriteLine(name);
    }
}


