namespace _3D_3ngine_V1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PCT_CANVAS = new PictureBox();
            scaleLabel = new Label();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            ZrotLabel = new Label();
            XrotLabel = new Label();
            YrotLabel = new Label();
            trackBar3 = new TrackBar();
            trackBar4 = new TrackBar();
            trackBarTrX = new TrackBar();
            trackBarTrY = new TrackBar();
            trackBarTrZ = new TrackBar();
            YTrLabel = new Label();
            TrXlabel = new Label();
            TrZlabel = new Label();
            canvasTimer = new System.Windows.Forms.Timer(components);
            Add_OBJ = new Button();
            treeView1 = new TreeView();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)PCT_CANVAS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTrX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTrY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTrZ).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // PCT_CANVAS
            // 
            PCT_CANVAS.BackColor = Color.FromArgb(10, 10, 10);
            PCT_CANVAS.BorderStyle = BorderStyle.FixedSingle;
            PCT_CANVAS.Dock = DockStyle.Fill;
            PCT_CANVAS.Location = new Point(0, 0);
            PCT_CANVAS.Margin = new Padding(5, 4, 5, 4);
            PCT_CANVAS.Name = "PCT_CANVAS";
            PCT_CANVAS.Size = new Size(1726, 971);
            PCT_CANVAS.TabIndex = 0;
            PCT_CANVAS.TabStop = false;
            PCT_CANVAS.Click += PCT_CANVAS_Click;
            // 
            // scaleLabel
            // 
            scaleLabel.AutoSize = true;
            scaleLabel.ForeColor = Color.WhiteSmoke;
            scaleLabel.Location = new Point(356, 25);
            scaleLabel.Margin = new Padding(5, 0, 5, 0);
            scaleLabel.Name = "scaleLabel";
            scaleLabel.Size = new Size(47, 20);
            scaleLabel.TabIndex = 16;
            scaleLabel.Text = "Scale:";
            scaleLabel.Click += scaleLabel_Click;
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 10;
            trackBar1.Location = new Point(253, 89);
            trackBar1.Margin = new Padding(5, 4, 5, 4);
            trackBar1.Maximum = 360;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(536, 56);
            trackBar1.TabIndex = 17;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(253, 169);
            trackBar2.Margin = new Padding(5, 4, 5, 4);
            trackBar2.Maximum = 360;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(535, 56);
            trackBar2.TabIndex = 18;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // ZrotLabel
            // 
            ZrotLabel.AutoSize = true;
            ZrotLabel.ForeColor = Color.WhiteSmoke;
            ZrotLabel.Location = new Point(162, 249);
            ZrotLabel.Margin = new Padding(5, 0, 5, 0);
            ZrotLabel.Name = "ZrotLabel";
            ZrotLabel.Size = new Size(78, 20);
            ZrotLabel.TabIndex = 21;
            ZrotLabel.Text = "Z rotation:";
            // 
            // XrotLabel
            // 
            XrotLabel.AutoSize = true;
            XrotLabel.ForeColor = Color.WhiteSmoke;
            XrotLabel.Location = new Point(162, 169);
            XrotLabel.Margin = new Padding(5, 0, 5, 0);
            XrotLabel.Name = "XrotLabel";
            XrotLabel.Size = new Size(78, 20);
            XrotLabel.TabIndex = 20;
            XrotLabel.Text = "X rotation:";
            // 
            // YrotLabel
            // 
            YrotLabel.AutoSize = true;
            YrotLabel.ForeColor = Color.WhiteSmoke;
            YrotLabel.Location = new Point(163, 98);
            YrotLabel.Margin = new Padding(5, 0, 5, 0);
            YrotLabel.Name = "YrotLabel";
            YrotLabel.Size = new Size(77, 20);
            YrotLabel.TabIndex = 19;
            YrotLabel.Text = "Y rotation:";
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(253, 249);
            trackBar3.Margin = new Padding(5, 4, 5, 4);
            trackBar3.Maximum = 360;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(536, 56);
            trackBar3.TabIndex = 22;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // trackBar4
            // 
            trackBar4.Location = new Point(442, 25);
            trackBar4.Margin = new Padding(5, 4, 5, 4);
            trackBar4.Maximum = 200;
            trackBar4.Name = "trackBar4";
            trackBar4.Size = new Size(898, 56);
            trackBar4.TabIndex = 23;
            trackBar4.Value = 1;
            trackBar4.Scroll += trackBar4_Scroll;
            // 
            // trackBarTrX
            // 
            trackBarTrX.Location = new Point(918, 169);
            trackBarTrX.Margin = new Padding(5, 4, 5, 4);
            trackBarTrX.Maximum = 50;
            trackBarTrX.Minimum = -50;
            trackBarTrX.Name = "trackBarTrX";
            trackBarTrX.Size = new Size(627, 56);
            trackBarTrX.TabIndex = 24;
            trackBarTrX.Value = 4;
            trackBarTrX.Scroll += trackBarTrX_Scroll;
            // 
            // trackBarTrY
            // 
            trackBarTrY.Location = new Point(918, 89);
            trackBarTrY.Margin = new Padding(5, 4, 5, 4);
            trackBarTrY.Maximum = 50;
            trackBarTrY.Minimum = -50;
            trackBarTrY.Name = "trackBarTrY";
            trackBarTrY.Size = new Size(627, 56);
            trackBarTrY.TabIndex = 25;
            trackBarTrY.Scroll += trackBarTrY_Scroll;
            // 
            // trackBarTrZ
            // 
            trackBarTrZ.Location = new Point(918, 249);
            trackBarTrZ.Margin = new Padding(5, 4, 5, 4);
            trackBarTrZ.Maximum = 50;
            trackBarTrZ.Minimum = -50;
            trackBarTrZ.Name = "trackBarTrZ";
            trackBarTrZ.Size = new Size(627, 56);
            trackBarTrZ.TabIndex = 26;
            trackBarTrZ.Value = 7;
            trackBarTrZ.Scroll += trackBarTrZ_Scroll;
            // 
            // YTrLabel
            // 
            YTrLabel.AutoSize = true;
            YTrLabel.ForeColor = Color.FloralWhite;
            YTrLabel.Location = new Point(814, 98);
            YTrLabel.Margin = new Padding(5, 0, 5, 0);
            YTrLabel.Name = "YTrLabel";
            YTrLabel.Size = new Size(96, 20);
            YTrLabel.TabIndex = 27;
            YTrLabel.Text = "Y Translation:";
            YTrLabel.Click += YTrLabel_Click;
            // 
            // TrXlabel
            // 
            TrXlabel.AutoSize = true;
            TrXlabel.ForeColor = Color.WhiteSmoke;
            TrXlabel.Location = new Point(813, 169);
            TrXlabel.Margin = new Padding(5, 0, 5, 0);
            TrXlabel.Name = "TrXlabel";
            TrXlabel.Size = new Size(97, 20);
            TrXlabel.TabIndex = 28;
            TrXlabel.Text = "X Translation:";
            // 
            // TrZlabel
            // 
            TrZlabel.AutoSize = true;
            TrZlabel.ForeColor = Color.WhiteSmoke;
            TrZlabel.Location = new Point(814, 249);
            TrZlabel.Margin = new Padding(5, 0, 5, 0);
            TrZlabel.Name = "TrZlabel";
            TrZlabel.Size = new Size(100, 20);
            TrZlabel.TabIndex = 29;
            TrZlabel.Text = "Z Translation::";
            // 
            // canvasTimer
            // 
            canvasTimer.Interval = 80;
            canvasTimer.Tick += canvasTimer_Tick;
            // 
            // Add_OBJ
            // 
            Add_OBJ.BackColor = Color.FromArgb(20, 20, 20);
            Add_OBJ.ForeColor = Color.WhiteSmoke;
            Add_OBJ.Location = new Point(45, 32);
            Add_OBJ.Margin = new Padding(5, 4, 5, 4);
            Add_OBJ.Name = "Add_OBJ";
            Add_OBJ.Size = new Size(85, 69);
            Add_OBJ.TabIndex = 32;
            Add_OBJ.Text = "Add OBJ file";
            Add_OBJ.UseVisualStyleBackColor = false;
            Add_OBJ.Click += Add_OBJ_Click;
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.FromArgb(20, 20, 20);
            treeView1.ForeColor = Color.WhiteSmoke;
            treeView1.Location = new Point(45, 150);
            treeView1.Margin = new Padding(3, 4, 3, 4);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(85, 454);
            treeView1.TabIndex = 33;
            treeView1.AfterSelect += treeView1_AfterSelect;
            treeView1.NodeMouseClick += treeView1_NodeMouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 20, 20);
            panel1.Controls.Add(scaleLabel);
            panel1.Controls.Add(trackBar4);
            panel1.Controls.Add(TrZlabel);
            panel1.Controls.Add(TrXlabel);
            panel1.Controls.Add(YTrLabel);
            panel1.Controls.Add(trackBarTrZ);
            panel1.Controls.Add(trackBarTrY);
            panel1.Controls.Add(trackBarTrX);
            panel1.Controls.Add(trackBar3);
            panel1.Controls.Add(ZrotLabel);
            panel1.Controls.Add(XrotLabel);
            panel1.Controls.Add(YrotLabel);
            panel1.Controls.Add(trackBar2);
            panel1.Controls.Add(trackBar1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 665);
            panel1.Name = "panel1";
            panel1.Size = new Size(1726, 306);
            panel1.TabIndex = 38;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 20, 20);
            panel2.Controls.Add(treeView1);
            panel2.Controls.Add(Add_OBJ);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(182, 665);
            panel2.TabIndex = 39;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(20, 20, 20);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(182, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1544, 101);
            panel3.TabIndex = 40;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(20, 20, 20);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1546, 101);
            panel4.Name = "panel4";
            panel4.Size = new Size(180, 564);
            panel4.TabIndex = 41;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1726, 971);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(PCT_CANVAS);
            ForeColor = Color.Black;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "DEMO";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PCT_CANVAS).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTrX).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTrY).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTrZ).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label ZrotLabel;
        private System.Windows.Forms.Label XrotLabel;
        private System.Windows.Forms.Label YrotLabel;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBarTrX;
        private System.Windows.Forms.TrackBar trackBarTrY;
        private System.Windows.Forms.TrackBar trackBarTrZ;
        private Label YTrLabel;
        private Label TrXlabel;
        private Label TrZlabel;
        private System.Windows.Forms.Timer canvasTimer;
        private Button Add_OBJ;
        private TreeView treeView1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}
