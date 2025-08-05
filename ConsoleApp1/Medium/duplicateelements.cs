public class DuplicateElementsProg
{
    public static int[] DuplicateElements(int[] input)
    {
        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
        foreach (var num in input)
        {
            if (keyValuePairs.ContainsKey(num))
            {
                keyValuePairs[num]++;
            }
            else
            {
                keyValuePairs[num] = 1;
            }
        }
        return keyValuePairs.Where(k => k.Value > 1)
            .Select(k => k.Key)
            .ToArray();

    }
    static void penguin()
    {
        int[] input = { 1, 2, 3, 2, 4, 5, 1 };
        int[] duplicatElement = DuplicateElements(input);
        foreach (var num in duplicatElement)
        {
            Console.WriteLine(num);
        }

    }
}
