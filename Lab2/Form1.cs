using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoolThings;
using System.IO;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
       
        }
        Image img = Image.FromFile(@"E:\1.jpg");
        double[,] heap;
        Graphics gr;
        int size, sX, sY, fX, fY;
        const int brick = 100;
        const int initialOffset = 300;
        Bitmap mainIm = new Bitmap(600,600);
        double[] mu = new double[3];
        double sigma;
        double[,] RotTrans = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
        double[,] Transformation = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, 0.25 }, { 0, 0, 0, 1 } };
        double[,] initCloud;
        double[,] rotatedPoints;
        double[,] plain;
        int[] agnleLocal = new int[2];
        bool firstTime = true;
        bool world = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != null && textBox2.Text != null)
            {
                size = Convert.ToInt32(textBox1.Text);
                StreamWriter sr = new StreamWriter("data.csv");
                if (textBox2.Text.Contains('.'))
                {
                    textBox2.Text = textBox2.Text.Replace('.', ',');
                }
                sigma = Convert.ToDouble(textBox2.Text);
                heap = new double[size, 3];
                initCloud =new double[size, 3]; 
                rotatedPoints = new double[size, 3];
                plain = new double[size, 2];
                Random rand = new Random();
                
                for(int i = 0; i < heap.GetLength(0); i++)
                {
                    for(int col = 0; col < heap.GetLength(1); col++)
                    {
                        double sign = rand.NextDouble();
                        if (sign < 0.5)
                        {
                            heap[i, col] = -rand.NextDouble();
                        }
                        else
                        {
                           heap[i, col] = rand.NextDouble();
                        }
                        mu[col] += heap[i, col];
                    }
                    string data = heap[i, 0].ToString() + ";" + heap[i, 1].ToString() + ";" + heap[i, 2].ToString() + Environment.NewLine;
                    sr.Write(data);
                }
                mu[0] /= size;
                mu[1] /= size;
                mu[2] /= size;
                sr.Close();
            }
            
            RecountFunc(heap);
        }
        private double[,] RecountFunc(double[,] arr)
        {
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                arr[i, 0] = xFunc(i) + error(arr[i, 0], sigma, mu[0]);
                arr[i, 1] = yFunc(i) + error(arr[i, 1], sigma, mu[1]);
                arr[i, 2] = zFunc(i) + error(arr[i, 2], sigma, mu[2]);
            }
            return arr;
        }
        double xFunc(double value)
        {
            double x = 0.6 * Math.Cos(4 * Math.PI * value/size+Math.PI/4);
            return x;
        }
        double yFunc(double value)
        {
            double y = 0.4 * Math.Sin(8 * Math.PI * value / size);
            return y;
        }
        double zFunc(double value)
        {
            double z = -1 + 2 * value / size;
            return z;
        }
        double error(double value, double sigma, double mu)
        {
            double e = 1/(Math.Sqrt(2*Math.PI)*sigma)*Math.Exp(-0.5*Math.Pow((value-mu),2)/Math.Pow(sigma,2));
            return e;
        }

        void Rotation(int axis, double angle)// 0-x 1 -y 
        {
            angle = angle * Math.PI / 180;
            if (axis == 0)
            {
                RotTrans[0, 0] = 1; RotTrans[0, 1] = 0; RotTrans[0, 2] = 0; RotTrans[0, 3] = 0;
                RotTrans[1, 0] = 0; RotTrans[1, 1] = Math.Cos(angle); RotTrans[1, 2] = -Math.Sin(angle); RotTrans[1, 3] = 0;
                RotTrans[2, 0] = 0; RotTrans[2, 1] = Math.Sin(angle); RotTrans[2, 2] = Math.Cos(angle); RotTrans[2, 3] = 0;
                RotTrans[3, 0] = 0; RotTrans[3, 1] = 0; RotTrans[3, 2] = 0; RotTrans[3, 3] = 1;

            }
            else
            {
                RotTrans[0, 0] = Math.Cos(angle); RotTrans[0, 1] = 0; RotTrans[0, 2] = Math.Sin(angle); RotTrans[0, 3] = 0;
                RotTrans[1, 0] = 0; RotTrans[1, 1] = 1; RotTrans[1, 2] = 0; RotTrans[1, 3] = 0;
                RotTrans[2, 0] = -Math.Sin(angle); RotTrans[2, 1] = 0; RotTrans[2, 2] = Math.Cos(angle); RotTrans[2, 3] = 0;
                RotTrans[3, 0] = 0; RotTrans[3, 1] = 0; RotTrans[3, 2] = 0; RotTrans[3, 3] = 1;

            }
            matrix1.Text = Math.Round(RotTrans[0, 0], 3).ToString();
            matrix2.Text = Math.Round(RotTrans[0, 1], 3).ToString();
            matrix3.Text = Math.Round(RotTrans[0, 2], 3).ToString();
            matrix4.Text = Math.Round(RotTrans[0, 3], 3).ToString();
            matrix5.Text = Math.Round(RotTrans[1, 0], 3).ToString();
            matrix6.Text = Math.Round(RotTrans[1, 1], 3).ToString();
            matrix7.Text = Math.Round(RotTrans[1, 2], 3).ToString();
            matrix8.Text = Math.Round(RotTrans[1, 3], 3).ToString();
            matrix9.Text = Math.Round(RotTrans[2, 0], 3).ToString();
            matrix10.Text = Math.Round(RotTrans[2, 1], 3).ToString();
            matrix11.Text = Math.Round(RotTrans[2, 2], 3).ToString();
            matrix12.Text = Math.Round(RotTrans[2, 3], 3).ToString();
            matrix13.Text = Math.Round(RotTrans[3, 0], 3).ToString();
            matrix14.Text = Math.Round(RotTrans[3, 1], 3).ToString();
            matrix15.Text = Math.Round(RotTrans[3, 2], 3).ToString();
            matrix16.Text = Math.Round(RotTrans[3, 3], 3).ToString();


        }
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            mainIm = new Bitmap(600, 600);
            gr = Graphics.FromImage(mainIm);
            for (int i = 0; i < heap.GetLength(0); i++) {
                if (firstTime == true || world == true)
                {
                    pointRecount(heap, i, gr);
                    if (firstTime)
                    {
                        rotatedPoints = (double[,])heap.Clone();
                    }
                }
                if (world == false)
                {
                    pointRecount(rotatedPoints, i, gr);
                }
            }
            pictureBox1.Image = mainIm;
            firstTime = false;

        }
        void pointRecount(double[,] cloud, int row, Graphics graphics)
        {
            bool state = true;
            double x = cloud[row, 0];
            double y = cloud[row, 1];
            double z = cloud[row, 2];
            double[,] source = { { x }, { y }, { z }, { 1 } };
            double[,] coord = new double[4, 1];
            CoolThings.CoolThings.MultiplicationMat(RotTrans, source, out state, out coord);
          
            for(int i =0; i < 3; i++)
            {
                if (firstTime || world)
                {
                    initCloud[row, i] = coord[i, 0];
                    
                }
                else
                {
                   rotatedPoints[row, i] = coord[i, 0];
                }
            }
            Random ranC = new Random();
            double a = heap[row, 2];
            if (a < 0)
            {
                a = Math.Abs(a) * 500 / 4;
            }
            else
            {
                if (a > 1) { a = 1; }
                a = Math.Abs(a+1) * 500 / 4;
            }
            var point = conv2dTo3d(coord);
            Color color = Color.FromArgb((int)a, (int)a, (int)a, (int)a);
            graphics.FillEllipse(new SolidBrush(color), (float)point[0] - 2, (float)point[1] - 2, 4, 4);
 
        }
        double[] conv2dTo3d(double[,] arr)
        {
            bool state = true;
            double[] arr1 = { arr[0, 0], arr[1, 0], arr[2, 0], arr[3, 0] };
            double[] xy = new double[4];
            CoolThings.CoolThings.MultiplicationMat(arr1, Transformation, out state, out xy);
            CoolThings.CoolThings.Conversion3Dto2D(xy);
            double x = Math.Round(xy[0], 2);
            double y = Math.Round(xy[1], 2);
            if (x > 0 && y > 0)
            {
                xy[0] = initialOffset + x * brick;
                xy[1] = initialOffset - y * brick;
            }
            else if (x < 0 && y > 0)
            {
                xy[0] = initialOffset + x * brick;
                xy[1] = initialOffset - y * brick;
            }
            else if (x < 0 && y < 0)
            {
                xy[0] = initialOffset + x * brick;
                xy[1] = initialOffset + -1 * y * brick;
            }
            else if (x > 0 && y < 0)
            {
                xy[0] = initialOffset + x * brick;
                xy[1] = initialOffset + -1 * y * brick;
            }
            return xy;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            mainIm = new Bitmap(600, 600);
            gr = Graphics.FromImage(mainIm);
            double[,] src = { { 1 },{ -1 }, { -1 }, { 1 } };
            double[,] src2 = { { 1 }, { 1 }, { -1 }, { 1 } };
            double[,] src3 = { { -1 }, { 1 }, { -1 }, {1 }};
            double[,] src4 = { { -1 }, { -1 }, { -1 }, {1 }};
            double[,] src5 = { { -1 }, { -1 }, { 1 }, { 1 } };
            double[,] src6 = { { -1 }, { 1 }, { 1 }, { 1 } };
            double[,] src7 = { { 1 }, { 1 }, { 1 }, { 1 } };
            double[,] src8 = { { 1 }, { -1 }, { 1 }, { 1 } };
            bool state = true;
            double[,] xy = new double[4,1];
            CoolThings.CoolThings.MultiplicationMat(RotTrans, src, out state, out xy);
            double[,] xy2 = new double[4, 1];
            CoolThings.CoolThings.MultiplicationMat(RotTrans, src2, out state, out xy2);
            double[,] xy3 = new double[4, 1];
            CoolThings.CoolThings.MultiplicationMat(RotTrans, src3, out state, out xy3);
            double[,] xy4 = new double[4, 1];
            CoolThings.CoolThings.MultiplicationMat(RotTrans, src4, out state, out xy4);
            double[,] xy5 = new double[4, 1];
            CoolThings.CoolThings.MultiplicationMat(RotTrans, src5, out state, out xy5);
            double[,] xy6 = new double[4, 1];
            CoolThings.CoolThings.MultiplicationMat(RotTrans, src6, out state, out xy6);
            double[,] xy7 = new double[4, 1];
            CoolThings.CoolThings.MultiplicationMat(RotTrans, src7, out state, out xy7);
            double[,] xy8 = new double[4, 1];
            CoolThings.CoolThings.MultiplicationMat(RotTrans, src8, out state, out xy8);
            var p1 = conv2dTo3d(xy);
            var p2 = conv2dTo3d(xy2);
            var p3 = conv2dTo3d(xy3);
            var p4 = conv2dTo3d(xy4);
            var p5 = conv2dTo3d(xy5);
            var p6 = conv2dTo3d(xy6);
            var p7 = conv2dTo3d(xy7);
            var p8 = conv2dTo3d(xy8);

            gr.DrawLine(new Pen(Color.Blue, 3), (float)p1[0], (float)p1[1], (float)p2[0], (float)p2[1] );
            gr.DrawLine(new Pen(Color.Blue, 3), (float)p2[0], (float)p2[1], (float)p3[0], (float)p3[1] );
            gr.DrawLine(new Pen(Color.Blue, 3), (float)p3[0], (float)p3[1], (float)p4[0], (float)p4[1] );
            gr.DrawLine(new Pen(Color.Blue, 3), (float)p4[0], (float)p4[1], (float)p1[0], (float)p1[1]);

            gr.DrawLine(new Pen(Color.Red, 3), (float)p5[0], (float)p5[1], (float)p6[0], (float)p6[1] );
            gr.DrawLine(new Pen(Color.Red, 3), (float)p6[0], (float)p6[1], (float)p7[0], (float)p7[1]);
            gr.DrawLine(new Pen(Color.Red, 3), (float)p7[0], (float)p7[1], (float)p8[0], (float)p8[1]);
            gr.DrawLine(new Pen(Color.Red, 3), (float)p8[0], (float)p8[1], (float)p5[0], (float)p5[1]);

            gr.DrawLine(new Pen(Color.Olive, 3), (float)p1[0], (float)p1[1], (float)p8[0], (float)p8[1]);
            gr.DrawLine(new Pen(Color.Olive, 3), (float)p2[0], (float)p2[1], (float)p7[0], (float)p7[1]);
            gr.DrawLine(new Pen(Color.Olive, 3), (float)p6[0], (float)p6[1], (float)p3[0], (float)p3[1]);
            gr.DrawLine(new Pen(Color.Olive, 3), (float)p4[0], (float)p4[1], (float)p5[0], (float)p5[1]);
            pictureBox1.Image = mainIm;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader reader;
            string path = null;
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                 path = ofd.FileName;
            }
            reader = new StreamReader(path);
            List<string> data = new List<string>();
            bool r = false;
            while (r == false)
            {
                data.Add(reader.ReadLine());
                r = reader.EndOfStream;
            }
            reader.Close();
            textBox1.Text = data.Count.ToString();
            size = data.Count;
            sigma = Convert.ToDouble(textBox2.Text);
            heap = new double[size, 3];
            initCloud = new double[size, 3];
            rotatedPoints = new double[size, 3];
            plain = new double[size, 2];
            Random rand = new Random();
            for (int item = 0; item < size; item++)
            {
                string[] str = data[item].Split(';');
                heap[item, 0] = Convert.ToDouble(str[0]);
                heap[item, 1] = Convert.ToDouble(str[1]);
                heap[item, 2] = Convert.ToDouble(str[2]);
            }
            for (int i = 0; i < heap.GetLength(0); i++)
            {
                for (int col = 0; col < heap.GetLength(1); col++)
                {
                    mu[col] += heap[i, col];
                }

            }
            mu[0] /= size;
            mu[1] /= size;
            mu[2] /= size;
            RecountFunc(heap);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image != null)
            {
                pictureBox1.Image.Save("image.bmp");
            }
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int value = trackBar1.Value;
            Rotation(0, value);
            if (trackBar2.Value != 0)
            {
                value = trackBar2.Value;
                var xAxis = RotTrans;
                Rotation(1, value);
                var yAxis = RotTrans;
                bool state = true;
                CoolThings.CoolThings.MultiplicationMat(xAxis, yAxis, out state, out RotTrans);
            }

            world = true;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int value = trackBar2.Value;
            Rotation(1, value);
            if (trackBar1.Value != 0)
            {
                value = trackBar1.Value;
                var yAxis = RotTrans;
                Rotation(0, value);
                var xAxis = RotTrans;
                bool state = true;
                CoolThings.CoolThings.MultiplicationMat(xAxis, yAxis, out state, out RotTrans);
            }
            world = true;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            fX = e.X;
            fY = e.Y;
            if (fX > sX)
            { agnleLocal[0] += 10; }
            else { agnleLocal[0] -= 10; }
            if (fY > sY)
            { agnleLocal[1] += 10; }
            else { agnleLocal[1] -= 10; }
            Rotation(0, agnleLocal[0]);
            var xMat = RotTrans;
            Rotation(1, agnleLocal[1]);
            var yMat = RotTrans;
            bool state = true;
            CoolThings.CoolThings.MultiplicationMat(xMat, yMat, out state, out RotTrans);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            sX = e.X;
            sY = e.Y;
            world = false;
        }
    }
}
