namespace CodewarsKatas
{
    public class AddingBigNumbers
    {
        // URL: https://www.codewars.com/kata/525f4206b73515bffb000b21
        public static string Solution(string a, string b)
        {
            var alist = Split(a, 1).ToList();
            var blist = Split(b, 1).ToList();

            if (alist.Count() > blist.Count())
            {
                for (int i = blist.Count(); i < alist.Count(); i++)
                {
                    blist.Add("0");
                }
            }
            else if (alist.Count() < blist.Count())
            {
                for (int i = alist.Count(); i < blist.Count(); i++)
                {
                    alist.Add("0");
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
            return System.Numerics.BigInteger.Add(System.Numerics.BigInteger.Parse(a), System.Numerics.BigInteger.Parse(b)).ToString();
        }

        //public static string Solution3(string a, string b)
        //{
        //    return (decimal.Parse(a) + decimal.Parse(b)).ToString();
        //}

        public static void Test()
        {
            Console.WriteLine(Solution("9999999999999999999999999999999999999999999", "1"));
            Console.WriteLine(Solution("1057853509440367665682450458794866464501746580388666517943654", "1"));
            Console.WriteLine(Solution("9223372036854775807", "9223372036854775807"));

            Console.WriteLine(Solution2("9999999999999999999999999999999999999999999", "1"));
            Console.WriteLine(Solution2("1057853509440367665682450458794866464501746580388666517943654", "1"));
            Console.WriteLine(Solution2("9223372036854775807", "9223372036854775807"));
        }
    }
}
