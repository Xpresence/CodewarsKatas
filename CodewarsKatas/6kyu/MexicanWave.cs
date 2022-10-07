namespace CodewarsKatas
{
    public class MexicanWave
    {
        // URL: https://www.codewars.com/kata/58f5c63f1e26ecda7e000029
        public static List<string> Solution(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return new List<string> { };
            }

            var list = new List<string> { };
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    list.Add(str.Substring(0, i) + char.ToUpper(str[i]) + str.Substring(i + 1));
                }
            }

            return list;
        }

        public static void Test()
        {
            Console.WriteLine(Solution(""));
            Console.WriteLine(Solution("hello"));
            Console.WriteLine(Solution("codewars"));
            Console.WriteLine(Solution("two words"));
            Console.WriteLine(Solution(" gap "));
        }
    }
}
