namespace CodewarsKatas
{ 
    public class TenMinutesWalk
    {
        // URL: https://www.codewars.com/kata/54da539698b8a2ad76000228
        public static bool Solution(string[] walk)
        {
            return walk.Length != 10 ? false : walk.Select(x => x == "n" ? 1 : x == "s" ? -1 : x == "e" ? 10 : -10).Sum() == 0;
        }

        public static void Test()
        {
            Console.WriteLine(Solution(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }));
            Console.WriteLine(Solution(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }));
            Console.WriteLine(Solution(new string[] { "n", "w", "w", "w", "n", "s", "n", "s", "n", "s" }));

            Console.WriteLine(Solution(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }));
            Console.WriteLine(Solution(new string[] { "w" }));
            Console.WriteLine(Solution(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }));
        }
    }
}
