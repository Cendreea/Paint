using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FörståPaint
{
    class Figur : Panel
    {

        protected Point startPos;
        protected Point currentPos;
        protected bool drawing;
        protected List<Rectangle> figures = new List<Rectangle>();
        //protected List<Rectangle> figures1 = new List<Rectangle>();
        //protected List<Rectangle> figures2 = new List<Rectangle>();
        public bool rect;
        public bool filledrect;
        public bool circle;
        public bool filledcircle;
        public bool line;
        Graphics g;
        

        public Figur()
        {

            this.BackColor = Color.CadetBlue;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Width = 800;
            this.Height = 800;
            Bitmap bit = new Bitmap(this.Width, this.Height, this.CreateGraphics());
            g = this.CreateGraphics();
        }

        protected Rectangle GetRectangle()
        {

            return new Rectangle(
                Math.Min(startPos.X, currentPos.X),
                Math.Min(startPos.Y, currentPos.Y),
                Math.Abs(startPos.X - currentPos.X),
                Math.Abs(startPos.Y - currentPos.Y));
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            currentPos = startPos = e.Location;
            drawing = true;

        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            currentPos = e.Location;
            if (drawing) this.Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (drawing)
            {
                drawing = false;
                var rc = GetRectangle();
                if (rc.Width > 0 && rc.Height > 0)
                {
                   
                        figures.Add(rc);
                        this.Invalidate();  //rita om fönstret
                }

            }

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (rect)
            {

                if (figures.Count > 0)
                {
                    e.Graphics.DrawRectangles(Pens.Black, figures.ToArray());
                }
                if (drawing) e.Graphics.DrawRectangle(Pens.Red, GetRectangle());

            }
            else if (filledrect)
            {

                SolidBrush brush = new SolidBrush(Color.HotPink);

                if (figures.Count > 0)
                {

                    foreach (Rectangle r in figures)
                    {
                        e.Graphics.FillRectangle(brush, r);
                    }
                }
                if (drawing) e.Graphics.FillRectangle(brush, GetRectangle());

            }
            else if (circle)
            {
                if (figures.Count > 0)
                {
                    foreach (Rectangle r in figures)
                    {
                        e.Graphics.DrawEllipse(Pens.Red, r);
                    }
                }
                if (drawing)
                {
                    e.Graphics.DrawEllipse(Pens.Black, GetRectangle());
                }
            }
            else if (filledcircle)
            {
                SolidBrush brush = new SolidBrush(Color.HotPink);

                if (figures.Count > 0)
                {

                    foreach (Rectangle r in figures)
                    {
                        e.Graphics.FillEllipse(brush, r);
                    }
                }
                if (drawing) e.Graphics.FillEllipse(brush, GetRectangle());

            }

            else if (line)
            {
                if (drawing)
                {
                    e.Graphics.DrawLine(Pens.Black, startPos, currentPos);   
                }
            }

            else {

                Pen pen = new Pen(Color.Black, 14);
                pen.EndCap = LineCap.Round;
                pen.StartCap = LineCap.Round;

            } 
        
        }

    }
}
