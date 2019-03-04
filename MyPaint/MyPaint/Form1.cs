using System;
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
            Graphics.FromImage(drawing).Clear(Color.White);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Graphics panel = Graphics.FromImage(drawing);

                Pen pen = new Pen(Color.Black, 14);

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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
                draw = true;

                pX = e.X;
                pY = e.Y;
        }   
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(drawing, new Point(0, 0));
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    using (var image = Image.FromFile(open.FileName))
                        drawing = new Bitmap(ScaleImage(image, panel1.Width, panel1.Height));
                    panel1.Refresh();
                }
            }

            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
            sf.ShowDialog();
            var path = sf.FileName;
            drawing.Save(path);
        }
    }

}

