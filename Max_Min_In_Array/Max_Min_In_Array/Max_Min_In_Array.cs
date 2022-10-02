
Pair pair = Compute.getMinMax(new int[] { 1,1},2);
Console.WriteLine($"Max value {pair.max} and min value {pair.min}");

public class Pair
{
    public int max;
    public int min;
}

static class Compute
{
    public static Pair getMinMax(int[] a, long n)
    {
        Pair pair = new Pair();

        //if array has only one elements
        if (n == 1)
        {
            pair.min = a[0];
            pair.max = a[0];
            return pair;
        }
        //if array has more than one elements
        if (a[0] >= a[1])
        {
            pair.min = a[1];
            pair.max = a[0];
        }
        else if(a[0] < a[1])
        {
            pair.min = a[0];
            pair.max = a[1];
        }
        if(n >= 2)
        {
            for (int i = 2; i <= n - 1; i++)
            {
                if (pair.min > a[i])
                {
                    pair.min = a[i];
                    continue;
                }
                if (pair.max < a[i])
                {
                    pair.max = a[i];
                }
            }
        }
        return pair;
    }
}