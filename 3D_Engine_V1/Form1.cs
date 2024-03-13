using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3D_3ngine_V1
{
    public partial class Form1 : Form
    {

        public float z = 1f;

        public float rotateY = 0.0f;
        public float rotateX = 0.0f;
        public float rotateZ = 0.0f;

        public float translateX = 3.0f;
        public float translateY = -1.0f;
        public float translateZ = 14.0f;

        public TreeNode selectedNode;


        public Form1()
        {
            InitializeComponent();
        }
        public void Init(string filename)
        {
            CreateNewOBJ(filename);
            PCT_CANVAS.Invalidate();
        }

        public void CreateNewOBJ(string filename)
        {
            ObjParser objectPar = new ObjParser(filename);

            /* List<float[]> verticesList = objectPar.Vertices.Select(vertex => new float[] { vertex[0], vertex[1], vertex[2] }).ToList();
             List<int[]> facesList = objectPar.Faces.Select(face => new int[] { face[0], face[1], face[2] }).ToList();
             List<int[]> triangles = objectPar.Faces.Select(face => new int[] { face[0], face[1], face[2] }).ToList(); */

            Vertex vert = new Vertex(rotateX, rotateY, rotateZ);
            Vertex translate = new Vertex(translateX, translateY, translateZ);


            Vertex[] vertices = objectPar.Vertices.Select(v => new Vertex(v[0], v[1], v[2])).ToArray();

            Triangle[] triangles2 = objectPar.Faces.Select(t => new Triangle(
                Array.IndexOf(vertices, vertices[t[0]]),
                Array.IndexOf(vertices, vertices[t[1]]),
                Array.IndexOf(vertices, vertices[t[2]]),
                Color.Black)).ToArray();

            Model cube = new Model(vertices, triangles2, new Vertex(0, 0, 0), (float)Math.Sqrt(3));
            Instance inst1 = new Instance(cube, translate, Mtx.Rotate(vert), z);





            Instance[] instances = new Instance[] { inst1 };

            Rasterization raster = new Rasterization(PCT_CANVAS.Size, vert, translate, z, instances);


            PCT_CANVAS.Image = raster.Canvas;
            PCT_CANVAS.Invalidate();

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                selectedNode = e.Node;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        List<string> objFiles = new List<string>();

        public void Add_OBJ_Click(object sender, EventArgs e)
        {

            OpenFileDialog newFile = new OpenFileDialog();
            newFile.Filter = "OBJ files (*.obj)|*.obj";

            if (newFile.ShowDialog() == DialogResult.OK)
            {

                TreeNode node = new TreeNode(newFile.FileName);
                node.Tag = newFile.FileName;
                treeView1.Nodes.Add(node);
                treeView1.SelectedNode = node;
                selectedNode = node;

                string filename = node.Tag.ToString();

                objFiles.Add(filename);


                ObjParser objectPar = new ObjParser(filename);

                Init(filename);

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            rotateY = trackBar1.Value;
            YrotLabel.Text = "Y:" + rotateY.ToString();

            string filename = selectedNode.Tag.ToString();

            PCT_CANVAS.Invalidate();
            Init(filename);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

            rotateX = trackBar2.Value;
            XrotLabel.Text = "X:" + rotateX.ToString();

            string filename = selectedNode.Tag.ToString();

            PCT_CANVAS.Invalidate();
            Init(filename);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            rotateZ = trackBar3.Value;
            ZrotLabel.Text = "Z:" + rotateZ.ToString();

            string filename = selectedNode.Tag.ToString();

            PCT_CANVAS.Invalidate();
            Init(filename);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {

            z = trackBar4.Value;
            scaleLabel.Text = "Scale:" + z.ToString();

            string filename = selectedNode.Tag.ToString();
            PCT_CANVAS.Invalidate();
            Init(filename);
        }

        private void trackBarTrY_Scroll(object sender, EventArgs e)
        {
            translateY = trackBarTrY.Value;
            YTrLabel.Text = "Y:" + translateY.ToString();

            string filename = selectedNode.Tag.ToString();

            PCT_CANVAS.Invalidate();
            Init(filename);
        }

        private void trackBarTrX_Scroll(object sender, EventArgs e)
        {
            translateX = trackBarTrX.Value;
            TrXlabel.Text = "X:" + translateX.ToString();

            string filename = selectedNode.Tag.ToString();
            PCT_CANVAS.Invalidate();
            Init(filename);
        }

        private void trackBarTrZ_Scroll(object sender, EventArgs e)
        {
            translateZ = trackBarTrZ.Value;
            TrZlabel.Text = "Z: " + translateZ.ToString();
            string filename = selectedNode.Tag.ToString();

            PCT_CANVAS.Invalidate();
            Init(filename);


        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void button2_Click(object sender, EventArgs e)
        {
        }

        public void canvasTimer_Tick(object sender, EventArgs e)
        {
        }

        public void Play_BTN_Click(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Stop_BTN_Click(object sender, EventArgs e)
        {
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void PCT_CANVAS_Click(object sender, EventArgs e)
        {

        }

        private void YTrLabel_Click(object sender, EventArgs e)
        {

        }

        private void scaleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
