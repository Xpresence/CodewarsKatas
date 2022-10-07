namespace CodewarsKatas;

class Program
{
    static void Main(string[] args)
    {

        MatrixDeterminant.Test();

        Console.WriteLine("Ready!");
        Console.ReadKey();
    }

}

public static class MatrixDeterminant
{
    public static int Solution(int[][] matrix)
    {
        if (matrix.Length == 1)
        {
            return matrix[0][0];
        }

        var det = 0;
        for (int i = 0; i < matrix[0].Length; i++)
        {
            det += (i % 2 == 0 ? 1 : -1) * matrix[0][i] * Solution(Submatrix(matrix, i));
        }

        return det;
    }

    public static int[][] Submatrix(int[][] matrix, int index)
    {
        return matrix.Where((e, i) => i != 0).Select(e => e.Where((a, j) => j != index).ToArray()).ToArray();
    }

    public static int DeterminantRecursion()
    {
        return 0;
    }

    public static void Test()
    {
        Console.WriteLine(Solution(new int[][] { new[] { 1 } }));
        Console.WriteLine(Solution(new int[][] { new[] { 1, 3 }, new[] { 2, 5 } }));
        Console.WriteLine(Solution(new int[][] { new[] { 2, 5, 3 }, new[] { 1, -2, -1 }, new[] { 1, 3, 4 } }));
        Console.WriteLine(Solution(new int[][] { new[] { 5, -1, -7, -5 }, new[] { -6, -2, -10, 1 }, new[] { -1, -6, -10, 0 }, new[] { -9, 0, -8, -6 } }));
    }
}

public static class TenMinutesWalk
{
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

public static class CarMileage
{
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

public static class SortBinaryTree
{
    public class Node
    {
        public Node Left;
        public Node Right;
        public int Value;

        public Node(Node l, Node r, int v)
        {
            Left = l;
            Right = r;
            Value = v;
        }
    }

    public static List<int> Solution(Node node)
    {
        var result = new List<int>();
        var nodeList = node != null ? new List<Node>() { node } : new List<Node>();

        while (nodeList.Count > 0)
        {
            var bufferNodeList = new List<Node>();

            foreach (var item in nodeList)
            {
                if (item.Left != null) bufferNodeList.Add(item.Left);
                if (item.Right != null) bufferNodeList.Add(item.Right);

                result.Add(item.Value);
            }

            nodeList = bufferNodeList;
        }

        return result;
    }

    public static void Test()
    {
        Node testNULL = null;

        foreach (var item in Solution(testNULL))
        {
            Console.WriteLine(item);
        }

        var test = new Node(new Node(null, new Node(null, null, 4), 2), new Node(new Node(null, null, 5), new Node(null, null, 6), 3), 1);

        foreach (var item in Solution(test))
        {
            Console.WriteLine(item);
        }
    }
}

public static class ObservedPIN
{
    public static List<string> Solution(string observed)
    {
        var numberOptions = new List<string[]>() { new[] { "0", "8" }, new[] { "1", "2", "4" }, new[] { "1", "2", "3", "5" }, new[] { "2", "3", "6" }, new[] { "1", "4", "5", "7" }, new[] { "2", "4", "5", "6", "8" }, new[] { "3", "5", "6", "9" }, new[] { "4", "7", "8" }, new[] { "5", "7", "8", "9", "0" }, new[] { "6", "8", "9" } };
        var list = new List<string>() { observed };

        for (int i = 0; i < observed.Length; i++)
        {
            var bufferList = new List<string>();
            var bufferOptions = numberOptions[int.Parse(observed[i].ToString())];

            for (int n = 0; n < list.Count; n++)
            {
                for (int j = 0; j < bufferOptions.Length; j++)
                {
                    var str = list[n].Substring(0, i) + bufferOptions[j] + list[n].Substring(i + 1);
                    bufferList.Add(str);
                }
            }

            list = bufferList;
        }

        return list;
    }

