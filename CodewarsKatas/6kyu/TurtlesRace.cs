namespace CodewarsKatas
{
    public class TurtlesRace
    {
        // URL: https://www.codewars.com/kata/55e2adece53b4cdcb900006c
        public static int[] Solution(int v1, int v2, int g)
        {
            return new int[3] { g / (v2 - v1), (int)(((double)g % (v2 - v1)) * 60), (int)((((double)g / (v2 - v1)) % 1 * 60) % 1 * 60) };
        }

        public static void Test()
        {
            Console.WriteLine(Solution(720, 850, 70));
            Console.WriteLine(Solution(80, 91, 37));
            Console.WriteLine(Solution(80, 100, 40));
        }
    }
}
