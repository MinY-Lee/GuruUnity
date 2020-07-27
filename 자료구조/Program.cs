using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 자료구조
{
    class Map
    {
        int[,] tiles = { 
            { 1,1,1,1,1},
            { 1,0,0,0,1},
            { 1,0,0,0,1},
            { 1,0,0,0,1},
            { 1,1,1,1,1}
        };

        public void Render()
        {
            var defaultColor = Console.ForegroundColor;
            for(int y=0;y<tiles.GetLength(1);y++)
            {
                for(int x=0;x<tiles.GetLength(0);x++)
                {
                    if (tiles[y, x] == 1)
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    else
                        Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.Write('\u25cf');
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = defaultColor;
        }
    }
    class Program
    {/*
        // 자료구조
        static int GetHighestScore(int[] scores)
        {
            int maxValue = 0;

            foreach(int score in scores)
            {
                if (score >= maxValue)
                    maxValue = score;
            }
            return maxValue;
        }

        static int GetAverageScore(int[] scores)
        {
            int sum = 0;

            foreach(int score in scores)
            {
                sum += score;
            }

            return sum / scores.Length;
        }

        static int GetIndexOf(int[] scores, int value)
        {
            for(int i = 0;i < scores.Length;i++)
            {
                if (scores[i] == value)
                    return i;
            }
            return -1;
        }

        static void Sort(int[] scores)
        {
            for(int i=0;i<scores.Length;i++)
            {
                // 제일 작은 숫자가 있는 index 찾기
                int minIndex = i;
                for(int j=i;j<scores.Length;j++)
                {
                    if (scores[j] < scores[minIndex])
                        minIndex = j;
                }

                int temp = 0;
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;
            }
        }

        static void Main(string[] args)
        {
            // 배열
            int[] scores = new int[5] { 10, 30, 40, 20, 50 };

            int highestScore=GetHighestScore(scores);
            Console.WriteLine(highestScore);

            int averageScore = GetAverageScore(scores);
            Console.WriteLine(averageScore);

            int index = GetIndexOf(scores, 15);
            Console.WriteLine(index);

            Sort(scores);
        }*/

        // 다차원 배열
        static void Main(string[] args)
        {
            Map map = new Map();
            map.Render();
        }
        
    }
}