    public static void Test()
    {
        foreach (var item in Solution("8"))
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        foreach (var item in Solution("11"))
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        foreach (var item in Solution("369"))
        {
            Console.WriteLine(item);
        }
    }

}

public static class AddingBigNumbers
{
    public static string Solution(string a, string b)
    {
        var alist = Split(a, 9).ToList();
        var blist = Split(b, 9).ToList();

        if (alist.Count() > blist.Count())
        {
            for (int i = blist.Count(); i < alist.Count(); i++)
            {
                blist.Add("000000000");
            }
        }
        else if (alist.Count() < blist.Count())
        {
            for (int i = alist.Count(); i < blist.Count(); i++)
            {
                alist.Add("000000000");
            }
        }

        var result = new List<string>();
        var nextbit = 0;
        var length = alist.Count();
        for (int i = 0; i < length; i++)
        {

            var sum = (int.Parse(alist[i]) + int.Parse(blist[i]) + nextbit).ToString();

            if (sum.Length > alist[i].Length || sum.Length > blist[i].Length)
            {

                nextbit = int.Parse(sum.Substring(0, 1));

                if (i == length - 1)
                {
                    result.Add(sum);
                }
                else
                {
                    sum = sum.Remove(0, 1);
                    result.Add(sum);
                }

            }
            else
            {
                nextbit = 0;
                result.Add(sum);
            }

        }
        result.Reverse();
        return string.Join("", result);
    }

    static IEnumerable<string> Split(string str, int chunkSize)
    {
        for (int i = str.Length; i > 0; i -= chunkSize)
        {
            yield return i >= chunkSize ? str.Substring(i - chunkSize, chunkSize) : str.Substring(0, i);
        }
    }

    public static string Solution2(string a, string b)
    {
        return (decimal.Parse(a) + decimal.Parse(b)).ToString();
    }

    public static void Test()
    {
        Console.WriteLine(Solution("9999999999999999999999999999999999999999999", "1"));
        //Console.WriteLine(Solution("1057853509440367665682450458794866464501746580388666517943654", "1"));
        //Console.WriteLine(Solution("9223372036854775807", "9223372036854775807"));
        //"1057853509440367665682450458794866464501746580388666517943654"
    }
}

public static class RemoveFirstLast
{
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

public class BinomialExpansion
{
    public static string Solution(string expr)
    {
        var s1 = expr.Split('(', '^', ')').Select(s => s).Where(s => !string.IsNullOrEmpty(s)).ToArray();
        int.TryParse(s1[1], out int n);
        var x = new string(s1[0].Where(c => char.IsLetter(c)).Select(c => c).ToArray());

        if (n == 0)
        {
            return "1";
        }

        char.TryParse(x, out char xc);
        var s2 = s1[0].Split(xc);

        int a = int.TryParse(s2[0], out a) ? a : (s2[0] == "-" ? -1 : 1);
        int.TryParse(s2[1], out int b);

        if (b == 0)
        {
            return ((long)Math.Pow(a, n) == 1 ? "" : ((long)Math.Pow(a, n)).ToString()) + x + "^" + n;
        }

        var result = "";

        for (int k = 0; k <= n; k++)
        {
            var res_k = (long)Math.Pow(a, n - k) * (long)Math.Pow(b, k) * (Factorial(n) / (Factorial(k) * Factorial(n - k)));

            result += (res_k > 0 && k > 0 ? "+" : "") + (res_k == 1 && k != n ? "" : (res_k == -1 && k != n ? "-" : res_k.ToString())) + ((n - k) > 0 ? ((n - k) == 1 ? x : x + "^" + (n - k)) : "");
        }

        return result;
    }

    //public static int Factorial(int n) => Enumerable.Range(1, n).Aggregate(1, (p, item) => p * item);
    public static long Factorial(long f)
    {
        if (f == 0)
        {
            return 1;
        }
        else
        {
            return f * Factorial(f - 1);
        }
    }


