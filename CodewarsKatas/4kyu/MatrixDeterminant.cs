namespace CodewarsKatas
{
    public class MatrixDeterminant
    {
        // URL: https://www.codewars.com/kata/52a382ee44408cea2500074c
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
}
