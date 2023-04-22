namespace Labirinto
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblDescricaoProjeto = new System.Windows.Forms.Label();
            this.lblLargura = new System.Windows.Forms.Label();
            this.numLargura = new System.Windows.Forms.NumericUpDown();
            this.lblAltura = new System.Windows.Forms.Label();
            this.numAltura = new System.Windows.Forms.NumericUpDown();
            this.lblTamanhoBloco = new System.Windows.Forms.Label();
            this.numTamanhoBlc = new System.Windows.Forms.NumericUpDown();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.btnSolve2 = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.lblTituloProjeto = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblSair = new System.Windows.Forms.Button();
            this.lblElapsedTime2 = new System.Windows.Forms.Label();
            this.lblSteps2 = new System.Windows.Forms.Label();
            this.picBoxCriarLabirinto = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picMaze = new System.Windows.Forms.PictureBox();
            this.picBoxBuscaInformada = new System.Windows.Forms.PictureBox();
            this.picBoxBuscaCega = new System.Windows.Forms.PictureBox();
            this.picBoxConfiguracoes = new System.Windows.Forms.PictureBox();
            this.picBoxResultado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numLargura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTamanhoBlc)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCriarLabirinto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBuscaInformada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBuscaCega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxConfiguracoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricaoProjeto
            // 
            this.lblDescricaoProjeto.AutoSize = true;
            this.lblDescricaoProjeto.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricaoProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoProjeto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDescricaoProjeto.Location = new System.Drawing.Point(223, 36);
            this.lblDescricaoProjeto.Name = "lblDescricaoProjeto";
            this.lblDescricaoProjeto.Size = new System.Drawing.Size(729, 24);
            this.lblDescricaoProjeto.TabIndex = 13;
            this.lblDescricaoProjeto.Text = "GERADOR DE LABIRINTO - FUNDAMENTOS DE SISTEMAS INTELIGENTES";
            // 
            // lblLargura
            // 
            this.lblLargura.AutoSize = true;
            this.lblLargura.BackColor = System.Drawing.Color.Transparent;
            this.lblLargura.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLargura.ForeColor = System.Drawing.Color.White;
            this.lblLargura.Location = new System.Drawing.Point(104, 132);
            this.lblLargura.Name = "lblLargura";
            this.lblLargura.Size = new System.Drawing.Size(86, 23);
            this.lblLargura.TabIndex = 17;
            this.lblLargura.Text = "LARGURA";
            // 
            // numLargura
            // 
            this.numLargura.BackColor = System.Drawing.Color.Black;
            this.numLargura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numLargura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLargura.ForeColor = System.Drawing.Color.White;
            this.numLargura.Location = new System.Drawing.Point(234, 133);
            this.numLargura.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numLargura.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLargura.Name = "numLargura";
            this.numLargura.Size = new System.Drawing.Size(67, 21);
            this.numLargura.TabIndex = 12;
            this.numLargura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLargura.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.BackColor = System.Drawing.Color.Transparent;
            this.lblAltura.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.ForeColor = System.Drawing.Color.White;
            this.lblAltura.Location = new System.Drawing.Point(108, 168);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(76, 23);
            this.lblAltura.TabIndex = 18;
            this.lblAltura.Text = "ALTURA";
            // 
            // numAltura
            // 
            this.numAltura.BackColor = System.Drawing.Color.Black;
            this.numAltura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAltura.ForeColor = System.Drawing.Color.White;
            this.numAltura.Location = new System.Drawing.Point(234, 169);
            this.numAltura.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numAltura.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAltura.Name = "numAltura";
            this.numAltura.Size = new System.Drawing.Size(67, 21);
            this.numAltura.TabIndex = 14;
            this.numAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numAltura.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblTamanhoBloco
            // 
            this.lblTamanhoBloco.AutoSize = true;
            this.lblTamanhoBloco.BackColor = System.Drawing.Color.Transparent;
            this.lblTamanhoBloco.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTamanhoBloco.ForeColor = System.Drawing.Color.White;
            this.lblTamanhoBloco.Location = new System.Drawing.Point(63, 98);
            this.lblTamanhoBloco.Name = "lblTamanhoBloco";
            this.lblTamanhoBloco.Size = new System.Drawing.Size(165, 20);
            this.lblTamanhoBloco.TabIndex = 19;
            this.lblTamanhoBloco.Text = "TAMANHO DO BLOCO";
            // 
            // numTamanhoBlc
            // 
            this.numTamanhoBlc.BackColor = System.Drawing.Color.Black;
            this.numTamanhoBlc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTamanhoBlc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTamanhoBlc.ForeColor = System.Drawing.Color.White;
            this.numTamanhoBlc.Location = new System.Drawing.Point(234, 98);
            this.numTamanhoBlc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTamanhoBlc.Name = "numTamanhoBlc";
            this.numTamanhoBlc.Size = new System.Drawing.Size(67, 21);
            this.numTamanhoBlc.TabIndex = 11;
            this.numTamanhoBlc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTamanhoBlc.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.BackColor = System.Drawing.Color.Transparent;
            this.lblSteps.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold);
            this.lblSteps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.lblSteps.Location = new System.Drawing.Point(59, 447);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(15, 23);
            this.lblSteps.TabIndex = 21;
            this.lblSteps.Text = ".";
            this.lblSteps.Visible = false;
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.BackColor = System.Drawing.Color.Transparent;
            this.lblElapsedTime.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold);
            this.lblElapsedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.lblElapsedTime.Location = new System.Drawing.Point(59, 483);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(15, 23);
            this.lblElapsedTime.TabIndex = 22;
            this.lblElapsedTime.Text = ".";
            this.lblElapsedTime.Visible = false;
            // 
            // btnSolve2
            // 
            this.btnSolve2.BackColor = System.Drawing.Color.Transparent;
            this.btnSolve2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolve2.FlatAppearance.BorderSize = 0;
            this.btnSolve2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolve2.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.5F, System.Drawing.FontStyle.Bold);
            this.btnSolve2.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSolve2.Location = new System.Drawing.Point(92, 357);
            this.btnSolve2.Name = "btnSolve2";
            this.btnSolve2.Size = new System.Drawing.Size(179, 35);
            this.btnSolve2.TabIndex = 23;
            this.btnSolve2.Text = "BUSCA INFORMADA";
            this.btnSolve2.UseVisualStyleBackColor = false;
            this.btnSolve2.Click += new System.EventHandler(this.btnSolve2_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.AutoSize = true;
            this.btnCriar.BackColor = System.Drawing.Color.Transparent;
            this.btnCriar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCriar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriar.FlatAppearance.BorderSize = 0;
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriar.Font = new System.Drawing.Font("Bahnschrift Condensed", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCriar.Location = new System.Drawing.Point(90, 216);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(179, 44);
            this.btnCriar.TabIndex = 16;
            this.btnCriar.Text = "CRIAR LABIRINTO";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // lblTituloProjeto
            // 
            this.lblTituloProjeto.AutoSize = true;
            this.lblTituloProjeto.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProjeto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTituloProjeto.Location = new System.Drawing.Point(173, 8);
            this.lblTituloProjeto.Name = "lblTituloProjeto";
            this.lblTituloProjeto.Size = new System.Drawing.Size(818, 25);
            this.lblTituloProjeto.TabIndex = 26;
            this.lblTituloProjeto.Text = "UNIVERSIDADE TECNOLÓGICA FEDERAL DO PARANÁ - MEDIANEIRA/2023";
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.Transparent;
            this.btnSolve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolve.FlatAppearance.BorderSize = 0;
            this.btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolve.Font = new System.Drawing.Font("Bahnschrift Condensed", 21F, System.Drawing.FontStyle.Bold);
            this.btnSolve.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSolve.Location = new System.Drawing.Point(92, 286);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(179, 44);
            this.btnSolve.TabIndex = 20;
            this.btnSolve.Text = "BUSCA CEGA";
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Black;
            this.pnlContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContent.Controls.Add(this.lblSair);
            this.pnlContent.Controls.Add(this.lblElapsedTime2);
            this.pnlContent.Controls.Add(this.lblSteps2);
            this.pnlContent.Controls.Add(this.btnSolve);
            this.pnlContent.Controls.Add(this.lblTituloProjeto);
            this.pnlContent.Controls.Add(this.btnCriar);
            this.pnlContent.Controls.Add(this.picBoxCriarLabirinto);
            this.pnlContent.Controls.Add(this.pictureBox1);
            this.pnlContent.Controls.Add(this.btnSolve2);
            this.pnlContent.Controls.Add(this.lblElapsedTime);
            this.pnlContent.Controls.Add(this.lblSteps);
            this.pnlContent.Controls.Add(this.numTamanhoBlc);
            this.pnlContent.Controls.Add(this.lblTamanhoBloco);
            this.pnlContent.Controls.Add(this.numAltura);
            this.pnlContent.Controls.Add(this.lblAltura);
            this.pnlContent.Controls.Add(this.numLargura);
            this.pnlContent.Controls.Add(this.lblLargura);
            this.pnlContent.Controls.Add(this.lblDescricaoProjeto);
            this.pnlContent.Controls.Add(this.picMaze);
            this.pnlContent.Controls.Add(this.picBoxBuscaInformada);
            this.pnlContent.Controls.Add(this.picBoxBuscaCega);
            this.pnlContent.Controls.Add(this.picBoxConfiguracoes);
            this.pnlContent.Controls.Add(this.picBoxResultado);
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(5);
            this.pnlContent.Size = new System.Drawing.Size(1001, 635);
            this.pnlContent.TabIndex = 1;
            // 
            // lblSair
            // 
            this.lblSair.BackColor = System.Drawing.Color.Transparent;
            this.lblSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.FlatAppearance.BorderSize = 0;
            this.lblSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSair.Font = new System.Drawing.Font("Bahnschrift Condensed", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.ForeColor = System.Drawing.Color.LightGray;
            this.lblSair.Location = new System.Drawing.Point(977, -9);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(27, 37);
            this.lblSair.TabIndex = 32;
            this.lblSair.Text = "X";
            this.lblSair.UseVisualStyleBackColor = false;
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            this.lblSair.MouseLeave += new System.EventHandler(this.lblSair_MouseLeave);
            this.lblSair.MouseHover += new System.EventHandler(this.lblSair_MouseHover);
            // 
            // lblElapsedTime2
            // 
            this.lblElapsedTime2.AutoSize = true;
            this.lblElapsedTime2.BackColor = System.Drawing.Color.Transparent;
            this.lblElapsedTime2.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold);
            this.lblElapsedTime2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.lblElapsedTime2.Location = new System.Drawing.Point(57, 573);
            this.lblElapsedTime2.Name = "lblElapsedTime2";
            this.lblElapsedTime2.Size = new System.Drawing.Size(15, 23);
            this.lblElapsedTime2.TabIndex = 30;
            this.lblElapsedTime2.Text = ".";
            this.lblElapsedTime2.Visible = false;
            // 
            // lblSteps2
            // 
            this.lblSteps2.AutoSize = true;
            this.lblSteps2.BackColor = System.Drawing.Color.Transparent;
            this.lblSteps2.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold);
            this.lblSteps2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.lblSteps2.Location = new System.Drawing.Point(57, 537);
            this.lblSteps2.Name = "lblSteps2";
            this.lblSteps2.Size = new System.Drawing.Size(15, 23);
            this.lblSteps2.TabIndex = 29;
            this.lblSteps2.Text = ".";
            this.lblSteps2.Visible = false;
            // 
            // picBoxCriarLabirinto
            // 
            this.picBoxCriarLabirinto.Image = global::Labirinto.Properties.Resources.BotaoFSI;
            this.picBoxCriarLabirinto.Location = new System.Drawing.Point(43, 207);
            this.picBoxCriarLabirinto.Name = "picBoxCriarLabirinto";
            this.picBoxCriarLabirinto.Size = new System.Drawing.Size(269, 63);
            this.picBoxCriarLabirinto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCriarLabirinto.TabIndex = 25;
            this.picBoxCriarLabirinto.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Labirinto.Properties.Resources.CC_UTFPR_;
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // picMaze
            // 
            this.picMaze.BackColor = System.Drawing.Color.DarkSlateGray;
            this.picMaze.Location = new System.Drawing.Point(365, 78);
            this.picMaze.Name = "picMaze";
            this.picMaze.Padding = new System.Windows.Forms.Padding(3);
            this.picMaze.Size = new System.Drawing.Size(611, 533);
            this.picMaze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMaze.TabIndex = 10;
            this.picMaze.TabStop = false;
            // 
            // picBoxBuscaInformada
            // 
            this.picBoxBuscaInformada.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBuscaInformada.Image")));
            this.picBoxBuscaInformada.Location = new System.Drawing.Point(43, 345);
            this.picBoxBuscaInformada.Name = "picBoxBuscaInformada";
            this.picBoxBuscaInformada.Size = new System.Drawing.Size(269, 63);
            this.picBoxBuscaInformada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBuscaInformada.TabIndex = 28;
            this.picBoxBuscaInformada.TabStop = false;
            // 
            // picBoxBuscaCega
            // 
            this.picBoxBuscaCega.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBuscaCega.Image")));
            this.picBoxBuscaCega.Location = new System.Drawing.Point(43, 276);
            this.picBoxBuscaCega.Name = "picBoxBuscaCega";
            this.picBoxBuscaCega.Size = new System.Drawing.Size(269, 63);
            this.picBoxBuscaCega.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBuscaCega.TabIndex = 27;
            this.picBoxBuscaCega.TabStop = false;
            // 
            // picBoxConfiguracoes
            // 
            this.picBoxConfiguracoes.Image = global::Labirinto.Properties.Resources.baixados__3_;
            this.picBoxConfiguracoes.Location = new System.Drawing.Point(35, 90);
            this.picBoxConfiguracoes.Name = "picBoxConfiguracoes";
            this.picBoxConfiguracoes.Size = new System.Drawing.Size(297, 108);
            this.picBoxConfiguracoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxConfiguracoes.TabIndex = 31;
            this.picBoxConfiguracoes.TabStop = false;
            // 
            // picBoxResultado
            // 
            this.picBoxResultado.Image = global::Labirinto.Properties.Resources.BackResult3;
            this.picBoxResultado.Location = new System.Drawing.Point(24, 423);
            this.picBoxResultado.Name = "picBoxResultado";
            this.picBoxResultado.Size = new System.Drawing.Size(321, 195);
            this.picBoxResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxResultado.TabIndex = 33;
            this.picBoxResultado.TabStop = false;
            this.picBoxResultado.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(79)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.pnlContent);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Labirinto";
            ((System.ComponentModel.ISupportInitialize)(this.numLargura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTamanhoBlc)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCriarLabirinto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBuscaInformada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBuscaCega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxConfiguracoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxBuscaCega;
        private System.Windows.Forms.PictureBox picBoxBuscaInformada;
        private System.Windows.Forms.PictureBox picMaze;
        private System.Windows.Forms.Label lblDescricaoProjeto;
        private System.Windows.Forms.Label lblLargura;
        private System.Windows.Forms.NumericUpDown numLargura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.NumericUpDown numAltura;
        private System.Windows.Forms.Label lblTamanhoBloco;
        private System.Windows.Forms.NumericUpDown numTamanhoBlc;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.Button btnSolve2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBoxCriarLabirinto;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Label lblTituloProjeto;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblElapsedTime2;
        private System.Windows.Forms.Label lblSteps2;
        private System.Windows.Forms.PictureBox picBoxConfiguracoes;
        private System.Windows.Forms.Button lblSair;
        private System.Windows.Forms.PictureBox picBoxResultado;
    }
}

