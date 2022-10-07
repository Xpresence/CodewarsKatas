namespace CodewarsKatas
{
    public class RemoveFirstLast
    {
        // URL: https://www.codewars.com/kata/56bc28ad5bdaeb48760009b0
        public static string Solution(string s)
        {
            return s.Remove(s.Length - 1, 1).Remove(0, 1);
        }
        public static string Solution2(string s)
        {
            return s.Substring(1, s.Length - 2);
        }

        public static void Test()
        {
            Console.WriteLine(Solution("eloquent"));
            Console.WriteLine(Solution2("eloquent"));
        }
    }
}
