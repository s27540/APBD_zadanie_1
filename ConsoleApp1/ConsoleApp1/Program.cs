// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        int[] bb = { 1, 2, 3, 4, 5 };
        Console.WriteLine(avg(bb));
    }
    public static double avg(int[] arr)
    {
        double result = 0.0;
        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
        }
        return result/arr.Length;
    }
}