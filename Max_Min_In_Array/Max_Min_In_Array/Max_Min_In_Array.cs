
//Maximum and minimum of an array using Linear search:
Pair usingPair = Compute.getMinMaxUsingPair(new int[] { 22, 14, 8, 17, 35, 3 }, 6);
Pair usingLinearSearch = Compute.getMinMaxLinearSearch(new int[] { 22, 14, 8, 17, 35, 3 }, 6);
Console.WriteLine($"using Pair Max value {usingPair.max} and min value {usingPair.min}");
Console.WriteLine($"using LinearSearch Max value {usingLinearSearch.max} and min value {usingLinearSearch.min}");

public class Pair
{
    public int max;
    public int min;
}

static class Compute
{
    //Maximum and minimum of an array using Linear search:
    public static Pair getMinMaxLinearSearch(int[] a, long n)
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

    //Maximum and minimum of an array by comparing in pairs:
    //If n is odd then initialize min and max as the first element.
    //If n is even then initialize min and max as minimum and maximum of the first two elements respectively.
    //For the rest of the elements, pick them in pairs and compare their
    //maximum and minimum with max and min respectively.
    public static Pair getMinMaxUsingPair(int[] arr, int size)
    {
        Pair pair = new Pair();
        int i;
        //if array has only one element
        if (size == 1)
        {
            pair.min = arr[0];
            pair.max = arr[0];
            return pair;
        }

        //if array has even number
        if(size %2 == 0)
        {
            if (arr[0] < arr[1])
            {
                pair.min = arr[0];
                pair.max = arr[1];
            }
            else
            {
                pair.min = arr[1];
                pair.max = arr[0];
            }
            i= 2;
        }
        else
        {
            pair.min = arr[0];
            pair.max = arr[0];
            i= 1;
        }

        while(i < size-1) //{2,1, 4,12, 34,6}
        {
            if (arr[i] < arr[i + 1])
            {
                if(arr[i] < pair.min) pair.min = arr[i];
                if (arr[i+1] > pair.max) pair.max = arr[i+1];
            }
            else
            {
                if (arr[i+1] < pair.min) pair.min = arr[i+1];
                if (arr[i] > pair.max) pair.max = arr[i];
            }
            i += 2;
        }
        return pair;
    }

}