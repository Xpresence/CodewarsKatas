namespace CodewarsKatas
{
    public class Multiples3or5
    {
        // URL: https://www.codewars.com/kata/514b92a657cdc65150000006
        public static int Solution(int value)
        {
            var sum = 0;
            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        public static int Solution2(int value)
        {
            return Enumerable.Range(0, value).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
        }

        public static void Test()
        {
            Console.WriteLine(Solution(10));
            Console.WriteLine(Solution2(10));
        }
    }
}
