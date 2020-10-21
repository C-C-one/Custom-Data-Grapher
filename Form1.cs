using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adress_book
{
    public partial class sdasdawd : Form
    {
        List<Point> Lines = new List<Point>();
        Point[] points = new Point[8];
        Graphics g;
        Pen p = new Pen(Color.Red), pl= new Pen(Color.Wheat);
        int horri = 0, squish = 1, xtem = 50, ytem = 10, color = 0;
        Bitmap bmp;
        String dataset;
        Point A = new Point(50, 10);
        Point B = new Point(380, 10);
        Point C = new Point(50, 300);
        Point D = new Point(380, 300);

        public sdasdawd()
        {
            InitializeComponent();
            Point e = new Point(Cursor.Position.X, Cursor.Position.Y);
            bmp = new Bitmap(Width, Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            BackgroundImage = bmp;
            g = Graphics.FromImage(BackgroundImage);
            g.Clear(Color.FloralWhite);
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            xtem = 50;
            ytem = 10;
            horri = trackBar1.Value * 25;
            g.Clear(Color.FloralWhite);
            if (checkBox1.Checked == true)
            {
                assignData(dataset);
                drawGrid();
                drawData();
            }  
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            xtem = 50;
            ytem = 10;
            squish = trackBar3.Value+1;
            g.Clear(Color.FloralWhite);
            if (checkBox1.Checked == true)
            {
                assignData(dataset);
                drawGrid();
                drawData();
            }
        }
        private void drawGrid()
        {
            g.DrawLine(p, A, B); //Use whatever method to draw your line
            g.DrawLine(p, A, C);
            g.DrawLine(p, D, C);
            g.DrawLine(p, D, B);
            for (int y = 20; y < 300; y = y + 10)
            {
                Point flag = new Point(51, y);
                Point flage = new Point(379, y);
                g.DrawLine(pl, flag, flage);
            }
        }
        private void drawData()
        {
            while (dataset.Length >= 8)
            {
                double c = Int32.Parse(dataset.Substring(0, 3));
                int x = (int)Math.Floor(c / squish);
                //(int)Math.Floor(c / squish);
                int y = Int32.Parse(dataset.Substring(3, 3)) + 10;
                c = Int32.Parse(dataset.Substring(6, 2));
                int length = (int)Math.Floor(c / squish);
                int defq = x + xtem - horri;
                Rectangle rectangle = new Rectangle(defq, y, length, (int)Math.Floor(Math.Sqrt(length + 2)) + length / 10);
                xtem = xtem + x + length;
                
                if (color == 0)
                {
                    g.DrawLine(new Pen(Color.LightBlue), new Point(defq - x, ytem), new Point(defq, y));
                    g.FillRectangle(new SolidBrush(Color.Blue), rectangle);
                }
                else if(color == 1)
                {
                    g.DrawLine(new Pen(Color.LimeGreen), new Point(defq - x, ytem), new Point(defq, y));
                    g.FillRectangle(new SolidBrush(Color.Green), rectangle);
                }
                ytem = y;
                dataset = dataset.Substring(8, dataset.Length - 8);
                Refresh();
            }
        }
        private void tmrTick_Tick(object sender, EventArgs e)
        {
            //xxxyyyll
            
        }
        public void assignData (String data)
        {
            if (checkBox1.Checked == true)
            {
                if (data == "//open1")
                {
                    textBox1.Text = System.IO.File.ReadAllText(@"C:\Users\Feifei\Desktop\Projects\Square\data.txt");
                    color = 0;
                }
                else if (data == "//open2")
                {
                    textBox1.Text = System.IO.File.ReadAllText(@"C:\Users\Feifei\Desktop\Projects\Square\dataTue.txt");
                    color = 1;
                }
                else
                {
                    //buildData();
                }
                dataset = textBox1.Text.ToString();
            } 
        }

        private void sdasdawd_Load(object sender, EventArgs e)
        {
        }

        private void tmrCon_Tick(object sender, EventArgs e)
        {
            updateLocation();
        }

        private void updateLocation()
        {
            Point xy = this.PointToClient(Cursor.Position);
            if (xy.Y <= 300 && xy.Y >= 10)
            {
                horriaxis.Location = new Point(50, xy.Y - 2);
            }
            else if(xy.Y<=300)
            {
                horriaxis.Location = new Point(50, 10);
            }
            else
            {
                horriaxis.Location = new Point(50, 300);
            }

            if (xy.X <= 380 && xy.X >= 50)
            {
                vertiaxis.Location = new Point(xy.X - 2, 10);
            }
            else if(xy.X <= 380)
            {
                vertiaxis.Location = new Point(50, 10);
            }
            else
            {
                vertiaxis.Location = new Point(380, 10);
            }
            lbltest.Text = "x: "+ (((xy.X + horri) * squish)-50).ToString() + "  y:" + (xy.Y-10).ToString();
        }

        
        private void btnLine1_Click(object sender, EventArgs e)
        {
            xtem = 50;
            ytem = 10;
            g.Clear(Color.FloralWhite);
            assignData(dataset);
            drawGrid();
            if (checkBox1.Checked == true)
            {
                drawData();
            }
            Refresh();
        }
    }

}
