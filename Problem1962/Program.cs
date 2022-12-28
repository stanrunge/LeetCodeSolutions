namespace Problem1962;

public abstract class Program
{
    public static void Main(string[] args)
    {
        int[] array1 = { 5,4,9 };
        int[] array2 = { 4,3,6,7 };
        
        MinStoneSum(array1, 2);
        MinStoneSum(array2, 3);
    }

    private static int MinStoneSum(int[] piles, int k)
    {
        for (var i = 0; i < k; i++)
        {
            var largestPileIndex = GetLargestPileIndex(piles);
            var removedStones = RemoveStones(piles[largestPileIndex]);

            piles[largestPileIndex] = removedStones;
        }

        var totalStones = CalculateTotalStones(piles);
        return totalStones;
    }

    private static int CalculateTotalStones(int[] piles)
    {
        var stones = 0; 
        
        foreach (var pile in piles)
        {
            stones += pile;
        }

        return stones;
    }

    private static int GetLargestPileIndex(int[] piles)
    {
        var largest = 0;
        
        for (var i = 0; i < piles.Length; i++)
        {
            if (piles[i] > largest)
            {
                largest = i;
            }
        }

        return largest;
    }
    
    private static int RemoveStones(int stones)
    {
        return (int) Math.Ceiling((double) stones / 2);
    }
}