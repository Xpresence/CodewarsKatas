namespace CodewarsKatas
{
    public class WeightClass
    {
        // URL: https://www.codewars.com/kata/55c6126177c9441a570000cc
        public static string Solution(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                return str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Where(x => !string.IsNullOrEmpty(x))
                            .OrderBy(x => x)
                            .OrderBy(x => x.ToCharArray().Sum(a => Char.GetNumericValue(a)))
                            .Aggregate((x, y) => x + " " + y);
            }
            else return "";
        }

        public static void Test()
        {
            Console.WriteLine(Solution(""));
            Console.WriteLine(Solution("56 65 74 100 99 68 86 180 90"));
            Console.WriteLine(Solution("103 123 4444 99 2000"));
            Console.WriteLine(Solution("2000 10003 1234000 44444444 9999 11 11 22 123"));
        }
    }
}
