public class addeventoarray
    {
    public static List<int> listevennumbers(int[] array)
    {
        List<int> intList = new List<int>();
        int[] intArray = { };
        foreach (var num in array)
        {
            if(num % 2 == 0)
            {
                intList.Add(num);
                //intArray.Append(num);
            }
        }
        //Console.WriteLine($"List = [{intList}] and Array = [{intArray}]");
        return intList;
    }
    static void clear()
    {
        int[] array = { 1, 2, 3, 4, 5, 6 };
        List<int> arrayList = listevennumbers(array);
        foreach (var num in arrayList)
        {
            Console.WriteLine($"[{num}]");
        }
    
    }
}
