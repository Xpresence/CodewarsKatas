namespace CodewarsKatas
{
    public class PerfectPower
    {
        // URL: https://www.codewars.com/kata/54d4c8b08776e4ad92000835
        public static (int, int)? Solution(int n)
        {
            for (int m = 2; m <= Math.Round(Math.Sqrt(n), MidpointRounding.ToEven); m++)
            {
                if (n % m == 0)
                {
                    for (int k = 2; k <= Math.Round(Math.Sqrt(n), MidpointRounding.ToEven); k++)
                    {
                        if (Math.Pow(m, k) == n)
                        {
                            return (m, k);
                        }
                    }
                }
            }

            return null;
        }

        public static void Test()
        {
            Console.WriteLine(Solution(0));
            Console.WriteLine(Solution(1));
            Console.WriteLine(Solution(2));
            Console.WriteLine(Solution(3));
            Console.WriteLine(Solution(4));
            Console.WriteLine(Solution(5));
            Console.WriteLine(Solution(8));
            Console.WriteLine(Solution(9));

            var test = new int[] { 4, 8, 9, 16, 25, 27, 32, 36, 49, 64, 81, 100, 121, 125, 128, 144, 169, 196, 216, 225, 243, 256, 289, 324, 343, 361, 400, 441, 484 };
            foreach (var i in test)
            {
                Console.WriteLine(Solution(i));
            }
        }
    }
}
