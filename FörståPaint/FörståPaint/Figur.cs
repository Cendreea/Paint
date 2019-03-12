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
        protected List<Rectangle> figures1 = new List<Rectangle>();
        protected List<Rectangle> figures2 = new List<Rectangle>();
        protected List<Rectangle> figures3 = new List<Rectangle>();
        protected List<Rectangle> figures4 = new List<Rectangle>();
        protected List<Point> listPos1 = new List<Point>();
        protected List<Point> listPos2 = new List<Point>();
        public bool rect;
        public bool filledrect;
        public bool circle;
        public bool filledcircle;
        public bool line;
        Graphics g;
        Bitmap bit;

        protected List<int> p1 = new List<int>();
        protected List<int> p2 = new List<int>();
        protected List<int> p3 = new List<int>();
        protected List<int> p4 = new List<int>();
        int pX = -1;
        int pY = -1;
        int pOne;
        int pTwo;


        public Figur()
        {

            this.BackColor = Color.CadetBlue;
            this.DoubleBuffered = true;

           
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Width = 800;
            this.Height = 800;
            bit = new Bitmap(this.Width, this.Height, this.CreateGraphics());
           
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
            pX = e.X;
            pY = e.Y;

        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            currentPos = e.Location;
            if (drawing)
            {
               

                if (filledcircle || filledrect || rect || circle || line) {
                    this.Invalidate();
                }

                else
                {
                    Graphics panel = Graphics.FromImage(bit);
                    Pen pen = new Pen(Color.Black, 14);
                    pOne = e.X;
                    pTwo = e.Y;

                    pen.EndCap = LineCap.Round;
                    pen.StartCap = LineCap.Round;
                    panel.DrawLine(pen, pX, pY, pOne, pTwo);
                    this.CreateGraphics().DrawImageUnscaled(bit, new Point(0, 0));
                }
            }
            pX = e.X;
            pY = e.Y;

        }
        protected override void OnMouseUp(MouseEventArgs e)
        {

            if (drawing)
            {
                var rc = GetRectangle();

                drawing = false;
                if (circle)
                {


                    if (rc.Width > 0 && rc.Height > 0)
                    {

                        figures.Add(rc);

                        //this.Invalidate();  //rita om fönstret

                    }

                }
                else if (filledcircle)
                {

                    if (rc.Width > 0 && rc.Height > 0)
                    {

                        figures1.Add(rc);

                        // this.Invalidate();  //rita om fönstret

                    }

                }
                else if (filledrect)
                {
                    if (rc.Width > 0 && rc.Height > 0)
                    {

                        figures3.Add(rc);

                        //this.Invalidate();  //rita om fönstret

                    }

                }
                else if (rect)
                {

                    if (rc.Width > 0 && rc.Height > 0)
                    {

                        figures2.Add(rc);

                        //this.Invalidate();  //rita om fönstret

                    }
                }
                else if (line)
                {
                    if (rc.Width > 0 && rc.Height > 0)
                    {

                        figures4.Add(rc);

                        listPos1.Add(currentPos);
                        listPos2.Add(startPos);


                        //this.Invalidate();  //rita om fönstret

                    }
                }


            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.HotPink);
            Pen myPen = Pens.Black;

            this.CreateGraphics().DrawImageUnscaled(bit, new Point(0, 0));
            //-----------------------------------------------------------
            if (rect)
            {
                if (drawing) e.Graphics.DrawRectangle(Pens.Red, GetRectangle());
            }
            //---------------------------------------------------------------
            else if (filledrect)
            {
                if (drawing) e.Graphics.FillRectangle(brush, GetRectangle());
            }

            //-------------------------------------------------------------
            else if (circle)
            {
                if (drawing) e.Graphics.DrawEllipse(Pens.Black, GetRectangle());

            }
            //------------------------------------------------------------
            else if (filledcircle)
            {
                if (drawing) {
                    e.Graphics.FillEllipse(brush, GetRectangle());
                }
            }
            //---------------------------------------------------------------------
            else if (line)
            {
                if (drawing)
                {
                    e.Graphics.DrawLine(myPen, startPos, currentPos);
                }
               
            }
            //--------------------------------------------------------------------
            else
            {

            }
      
            if (figures.Count > 0 || figures1.Count > 0 || figures2.Count > 0 || figures3.Count > 0 || figures4.Count > 0)
            {
                for (int i = 0; i < listPos1.Count; i++) {

                        e.Graphics.DrawLine(myPen, listPos1[i], listPos2[i]);
                    }
                
                foreach (Rectangle r in figures3)
                {
                    e.Graphics.FillRectangle(brush, r);
                }
                foreach (Rectangle r in figures)
                {
                    e.Graphics.DrawEllipse(Pens.Red, r);
                }
                foreach (Rectangle r in figures1)
                {
                    e.Graphics.FillEllipse(brush, r);

                }
              
                if (figures2.Count > 0)
                {
                    e.Graphics.DrawRectangles(Pens.Black, figures2.ToArray());
                    
                }

            }
        }

    }
}
