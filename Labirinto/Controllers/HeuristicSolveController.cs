using Labirinto.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labirinto.Controllers
{
    public class HeuristicSolveController
	{
        private MazeNode[,] maze;
        private List<MazeNode> ClosedList;
        private PriorityNodeQueue<MazeNode> OpenList;
        public int steps = 0;

        public HeuristicSolveController(MazeNode[,] maze)
        {
            OpenList = new PriorityNodeQueue<MazeNode>();
            ClosedList = new List<MazeNode>();
            this.maze = maze;
        }

        internal MazeNode[,] Maze { set => maze = value; }

        public bool FindPath(ref List<MazeNode> path, ref List<MazeNode> wrongPath)
        {
            int fx = maze.GetLength(0) - 1;
            int fy = maze.GetLength(1) - 1;

            List<MazeNode> wrongPathAux = new List<MazeNode>();

            MazeNode start = maze[0, 0];
            MazeNode end = maze[fx, fy];
            int neighCount = start.Neighbors.Count(x => x != null);

            start.Cost = 0;
            start.Heuristic = Heuristic(start, end, neighCount);

            MazeNode current = start;

            OpenList.Enqueue(start, start.F);

            path.Add(start);

            while (!OpenList.IsEmpty() && !ClosedList.Contains(end))
            {
                current = OpenList.Dequeue();

                ClosedList.Add(current);
                wrongPathAux.Add(current);
                steps++;

                foreach (MazeNode neighbor in current.Neighbors)
                {
                    if (!ClosedList.Contains(neighbor) && neighbor != null)
                    {
                        bool isFound = false;
                        foreach (var oLNode in OpenList.UnorderedList)
                        {
                            if (oLNode == neighbor) { isFound = true; }
                        }
                        if (!isFound && neighbor != null)
                        {
                            neighCount = neighbor.Neighbors.Count(x => x != null);
                            neighbor.Heuristic = Heuristic(neighbor, end, neighCount);
                            neighbor.Cost = neighbor.Bounds.Width + neighbor.Predecessor.Cost;
                            OpenList.Enqueue(neighbor, neighbor.F);
                            steps++;
                        }
                    }
                }
            }

            if (!ClosedList.Contains(end))
            {
                return false;
            }
             
            MazeNode temp = ClosedList[ClosedList.IndexOf(current)];
            if (temp == null) return false;
            do
            {
                path.Add(temp);
                temp = temp.Predecessor;
            } while (temp != start && temp != null);

            foreach (MazeNode node in wrongPathAux)
            {
                var nodeAux = node.Predecessor;
                wrongPath.Add(node);
                while (!path.Contains(nodeAux))
                {
                    if (!wrongPath.Contains(nodeAux))
                        wrongPath.Add(nodeAux);
                    nodeAux = nodeAux.Predecessor;
                }
            }

            return true;
        }

        private float Heuristic(MazeNode node, MazeNode end, int neighCount)
        {
            return Math.Abs(node.Bounds.Location.X - end.Bounds.Location.X) + 
                   Math.Abs(node.Bounds.Location.Y - end.Bounds.Location.Y) + neighCount;
        }
    }
}