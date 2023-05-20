using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatorialProblem
{
    internal class Solving
    {
        public List<bool[]> PlacementWithOptions(int M, int N)
        {
            List<bool[]> combinations = new List<bool[]>();

            // Инициализация матрицы dp
            bool[][] dp = new bool[M + 1][];
            for (int i = 0; i <= M; i++)
            {
                dp[i] = new bool[N + 1];
            }

            // Базовый случай: первая колонка заполняется единицами
            for (int i = 0; i <= M; i++)
            {
                dp[i][0] = true;
            }

            // Заполнение матрицы dp с использованием динамического программирования
            for (int i = 1; i <= M; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    if (i >= j)
                    {
                        dp[i][j] = dp[i - 1][j] || dp[i - 1][j - 1];
                    }
                }
            }

            // Генерация комбинаций на основе матрицы dp
            Stack<Tuple<int, int, bool[]>> stack = new Stack<Tuple<int, int, bool[]>>();
            stack.Push(new Tuple<int, int, bool[]>(M, N, new bool[M]));

            while (stack.Count > 0)
            {
                var tuple = stack.Pop();
                int i = tuple.Item1;
                int j = tuple.Item2;
                bool[] currentCombination = tuple.Item3;

                if (j == 0)
                {
                    combinations.Add(currentCombination);
                }
                else if (i >= j)
                {
                    if (dp[i - 1][j])
                    {
                        stack.Push(new Tuple<int, int, bool[]>(i - 1, j, (bool[])currentCombination.Clone()));
                    }

                    if (dp[i - 1][j - 1])
                    {
                        currentCombination[i - 1] = true;
                        stack.Push(new Tuple<int, int, bool[]>(i - 1, j - 1, (bool[])currentCombination.Clone()));
                    }
                }
            }

            return combinations;
        }

        public long PlacementWithoutOptions(int M, int N)
        {
            int[,] dp = new int[N + 1, M + 1];

            // Инициализируем базовые случаи
            for (int i = 0; i <= M; i++)
            {
                dp[0, i] = 1;
            }

            // Вычисляем число возможных заполнений
            for (int i = 1; i <= N; i++)
            {
                for (int j = i; j <= M; j++)
                {
                    dp[i, j] = dp[i, j - 1] + dp[i - 1, j - 1];
                }
            }
            return dp[N, M];
        }
    }
}
