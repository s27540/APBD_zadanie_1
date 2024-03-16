// See https://aka.ms/new-console-template for more information

public class Max
{

    public static void Main(string[] args)
    {

        int[] arr = new[] {1,2,3,4,5,6,7,8};
        Console.WriteLine(getMax(arr));

        int[] bb = { 1, 2, 3, 4, 5 };
        Console.WriteLine(avg(bb));
    }

    public static int getMax(int[] arr)
    {
        return arr.Max();
    }
  
    public static double avg(int[] arr)
    {
        double result = 0.0;
        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
            Console.WriteLine(result);
        }
        return result/arr.Length;
    }
}