namespace NeetCode.Solutions.ArraysAndHashing;

public class LC347_TopKFrequentElements
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        return TopKFrequent_II(nums, k);
    }

    private static int[] TopKFrequent_I(int[] nums, int k)
    {
        var frequency = new Dictionary<int, int>();
        foreach (var number in nums)
        {
            if (!frequency.ContainsKey(number))
                frequency.Add(number, 0);
            frequency[number]++;
        }

        var result = frequency.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
        return result;
    }

    private static int[] TopKFrequent_II(int[] nums, int k)
    {
        var frequency = new Dictionary<int, int>();
        foreach (var number in nums)
        {
            if (!frequency.ContainsKey(number))
                frequency.Add(number, 0);
            frequency[number]++;
        }

        var queue = new PriorityQueue<int, int>();
        foreach (var pair in frequency)
        {
            queue.Enqueue(pair.Key, pair.Value);
            if (queue.Count > k)
                queue.Dequeue();
        }

        var result = new int[k];
        for (var i = 0; queue.Count > 0; i++)
            result[i] = queue.Dequeue();
        return result;
    }
}