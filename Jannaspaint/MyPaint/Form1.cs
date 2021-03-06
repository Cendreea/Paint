﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        bool draw = false;

        int pX = -1;
        int pY = -1;

        Bitmap drawing;

        public Form1()
        {
            InitializeComponent();
            drawing = new Bitmap(panel1.Width, panel1.Height, panel1.CreateGraphics());
            Graphics.FromImage(drawing);
            g = panel1.CreateGraphics();
            //btnCanvasColor(BackColor.C)
        }

        Graphics g;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;

            pX = e.X;
            pY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Graphics panel = Graphics.FromImage(drawing);

                Pen pen = new Pen(button1.BackColor, float.Parse(tbxPenStl.Text));

                pen.EndCap = LineCap.Round;
                pen.StartCap = LineCap.Round;

                panel.DrawLine(pen, pX, pY, e.X, e.Y);

                panel1.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
            }

            pX = e.X;
            pY = e.Y;
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(drawing, new Point(0, 0));
        }

        private void btnCanvasColor_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = c.Color;
                btnCanvasColor.BackColor = c.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = c.Color;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
