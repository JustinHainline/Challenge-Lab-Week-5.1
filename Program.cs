namespace Challenge_Lab_Week_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {2, 2, 6, 5, 3, 5};
            int singleNumber = SingleNumber(myArray);

            if (singleNumber != -1)
            {
                Console.WriteLine($"{ singleNumber}");
            }
            else
            {
                Console.WriteLine("All elements appear twice.");
            }
        }

        static int SingleNumber(int[] myArray)
        {
            Dictionary<int, int> numberCount = new Dictionary<int, int>();

            foreach (int num in myArray)
            {
                if (numberCount.ContainsKey(num))
                {
                    numberCount[num]++;
                }
                else
                {
                    numberCount[num] = 1;
                }
            }
            foreach (var kvp in  numberCount)
            {
                if (kvp.Value == 1)
                {
                    return kvp.Key;
                }
            }
            return -1;
        }
    }
}
