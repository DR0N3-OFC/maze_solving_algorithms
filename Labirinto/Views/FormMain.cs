using Labirinto.Controllers;
using Labirinto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirinto
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            btnSolve.Enabled = false;
            btnSolve2.Enabled = false;
        }

        private int Xmin, Ymin, CellSize;
        private MazeNode[,] nodes;
        private Color backgroundColor = Color.White;
        private Brush resultColor = Brushes.LightGreen;
        private Brush wrongPathColor = Brushes.OrangeRed;
        private Brush wrongPathColor2 = Brushes.HotPink;
        private LineCap lineCap = LineCap.Flat;
        private int lineWid = 1;
        private Bitmap mazeImage;

        private void btnSolve_Click(object sender, EventArgs e)
        {
            List<MazeNode> path = new List<MazeNode>();
            List<MazeNode> wrongPath = new List<MazeNode>();
            BlindSolveController solver = new BlindSolveController(nodes);
            Stopwatch stopwatch = new Stopwatch();
            picMaze.Image = mazeImage;
            btnSolve.Enabled = false;

            picBoxResultado.Visible = true;

            stopwatch.Start();
            if (solver.FindPath(ref path, ref wrongPath))
            {
                stopwatch.Stop();
                Bitmap bitmap = new Bitmap(picMaze.Image);
                picMaze.Image = MazeController.DisplayPath(wrongPath, CellSize, bitmap, wrongPathColor);
                picMaze.Image = MazeController.DisplayPath(path, CellSize, bitmap, resultColor);

                lblSteps.Visible = true;
                lblSteps.Text = $"Número de Passos: {solver.steps}.";

                long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
                lblElapsedTime.Visible = true;
                lblElapsedTime.Text = $"Duração da busca: {elapsedMilliseconds} ms.";
            }
            else MessageBox.Show("Impossivel resolver o Labirinto!");
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSair_MouseHover(object sender, EventArgs e)
        {
            lblSair.ForeColor = Color.Red;
        }

        private void lblSair_MouseLeave(object sender, EventArgs e)
        {
            lblSair.ForeColor = Color.LightGray;
        }

        private void btnSolve2_Click(object sender, EventArgs e)
        {
            List<MazeNode> path = new List<MazeNode>();
            List<MazeNode> wrongPath = new List<MazeNode>();
            HeuristicSolveController solver = new HeuristicSolveController(nodes);
            Stopwatch stopwatch = new Stopwatch();
            picMaze.Image = mazeImage;
            btnSolve2.Enabled = false;

            if (picBoxResultado.Visible == false) {
                picBoxResultado.Visible = true;
            }

            stopwatch.Start();
            if (solver.FindPath(ref path, ref wrongPath))
            {
                stopwatch.Stop();
                Bitmap bitmap = new Bitmap(picMaze.Image);
                picMaze.Image = MazeController.DisplayPath(wrongPath, CellSize, bitmap, wrongPathColor2);
                picMaze.Image = MazeController.DisplayPath(path, CellSize, bitmap, resultColor);

                lblSteps2.Visible = true;
                lblSteps2.Text = $"Número de Passos: {solver.steps}.";

                long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
                lblElapsedTime2.Visible = true;
                lblElapsedTime2.Text = $"Duração da busca: {elapsedMilliseconds} ms.";
            }
            else MessageBox.Show("Impossivel resolver o Labirinto!");
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            lblElapsedTime.Visible = false;
            lblElapsedTime.Text = "";
            lblSteps.Visible = false;
            lblSteps.Text = "";
            lblElapsedTime2.Visible = false;
            lblElapsedTime2.Text = "";
            lblSteps2.Visible = false;
            lblSteps2.Text = "";
            picBoxResultado.Visible = false;

            int wid = int.Parse(numLargura.Text);
            int hgt = int.Parse(numAltura.Text);

            CellSize = int.Parse(numTamanhoBlc.Text);

            Xmin = (picMaze.ClientSize.Width - wid * CellSize) / 2;
            Ymin = (picMaze.ClientSize.Height - hgt * CellSize) / 2;


            nodes = MazeController.MazeNodes(wid, hgt, Ymin, Xmin, CellSize);

            MazeController.FindSpanningTree(ref nodes[0, 0]);

            mazeImage = MazeController.DisplayMaze(nodes, picMaze.ClientSize.Width, picMaze.ClientSize.Height, CellSize, backgroundColor, lineCap, lineWid);
            picMaze.Image = mazeImage;

            btnSolve.Visible = true;
            btnSolve.Enabled = true;

            btnSolve2.Visible = true;
            btnSolve2.Enabled = true;
        }


    }
}
