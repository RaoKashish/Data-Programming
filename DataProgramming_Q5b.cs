Console.WriteLine("==========Question 5b==========");
Console.WriteLine("Enter the lower left corner points of first rectangle: ");
    double a1 = Convert.ToDouble(Console.ReadLine());
    double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the upper right corner points of first rectangle: ");
    double a2 = Convert.ToDouble(Console.ReadLine());
    double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the lower left corner points of second rectangle: ");
    double a3 = Convert.ToDouble(Console.ReadLine());
    double b3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the upper right corner points of second rectangle: ");
    double a4 = Convert.ToDouble(Console.ReadLine());
    double b4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the point to check: ");
    double a = Convert.ToDouble(Console.ReadLine());
    double b = Convert.ToDouble(Console.ReadLine());
static bool inside(bool ans1, bool ans2);
{
    bool ans1 = inside(a1, b1, a2, b2, a, b);
    bool ans2 = inside(a3, b3, a4, b4, a, b);
    if (ans1 == ans2)
    {
        Console.WriteLine($"The point ({a},{b}), lies in the both rectangles (({a1},{b1}), ({a2},{b2})) and (({a3},{b3}),({a4},{b4}))");
    }
    else
    {
        Console.WriteLine($"The point ({a},{b}), does not lie in the both rectangles (({a1},{b1}), ({a2},{b2})) and (({a3},{b3}),({a4},{b4}))");
    }
}