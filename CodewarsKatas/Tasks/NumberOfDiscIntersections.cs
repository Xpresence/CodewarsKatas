namespace CodewarsKatas.Tasks
{
    // URL: https://app.codility.com/programmers/lessons/6-sorting/number_of_disc_intersections/
    public class NumberOfDiscIntersections
    {
        public static int Solution(int[] A)
        {
            var radiuses = Enumerable.Range(0, A.Length).ToDictionary(i => i, i => A[i]);

            var countIntersections = 0;
            var key = 0;

            while (radiuses.Count > 1)
            {
                var rPoint = key + radiuses[key] <= A.Length - 1 ? key + radiuses[key] : A.Length - 1;

                countIntersections += rPoint - key + radiuses.Where(x => x.Key > key + radiuses[key] && x.Key - x.Value <= key + radiuses[key]).Count();

                if (countIntersections > 10000000)
                {
                    return -1;
                }

                radiuses.Remove(key);
                key++;
            }

            return countIntersections;
        }

        public static void Test()
        {
            Console.WriteLine(Solution(new int[] { 1, 5, 2, 1, 4, 0 }));
        }
    }
}
