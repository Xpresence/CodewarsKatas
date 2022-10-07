namespace CodewarsKatas
{
    public class CarMileage
    {
        // URL: https://www.codewars.com/kata/52c4dd683bfd3b434c000292
        public static int Solution(int number, List<int> awesomePhrases)
        {
            if (number < 98)
            {
                return 0;
            }
            else if (number >= 98 && number < 100)
            {
                return 1;
            }

            if (CheckNumber(number, awesomePhrases))
            {
                return 2;
            }

            if (CheckNumber(number + 1, awesomePhrases) || CheckNumber(number + 2, awesomePhrases))
            {
                return 1;
            }

            return 0;
        }

        public static bool CheckNumber(int number, List<int> awesomePhrases)
        {
            return IsFollowedByAllZeros(number.ToString()) || IsSameNumber(number.ToString()) || IsIncrementSequenсe(number.ToString()) || IsDecrementSequence(number.ToString()) || IsPalindrome(number.ToString()) || IsAwesomePhrase(number, awesomePhrases);

        }

        public static bool IsFollowedByAllZeros(string str)
        {
            return str.Substring(1).All(c => c == '0');
        }

        public static bool IsSameNumber(string str)
        {
            return str.All(c => c == str.First());
        }

        public static bool IsPalindrome(string str)
        {
            return str.SequenceEqual(str.Reverse());
        }

        public static bool IsAwesomePhrase(int number, List<int> awesomePhrases)
        {
            return awesomePhrases.Any(x => x == number);
        }

        public static bool IsIncrementSequenсe(string str)
        {
            return str.Where((c, i) => i < str.Length - 1 && (c + 1 == str[i + 1] || c - 9 == str[i + 1])).Append(str.Last()).SequenceEqual(str);
        }

        public static bool IsDecrementSequence(string str)
        {
            return str.Where((c, i) => i < str.Length - 1 && c - 1 == str[i + 1]).Append(str.Last()).SequenceEqual(str);
        }


        public static void Test()
        {
            Console.WriteLine(Solution(97, new List<int>() { 1337, 256 }));
            Console.WriteLine(Solution(678901234, new List<int>() { 1337, 256 }));
            Console.WriteLine(Solution(43210, new List<int>() { 1337, 256 }));

            Console.WriteLine(Solution(3, new List<int>() { 1337, 256 }));
            Console.WriteLine(Solution(3236, new List<int>() { 1337, 256 }));

            Console.WriteLine(Solution(11207, new List<int>() { }));
            Console.WriteLine(Solution(11208, new List<int>() { }));
            Console.WriteLine(Solution(11209, new List<int>() { }));
            Console.WriteLine(Solution(11210, new List<int>() { }));
            Console.WriteLine(Solution(11211, new List<int>() { }));

            Console.WriteLine(Solution(1335, new List<int>() { 1337, 256 }));
            Console.WriteLine(Solution(1336, new List<int>() { 1337, 256 }));
            Console.WriteLine(Solution(1337, new List<int>() { 1337, 256 }));
        }
    }
}
