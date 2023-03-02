internal class Program
{
    private static void Main(string[] args)
    {
        int[] test = InsertionSort(new int[] { 2, 42, 1, 204, 456, 23, 235, 6454, 7567 }, 8);

        foreach (int num in test)
        {
            Console.WriteLine(num);
        }
    }

    static int[] InsertionSort(int[] s, int n)
    {
        int i, j;

        for (i = 1; i < n; i++)
        {
            j = i;
            while ((j > 0) && (s[j] < s[j - 1]))
            {
                var holder = s[j];
                s[j] = s[j - 1];
                s[j - 1] = holder;

                j = j - 1;
            }
        }
        return s;

    }
}
