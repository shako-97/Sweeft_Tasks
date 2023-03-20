namespace Tasks.Sweeft.App
{
    public class Exercises
    {
        public static Boolean IsPalindrome(string text)
        {
            char[] array = text.ToLower().ToCharArray();

            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - 1 - i])
                    return false;
            }

            return true;
        }

        public static int MinSplit(int amount)
        {
            int[] coins = { 50, 20, 10, 5, 1 };
            int count = 0;

            for (int i = 0; i < coins.Length; i++)
            {
                count += amount / coins[i];
                amount = amount % coins[i];
            }

            return count;
        }

        public static int NotContains(int[] array)
        {
            Array.Sort(array);
            int minNumber = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == minNumber) minNumber++;
                if (array[i] > minNumber) break;
            }

            return minNumber;
        }

        public static Boolean IsProperly(string sequence)
        {
            int openCount = 0;
            int closeCount = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == '(') openCount++;
                if (sequence[i] == ')') closeCount++;

                if (openCount < closeCount)
                    return false;
            }

            return openCount == closeCount ? true : false;
        }

        public static int CountVariants(int stearsCount)
        {
            if (stearsCount < 0)
                throw new Exception("Wrong digit!");
            if (stearsCount <= 1)
                return 1;

            return CountVariants(stearsCount - 1) + CountVariants(stearsCount - 2);
        }
    }
}
