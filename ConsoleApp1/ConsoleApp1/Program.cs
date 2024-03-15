// See https://aka.ms/new-console-template for more information


public class Max
{

    public static void Main(string[] args)
    {

        int[] arr = new[] {1,2,3,4,5,6,7,8};
        Console.WriteLine(getMax(arr));

    }

    public static int getMax(int[] arr)
    {
        return arr.Max();
    }
    
    
}