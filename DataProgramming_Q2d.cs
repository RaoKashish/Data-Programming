string[] names = new string[7] { "Berlioz", "Borodin", "Brian", "Bartok", "Bellini", "Buxtehude", "Bernstein" };
Array.Sort(names);
Console.WriteLine("==========Question 2d==========");
Console.WriteLine("Sorted array: ");
foreach (string name in names)
{
    Console.WriteLine(name);
}
Console.WriteLine("First name: " + names[0]);
Console.WriteLine("Last name: " + names[6]);