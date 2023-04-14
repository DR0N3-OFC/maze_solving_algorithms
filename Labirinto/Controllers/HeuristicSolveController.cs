using Labirinto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private MyPriorityQueue<MazeNode> OpenList;
        public int steps = 0;

        public HeuristicSolveController(MazeNode[,] maze)
        {
            OpenList = new MyPriorityQueue<MazeNode>();
            ClosedList = new List<MazeNode>();
            this.maze = maze;
        }

        internal MazeNode[,] Maze { set => maze = value; }

        public bool FindPath(ref List<MazeNode> path)
        {
            int fx = maze.GetLength(0) - 1;
            int fy = maze.GetLength(1) - 1;

            MazeNode start = maze[0, 0];
            MazeNode end = maze[fx, fy];

            start.Custo = 0;
            start.Heuristica = Heuristica(start, end);

            MazeNode current = start;

            // add start node to Open List
            OpenList.Enqueue(start, start.F);

            path.Add(start);

            while (!OpenList.IsEmpty() && !ClosedList.Contains(end))
            {
                current = OpenList.Dequeue();

                ClosedList.Add(current);

                foreach (MazeNode neighbor in current.Neighbors)
                {
                    steps++;
                    if (!ClosedList.Contains(neighbor) && neighbor != null)
                    {
                        bool isFound = false;
                        foreach (var oLNode in OpenList.UnorderedList)
                        {
                            if (oLNode == neighbor) { isFound = true; }
                        }
                        if (!isFound && neighbor != null)
                        {
                            neighbor.Heuristica = Heuristica(neighbor, end);
                            neighbor.Custo = neighbor.Bounds.Width + neighbor.Predecessor.Custo;
                            OpenList.Enqueue(neighbor, neighbor.F);
                        }
                    }
                }
            }

            // construct path, if end was not closed return null
            if (!ClosedList.Contains(end))
            {
                return false;
            }

            // if all good, return path
            MazeNode temp = ClosedList[ClosedList.IndexOf(current)];
            if (temp == null) return false;
            do
            {
                path.Add(temp);
                temp = temp.Predecessor;
            } while (temp != start && temp != null);
            path.Reverse();
            return true;
        }

        private float Heuristica(MazeNode node, MazeNode end)
        {
            return Math.Abs(node.Bounds.Location.X - end.Bounds.Location.X) + Math.Abs(node.Bounds.Location.Y - end.Bounds.Location.Y);
        }
    }
}