    public static void Test()
    {
        Console.WriteLine(Solution("(y+5)^15"));
        Console.WriteLine(Solution("(7h-32)^5"));
        Console.WriteLine(Solution("(-s+8)^5"));
        Console.WriteLine(Solution("(x+1)^0"));
        Console.WriteLine(Solution("(x+1)^1"));
        Console.WriteLine(Solution("(x+1)^2"));
        Console.WriteLine(Solution("(x+1)^2"));
        Console.WriteLine(Solution("(-x+1)^2"));
        Console.WriteLine(Solution("(x+0)^2"));
        Console.WriteLine(Solution("(2x+0)^2"));
        Console.WriteLine(Solution("(3x+2)^2"));
        Console.WriteLine(Solution("(3x+2)^3"));
        Console.WriteLine(Solution("(8x+23)^4"));
    }
}

public class Alphanumeric
{
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

public class DigPow
{
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

class Multiples3or5
{
    public static int Solution(int value)
    {
        var sum = 0;
        for (int i = 0; i < value; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }

    public static int Solution2(int value)
    {
        return Enumerable.Range(0, value).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
    }

    public static void Test()
    {
        Console.WriteLine(Solution(10));
        Console.WriteLine(Solution2(10));
    }
}

class MazeRunner
{
    public static string Run(int[,] maze, string[] directions)
    {
        var n = maze.GetUpperBound(0) + 1;
        var iCurrent = 0;
        var jCurrent = 0;


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (maze[i, j] == 2)
                {
                    iCurrent = i;
                    jCurrent = j;
                    break;
                }
            }
        }

        foreach (var dir in directions)
        {
            if (dir == "N")
            {
                iCurrent--;
            }
            else if (dir == "S")
            {
                iCurrent++;
            }
            else if (dir == "W")
            {
                jCurrent--;
            }
            else if (dir == "E")
            {
                jCurrent++;
            }

            if (iCurrent < 0 || jCurrent < 0 || iCurrent >= n || jCurrent >= n || maze[iCurrent, jCurrent] == 1)
            {
                return "Dead";
            }
            else if (maze[iCurrent, jCurrent] == 3)
            {
                return "Finish";
            }
        }

        return "Lost";
    }

    public static void Test()
    {
        int[,] maze = new int[,] { { 1, 1, 1, 1, 1, 1, 1 },
                                    { 1, 0, 0, 0, 0, 0, 3 },
                                    { 1, 0, 1, 0, 1, 0, 1 },
                                    { 0, 0, 1, 0, 0, 0, 1 },
                                    { 1, 0, 1, 0, 1, 0, 1 },
                                    { 1, 0, 0, 0, 0, 0, 1 },
                                    { 1, 2, 1, 0, 1, 0, 1 } };
        string[] directions = new string[] { "N", "N", "N", "W", "W" };

        Console.WriteLine(MazeRunner.Run(maze, directions));
    }
}

public class MexicanWave
{
    public static List<string> Wave(string str)
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
}

public class Deadfish
{
    public static int[] Parse(string data)
    {
        var arr = new List<int>();
        var value = 0;
        var charArray = data.ToCharArray().Select(x => x).Where(x => x == 'i' || x == 'd' || x == 's' || x == 'o');

        foreach (var item in charArray)
        {
            if (item == 'i')
            {
                value++;
            }
            else if (item == 'd')
            {
                value--;
            }
            else if (item == 's')
            {
                value *= value;
            }
            else if (item == 'o')
            {
                arr.Add(value);
            }
        }

        return arr.ToArray();
    }

    public static int[] Parse2(string data)
    {
        var arr = new List<int>();
        var value = 0;
        var charArray = data.ToCharArray().Select(x => x).Where(x => x == 'i' || x == 'd' || x == 's' || x == 'o');

        foreach (var item in charArray)
        {
            value = item == 'i' ? value + 1 : (item == 'd' ? value - 1 : (item == 's' ? value * value : value));

            if (item == 'o')
            {
                arr.Add(value);
            }
        }

        return arr.ToArray();
    }

    public static void Test()
    {
        foreach (var item in Parse("iisodoiiso"))
        {
            Console.WriteLine(item);
        }
    }
}

public class WeightClass
{
    public static string MyString => "56 65 74 100 99 68 86 180 90";
    //public string MyString => "";
    public static string TestString(string str)
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
}

public class TurtlesRace
{
    public static int[] Race(int v1, int v2, int g)
    {
        return new int[3] { g / (v2 - v1), (int)(((double)g % (v2 - v1)) * 60), (int)((((double)g / (v2 - v1)) % 1 * 60) % 1 * 60) };
    }
}

