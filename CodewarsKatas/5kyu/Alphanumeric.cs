namespace CodewarsKatas
{
    public class Alphanumeric
    {
        // URL: https://www.codewars.com/kata/526dbd6c8c0eb53254000110
        public static bool Solution(string str)
        {
            return string.IsNullOrEmpty(str) ? false : str.All(x => char.IsLetterOrDigit(x));
        }

        public static void Test()
        {
            Console.WriteLine(Solution(""));
            Console.WriteLine(Solution("asdasdasdasd123123"));
            Console.WriteLine(Solution("asd.asd"));
        }
    }
}
