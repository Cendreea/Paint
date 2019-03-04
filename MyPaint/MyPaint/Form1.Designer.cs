namespace MyPaint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Penna = new System.Windows.Forms.RadioButton();
            this.Cirkel = new System.Windows.Forms.RadioButton();
            this.Rektangel = new System.Windows.Forms.RadioButton();
            this.Linje = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Radergummi = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Penna
            // 
            this.Penna.AutoSize = true;
            this.Penna.Location = new System.Drawing.Point(34, 205);
            this.Penna.Name = "Penna";
            this.Penna.Size = new System.Drawing.Size(70, 21);
            this.Penna.TabIndex = 0;
            this.Penna.TabStop = true;
            this.Penna.Text = "Penna";
            this.Penna.UseVisualStyleBackColor = true;
            // 
            // Cirkel
            // 
            this.Cirkel.AutoSize = true;
            this.Cirkel.Location = new System.Drawing.Point(34, 286);
            this.Cirkel.Name = "Cirkel";
            this.Cirkel.Size = new System.Drawing.Size(64, 21);
            this.Cirkel.TabIndex = 2;
            this.Cirkel.TabStop = true;
            this.Cirkel.Text = "Cirkel";
            this.Cirkel.UseVisualStyleBackColor = true;
            // 
            // Rektangel
            // 
            this.Rektangel.AutoSize = true;
            this.Rektangel.Location = new System.Drawing.Point(34, 259);
            this.Rektangel.Name = "Rektangel";
            this.Rektangel.Size = new System.Drawing.Size(93, 21);
            this.Rektangel.TabIndex = 3;
            this.Rektangel.TabStop = true;
            this.Rektangel.Text = "Rektangel";
            this.Rektangel.UseVisualStyleBackColor = true;
            // 
            // Linje
            // 
            this.Linje.AutoSize = true;
            this.Linje.Location = new System.Drawing.Point(34, 232);
            this.Linje.Name = "Linje";
            this.Linje.Size = new System.Drawing.Size(59, 21);
            this.Linje.TabIndex = 4;
            this.Linje.TabStop = true;
            this.Linje.Text = "Linje";
            this.Linje.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(22, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(184, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 610);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Penna";
            // 
            // Radergummi
            // 
            this.Radergummi.AutoSize = true;
            this.Radergummi.Location = new System.Drawing.Point(34, 313);
            this.Radergummi.Name = "Radergummi";
            this.Radergummi.Size = new System.Drawing.Size(108, 21);
            this.Radergummi.TabIndex = 8;
            this.Radergummi.TabStop = true;
            this.Radergummi.Text = "Radergymmi";
            this.Radergummi.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Öppna";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Spara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 634);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Radergummi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Linje);
            this.Controls.Add(this.Rektangel);
            this.Controls.Add(this.Cirkel);
            this.Controls.Add(this.Penna);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MyPaint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Penna;
        private System.Windows.Forms.RadioButton Cirkel;
        private System.Windows.Forms.RadioButton Rektangel;
        private System.Windows.Forms.RadioButton Linje;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Radergummi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

