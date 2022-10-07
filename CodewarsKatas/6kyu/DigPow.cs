namespace CodewarsKatas
{
    public class DigPow
    {
        // URL: https://www.codewars.com/kata/5552101f47fc5178b1000050
        public static long Solution(int n, int p)
        {
            var list = new List<int>();
            var v = n;
            while (v != 0)
            {
                list.Add(v % 10);
                v = v / 10;
            }

            list.Reverse();

            foreach (var item in list)
            {
                v += (int)Math.Pow(item, p);
                p++;
            }

            if (v % n == 0)
            {
                return v / n;
            }
            else return -1;
        }

        public static void Test()
        {
            Console.WriteLine(Solution(89, 1));
        }
    }
}
