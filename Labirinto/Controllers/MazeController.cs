using Labirinto.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labirinto.Controllers
{
    class MazeController
    {

        public static MazeNode[,] MazeNodes(int wid, int hgt, int Ymin, int Xmin, int CellSize)
        {
            MazeNode[,] nodes = new MazeNode[hgt, wid];

            for (int i = 0; i < hgt; ++i)
            {
                int y = Ymin + CellSize * i;
                for (int j = 0; j < wid; ++j)
                {
                    int x = Xmin + CellSize * j;
                    nodes[i, j] = new MazeNode(x, y, CellSize, CellSize);
                }
            }

            for (int i = 0; i < hgt; ++i)
            {
                for (int j = 0; j < wid; ++j)
                {
                    if (i > 0) nodes[i, j].Neighbors[MazeNode.North] = nodes[i - 1, j];
                    if (i < hgt - 1) nodes[i, j].Neighbors[MazeNode.South] = nodes[i + 1, j];
                    if (j > 0) nodes[i, j].Neighbors[MazeNode.West] = nodes[i, j - 1];
                    if (j < wid - 1) nodes[i, j].Neighbors[MazeNode.East] = nodes[i, j + 1];
                }
            }

            return nodes;
        }

        public static void FindSpanningTree(ref MazeNode root)
        {
            Random rand = new Random();

            root.Predecessor = root;

            List<MazeConnection> links = new List<MazeConnection>();

            foreach (MazeNode neighbor in root.Neighbors)
            {
                if (neighbor != null)
                    links.Add(new MazeConnection(root, neighbor));
            }

            while (links.Count > 0)
            {
                int link_num = rand.Next(0, links.Count);
                MazeConnection link = links[link_num];
                links.RemoveAt(link_num);

                MazeNode to_node = link.ToNode;
                link.ToNode.Predecessor = link.FromNode;

                for (int i = links.Count - 1; i >= 0; i--)
                {
                    if (links[i].ToNode.Predecessor != null)
                        links.RemoveAt(i);
                }

                foreach (MazeNode neighbor in to_node.Neighbors)
                {
                    if ((neighbor != null) && (neighbor.Predecessor == null))
                        links.Add(new MazeConnection(to_node, neighbor));
                }
            }

        }
        
        public static Bitmap DisplayMaze(MazeNode[,] nodes, int picWid, int picHgt, int cellSize, Color color, LineCap lineCap, int lineWid)
        {
            Pen pen = new Pen(color, lineWid)
            {
                StartCap = lineCap,
                EndCap = lineCap,
            };
            int hgt = nodes.GetUpperBound(0) + 1;
            int wid = nodes.GetUpperBound(1) + 1;
            Bitmap bm = new Bitmap(picWid, picHgt);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                for (int r = 0; r < hgt; r++)
                {
                    for (int c = 0; c < wid; c++)
                    {
                        if ((r == 0 && c == 0) || (r == hgt - 1 && c == wid - 1))
                        {
                            if (pen.Color != Color.Red) pen.Color = Color.OrangeRed;
                            else pen.Color = Color.BlueViolet;
                        }
                        else pen.Color = color;
                        nodes[r, c].DrawWalls(gr, pen);
                     
                    }
                }
            }

            return bm;
        }

        public static Bitmap DisplayPath(List<MazeNode> path, int cellSize, Bitmap image, Brush color)
        {
            Bitmap bm = image;

            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                foreach (MazeNode node in path)
                {
                    node.DrawCenter(gr, color, cellSize);
                }
            }
            return bm;
        }

    }
}
