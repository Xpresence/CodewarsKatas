namespace CodewarsKatas
{
    public class ObservedPIN
    {
        // URL: https://www.codewars.com/kata/5263c6999e0f40dee200059d
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
}
