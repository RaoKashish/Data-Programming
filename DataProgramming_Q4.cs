public class ProblemSet1
{
    public static void Main()
    {
        int[] arr1 = new int[10];
        int[] arr2 = new int[10];
        int[] arr3 = new int[10];
        int a, b = 0, c = 0, d;
        Console.WriteLine("==========Question 4==========");
        Console.Write("Input the number of elements to be stored in the array: ");
        d = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input {0} elements in the array: \n", d);
        for (a = 0; a < d; a++)
        {
            Console.Write("Element {0}: ", a);
            arr1[a] = Convert.ToInt32(Console.ReadLine());
        }
        for (a = 0; a < d; a++)
        {
            if (arr1[a] % 2 == 0)
            {
                arr2[b] = arr1[a];
                b++;
            }
            else
            {
                arr3[c] = arr1[a];
                c++;
            }
        }
        Console.Write("The even elements are: \n");
        for (a = 0; a < b; a++)
        {
            Console.Write("{0} ", arr2[a]);
        }
        Console.Write("\nThe odd elements are: \n");
        for (a = 0; a < c; a++)
        {
            Console.Write("{0} ", arr3[a]);
        }
    }
}