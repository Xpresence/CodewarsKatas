namespace CodewarsKatas
{
    public class Deadfish
    {
        // URL: https://www.codewars.com/kata/51e0007c1f9378fa810002a9
        public static int[] Solution(string data)
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

        public static int[] Solution2(string data)
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

            foreach (var item in Solution("iisodoiiso"))
            {
                Console.WriteLine(item);
            }
            foreach (var item in Solution("iiisdosodddddiso"))
            {
                Console.WriteLine(item);
            }

            foreach (var item in Solution2("iisodoiiso"))
            {
                Console.WriteLine(item);
            }
            foreach (var item in Solution2("iiisdosodddddiso"))
            {
                Console.WriteLine(item);
            }
        }
    }
}
