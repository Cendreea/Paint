using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FörståPaint
{
    public partial class Form1 : Form
    {                     
        Figur rita;
        public Form1()
        {
            InitializeComponent();
            rita = new Figur();
            this.Controls.Add(rita);
                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            rita.filledcircle = true;
            rita.circle = false;
            rita.line = false;
            rita.rect = false;
            rita.filledrect = false;
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            rita.circle = true;
            rita.filledcircle = false;
            rita.line = false;
            rita.rect = false;
            rita.filledrect = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rita.line = true;
            rita.circle = false;
            rita.filledcircle = false;
            rita.rect = false;
            rita.filledrect = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rita.line = false;
            rita.circle = false;
            rita.filledcircle = false;
            rita.rect = false;
            rita.filledrect = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rita.rect = true;
            rita.filledrect = false;
            rita.line = false;
            rita.circle = false;
            rita.filledcircle = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rita.rect = false;
            rita.filledrect = true;
            rita.line = false;
            rita.circle = false;
            rita.filledcircle = false;
        }
    }
}
