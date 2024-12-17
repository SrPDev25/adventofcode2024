using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16
{
    internal class BFSeso
    {

        public static List<int[]> BreadthFirstSearch(List<List<string>> graph, int[] startNode, int[] endNode, Dictionary<string, int[]> predecessor)
        {
            //El tipo Queue es una coleccion que permite introducir y sacar elementos en cola de forma facil (Enqueue, Dequeue)
            Queue<int[]> queue = new Queue<int[]>();
            //El tipo HashSet es una coleccion que permite almacenar elementos de forma unica, por hash
            List<int[]> visited = new List<int[]>();

            // Comienza con el nodo inicial
            queue.Enqueue(startNode);
            visited.Add(startNode);
            bool found = false;

            while (queue.Count > 0 && !found)
            {
                int[] currentNode = queue.Dequeue();
                int[][] directions = new int[][] { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };


                // Procesa cada nodo adyacente
                foreach (var direction in directions)
                {
                    int[] neighbor = [currentNode[0] + direction[0], currentNode[1] + direction[1]];
                    if (graph[neighbor[0]][neighbor[1]] == "#")
                    {
                        continue;
                    }
                    else if (graph[neighbor[0]][neighbor[1]] == "E")
                    {
                        found = true;
                        predecessor.Add($"[{neighbor[0]},{neighbor[1]}]", currentNode);
                        break;
                    }
                    else
                    {
                        if (visited.FindIndex(x => x[0] == neighbor[0] && x[1] == neighbor[1]) == -1)
                        {
                            visited.Add(neighbor);
                            queue.Enqueue(neighbor);
                            predecessor.Add($"[{neighbor[0]},{neighbor[1]}]", currentNode);
                        }
                    }
                }
            }
            return visited;
        }

        public static List<int[]> ReconstructPath(Dictionary<string, int[]> predecessor, int[] startNode, int[] endNode)
        {
            List<int[]> path = new List<int[]>();
            path.Add(endNode);
            int[] currentNode = endNode;
            while (currentNode != startNode)
            {
                currentNode = predecessor[$"[{currentNode[0]},{currentNode[1]}]"];
                path.Add(currentNode);
            }
            return path;
        }

    }
}
