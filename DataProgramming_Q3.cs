double a, b, c;
string x, y, z;
Console.WriteLine("==========Question 3==========");
Console.WriteLine("Enter the length of each triangle side: ");
x = Console.ReadLine();
y = Console.ReadLine();
z = Console.ReadLine();
a = Convert.ToDouble(x);
b = Convert.ToDouble(y);
c = Convert.ToDouble(z);
TriangleArea(a, b, c);
static void TriangleArea(double a, double b, double c)
{
    double s = (a + b + c) / 2;
    double result = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    Console.WriteLine("The area of a triangle: " + result);
}