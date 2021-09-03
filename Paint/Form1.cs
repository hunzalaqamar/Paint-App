using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(pic.Width, pic.Height);
            graphic = Graphics.FromImage(bm);
            graphic.Clear(Color.White);
            pic.Image = bm;
        }
        Bitmap bm;
        Graphics graphic;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index;
        int x, y, sX, sY, cX, cY;
        ColorDialog cd = new ColorDialog();
        Color new_color;
       

        private void circle_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void Line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphic = e.Graphics;
            if(paint)
            {
                if (index == 3)
                {
                    graphic.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    graphic.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    graphic.DrawLine(p, cX, cY, x, y);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            graphic.Clear(Color.White);
            pic.Image = bm;
            index = 0;
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            picColor.BackColor = cd.Color;
            p.Color = cd.Color;
        }
        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f*pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(color_picker, e.Location);
            picColor.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
            new_color = picColor.BackColor;
            p.Color = picColor.BackColor;
        }
        private void Validate(Bitmap bm, Stack<Point>sp,int x, int y,Color old_color,Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if(cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }
        public void fill(Bitmap bm,int x,int y,Color new_color)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x,y));
            bm.SetPixel(x, y, new_color);
            if(old_color==new_color)
            {
                return;
            }
            while(pixel.Count>0)
            {
                Point pt = (Point)pixel.Pop();
                if(pt.X>0 &&pt.Y>0 &&pt.X<bm.Width-1&&pt.Y<bm.Height-1)
                {
                    Validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_color);
                    Validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_color);
                    Validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_color);
                    Validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_color);

                }
            }
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if(index == 7)
            {
                Point point = set_point(pic, e.Location);
                fill(bm, point.X, point.Y, new_color);
            }
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image Files only | *.jpg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName);

            }
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;

        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if(paint)
            {
                if(index == 1)
                {
                    px = e.Location;
                    graphic.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    graphic.DrawLine(erase, px, py);
                    py = px;
                }
            }
            pic.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sX = x - cX;
            sY = y - cY;

            if(index == 3)
            {
                graphic.DrawEllipse(p, cX, cY, sX, sY);
            }
            if(index == 4)
            {
                graphic.DrawRectangle(p, cX, cY, sX, sY);
            }
            if(index == 5)
            {
                graphic.DrawLine(p, cX, cY, x, y);
            }
        }

        private void pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
