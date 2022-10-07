namespace CodewarsKatas
{
    public class TwiceAsOld
    {
        // URL: https://www.codewars.com/kata/5b853229cfde412a470000d0
        public static int Solution(int dadYears, int sonYears)
        {
            return System.Math.Abs(dadYears - 2 * sonYears);
        }

        public static void Test()
        {
            Console.WriteLine(Solution(30, 0));
            Console.WriteLine(Solution(30, 7));
            Console.WriteLine(Solution(45, 30));
        }
    }
}
