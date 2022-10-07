namespace CodewarsKatas
{
    public class MazeRunner
    {
        // URL: https://www.codewars.com/kata/58663693b359c4a6560001d6
        public static string Solution(int[,] maze, string[] directions)
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

            Console.WriteLine(Solution(maze, directions));
        }
    }
}
