using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirinto.Models
{
    public class MazeNode
    {
        public const int North = 0;
        public const int South = North + 1;
        public const int East = South + 1;
        public const int West = East + 1;

        private int direction = 0;

        public float Cost = 0;
        public float Heuristic;

        public float F
        {
            get
            {
                if (Heuristic != -1 && Cost != -1)
                    return Heuristic + Cost;
                else
                    return -1;
            }
        }

        public MazeNode[] Neighbors = new MazeNode[4];
        public MazeNode Predecessor = null;
        public Rectangle Bounds;

        public Point Center
        {
            get
            {
                int x = Bounds.Left + Bounds.Width / 2;
                int y = Bounds.Top + Bounds.Height / 2;
                return new Point(x, y);
            }
        }

        public int Direction { get => direction; set => direction = value; }

        public MazeNode(int x, int y, int wid, int hgt)
        {
            Bounds = new Rectangle(x, y, wid, hgt);
        }

        public void DrawWalls(Graphics gr, Pen pen)
        {
            for (int side = 0; side < 4; side++)
            {
                if ((Neighbors[side] == null) ||
                    ((Neighbors[side].Predecessor != this) &&
                     (Neighbors[side] != this.Predecessor)))
                {
                    DrawWall(gr, pen, side, 0);
                }
            }
        }
            
        public void DrawCenter(Graphics gr, Brush brush, int cellSize)
        {
            float size = cellSize / 3;
            int cx = Bounds.Left + Bounds.Width / 2;
            int cy = Bounds.Top + Bounds.Height / 2;
       
            gr.FillEllipse(brush, cx - size / 2, cy - size / 2, size, size);
        }

        private void DrawWall(Graphics gr, Pen pen, int side, int offset)
        {
            switch (side)
            {
                case North:
                    
                    gr.DrawLine(pen,
                        Bounds.Left + offset, Bounds.Top + offset,
                        Bounds.Right - offset, Bounds.Top + offset);
                    break;
                case South:
                    gr.DrawLine(pen,
                        Bounds.Left + offset, Bounds.Bottom - offset,
                        Bounds.Right - offset, Bounds.Bottom - offset);
                    break;
                case East:
                    gr.DrawLine(pen,
                        Bounds.Right - offset, Bounds.Top + offset,
                        Bounds.Right - offset, Bounds.Bottom - offset);
                    break;
                case West:
                    gr.DrawLine(pen,
                        Bounds.Left + offset, Bounds.Top + offset,
                        Bounds.Left + offset, Bounds.Bottom - offset);
                    break;
            }
        }

    }
}
