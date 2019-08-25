using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBFS
{
    public class Process
    {
        public int MinDistance(string[,] arr)
        {
            //Array visitados
            bool[,] visited = new bool[4, 4];
            //Guarda origen/source
            Qitem source = new Qitem(0, 0, 0);
            //Limtes del array
            int N = arr.GetLength(0);
            int M = arr.GetLength(0);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (arr[i, j] == "0")
                        visited[i, j] = true;
                    else
                        visited[i, j] = false;

                    if (arr[i, j] == "s")
                    {
                        source.Row = i;
                        source.Col = j;
                    }
                }
            }

            Queue<Qitem> q = new Queue<Qitem>();
            q.Enqueue(source);
            visited[source.Row, source.Col] = true;

            while (q.Count > 0)
            {
                Qitem qitem = q.Dequeue();

                if (arr[qitem.Row, qitem.Col] == "d")
                    return qitem.Dist;

                //DOWN
                if (qitem.Row + 1 < N && visited[qitem.Row + 1, qitem.Col] == false)
                {
                    q.Enqueue(new Qitem(qitem.Row + 1, qitem.Col, qitem.Dist + 1));
                    visited[qitem.Row + 1, qitem.Col] = true;
                }

                //RIGHT
                if (qitem.Col + 1 < M && visited[qitem.Row, qitem.Col + 1] == false)
                {
                    q.Enqueue(new Qitem(qitem.Row, qitem.Col + 1, qitem.Dist + 1));
                    visited[qitem.Row, qitem.Col + 1] = true;
                }

                //UP
                if (qitem.Row - 1 >= 0 && visited[qitem.Row - 1, qitem.Col] == false)
                {
                    q.Enqueue(new Qitem(qitem.Row - 1, qitem.Col, qitem.Dist + 1));
                    visited[qitem.Row - 1, qitem.Col] = true;
                }

                //LEFT
                if (qitem.Col - 1 >= 0 && visited[qitem.Row, qitem.Col - 1] == false)
                {
                    q.Enqueue(new Qitem(qitem.Row, qitem.Col - 1, qitem.Dist + 1));
                    visited[qitem.Row, qitem.Col - 1] = true;
                }
            }

            return -1;
        }
    }
}
