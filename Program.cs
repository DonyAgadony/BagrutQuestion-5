class Program
{
    public static void Main()
    {
        int[] arr = [33, 0, 5, 4, 0, 17, 0, 4, 10, 0, 5, 14];
        Console.WriteLine(BiggestSum(arr));
    }
    public static int BiggestSum(int[] arr)
    {
        int BiggestSum = int.MinValue;
        int TempSum = 0;
        bool HasSeenZero = false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                if (BiggestSum < TempSum)
                {
                    BiggestSum = TempSum;
                }
                TempSum = 0;
                HasSeenZero = true;
            }
            if (HasSeenZero)
            {
                TempSum += arr[i];
            }
        }
        return BiggestSum;
    }
}