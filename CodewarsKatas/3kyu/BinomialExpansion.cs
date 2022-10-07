namespace CodewarsKatas
{
    public class BinomialExpansion
    {
        // URL: https://www.codewars.com/kata/540d0fdd3b6532e5c3000b5b
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
}
