
namespace Paint
{
    partial class Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.pnlPaint = new System.Windows.Forms.Panel();
            this.ptbNewForm = new System.Windows.Forms.PictureBox();
            this.ptbMinimize = new System.Windows.Forms.PictureBox();
            this.ptbMaximize = new System.Windows.Forms.PictureBox();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.ptbFillWithColor = new System.Windows.Forms.PictureBox();
            this.ptbRubber = new System.Windows.Forms.PictureBox();
            this.ptbRectangle = new System.Windows.Forms.PictureBox();
            this.ptbOval = new System.Windows.Forms.PictureBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPaint = new System.Windows.Forms.Label();
            this.pnlWrite = new System.Windows.Forms.Panel();
            this.pnlPaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNewForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFillWithColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRubber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOval)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPaint
            // 
            this.pnlPaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlPaint.Controls.Add(this.ptbNewForm);
            this.pnlPaint.Controls.Add(this.ptbMinimize);
            this.pnlPaint.Controls.Add(this.ptbMaximize);
            this.pnlPaint.Controls.Add(this.ptbClose);
            this.pnlPaint.Controls.Add(this.ptbFillWithColor);
            this.pnlPaint.Controls.Add(this.ptbRubber);
            this.pnlPaint.Controls.Add(this.ptbRectangle);
            this.pnlPaint.Controls.Add(this.ptbOval);
            this.pnlPaint.Controls.Add(this.panel14);
            this.pnlPaint.Controls.Add(this.panel9);
            this.pnlPaint.Controls.Add(this.panel15);
            this.pnlPaint.Controls.Add(this.panel10);
            this.pnlPaint.Controls.Add(this.panel11);
            this.pnlPaint.Controls.Add(this.panel12);
            this.pnlPaint.Controls.Add(this.panel13);
            this.pnlPaint.Controls.Add(this.panel6);
            this.pnlPaint.Controls.Add(this.panel7);
            this.pnlPaint.Controls.Add(this.panel8);
            this.pnlPaint.Controls.Add(this.panel4);
            this.pnlPaint.Controls.Add(this.panel5);
            this.pnlPaint.Controls.Add(this.panel3);
            this.pnlPaint.Controls.Add(this.panel2);
            this.pnlPaint.Controls.Add(this.lblPaint);
            this.pnlPaint.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPaint.Location = new System.Drawing.Point(0, 0);
            this.pnlPaint.Name = "pnlPaint";
            this.pnlPaint.Size = new System.Drawing.Size(768, 138);
            this.pnlPaint.TabIndex = 0;
            // 
            // ptbNewForm
            // 
            this.ptbNewForm.Image = ((System.Drawing.Image)(resources.GetObject("ptbNewForm.Image")));
            this.ptbNewForm.Location = new System.Drawing.Point(18, 74);
            this.ptbNewForm.Name = "ptbNewForm";
            this.ptbNewForm.Size = new System.Drawing.Size(50, 31);
            this.ptbNewForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbNewForm.TabIndex = 3;
            this.ptbNewForm.TabStop = false;
            this.ptbNewForm.Click += new System.EventHandler(this.ptbNewForm_Click);
            // 
            // ptbMinimize
            // 
            this.ptbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimize.Image")));
            this.ptbMinimize.Location = new System.Drawing.Point(658, 3);
            this.ptbMinimize.Name = "ptbMinimize";
            this.ptbMinimize.Size = new System.Drawing.Size(32, 31);
            this.ptbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMinimize.TabIndex = 3;
            this.ptbMinimize.TabStop = false;
            this.ptbMinimize.Click += new System.EventHandler(this.AppMinimize);
            // 
            // ptbMaximize
            // 
            this.ptbMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMaximize.Image = ((System.Drawing.Image)(resources.GetObject("ptbMaximize.Image")));
            this.ptbMaximize.Location = new System.Drawing.Point(696, 3);
            this.ptbMaximize.Name = "ptbMaximize";
            this.ptbMaximize.Size = new System.Drawing.Size(32, 31);
            this.ptbMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMaximize.TabIndex = 3;
            this.ptbMaximize.TabStop = false;
            this.ptbMaximize.Click += new System.EventHandler(this.AppMaximize);
            // 
            // ptbClose
            // 
            this.ptbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ptbClose.Image = ((System.Drawing.Image)(resources.GetObject("ptbClose.Image")));
            this.ptbClose.Location = new System.Drawing.Point(734, 3);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(32, 31);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClose.TabIndex = 3;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.AppClose);
            // 
            // ptbFillWithColor
            // 
            this.ptbFillWithColor.BackColor = System.Drawing.Color.White;
            this.ptbFillWithColor.Image = ((System.Drawing.Image)(resources.GetObject("ptbFillWithColor.Image")));
            this.ptbFillWithColor.Location = new System.Drawing.Point(139, 74);
            this.ptbFillWithColor.Name = "ptbFillWithColor";
            this.ptbFillWithColor.Size = new System.Drawing.Size(32, 31);
            this.ptbFillWithColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFillWithColor.TabIndex = 1;
            this.ptbFillWithColor.TabStop = false;
            this.ptbFillWithColor.Click += new System.EventHandler(this.ptbFillWithColor_Click);
            // 
            // ptbRubber
            // 
            this.ptbRubber.BackColor = System.Drawing.Color.White;
            this.ptbRubber.Image = ((System.Drawing.Image)(resources.GetObject("ptbRubber.Image")));
            this.ptbRubber.Location = new System.Drawing.Point(88, 74);
            this.ptbRubber.Name = "ptbRubber";
            this.ptbRubber.Size = new System.Drawing.Size(32, 31);
            this.ptbRubber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbRubber.TabIndex = 2;
            this.ptbRubber.TabStop = false;
            this.ptbRubber.Click += new System.EventHandler(this.ptbRubber_Click);
            // 
            // ptbRectangle
            // 
            this.ptbRectangle.Image = ((System.Drawing.Image)(resources.GetObject("ptbRectangle.Image")));
            this.ptbRectangle.Location = new System.Drawing.Point(408, 91);
            this.ptbRectangle.Name = "ptbRectangle";
            this.ptbRectangle.Size = new System.Drawing.Size(52, 31);
            this.ptbRectangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbRectangle.TabIndex = 5;
            this.ptbRectangle.TabStop = false;
            this.ptbRectangle.Click += new System.EventHandler(this.SelectedShape);
            // 
            // ptbOval
            // 
            this.ptbOval.Image = ((System.Drawing.Image)(resources.GetObject("ptbOval.Image")));
            this.ptbOval.Location = new System.Drawing.Point(495, 90);
            this.ptbOval.Name = "ptbOval";
            this.ptbOval.Size = new System.Drawing.Size(52, 31);
            this.ptbOval.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbOval.TabIndex = 4;
            this.ptbOval.TabStop = false;
            this.ptbOval.Click += new System.EventHandler(this.SelectedShape);
            // 
            // panel14
            // 
            this.panel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel14.BackColor = System.Drawing.Color.Chocolate;
            this.panel14.Location = new System.Drawing.Point(553, 54);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(23, 21);
            this.panel14.TabIndex = 4;
            this.panel14.Click += new System.EventHandler(this.SelectedColor);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.Green;
            this.panel9.Location = new System.Drawing.Point(495, 27);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(23, 21);
            this.panel9.TabIndex = 6;
            this.panel9.Click += new System.EventHandler(this.SelectedColor);
            // 
            // panel15
            // 
            this.panel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel15.BackColor = System.Drawing.Color.Gold;
            this.panel15.Location = new System.Drawing.Point(495, 54);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(23, 21);
            this.panel15.TabIndex = 5;
            this.panel15.Click += new System.EventHandler(this.SelectedColor);
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(379, 54);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(23, 21);
            this.panel10.TabIndex = 3;
            this.panel10.Click += new System.EventHandler(this.SelectedColor);
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Location = new System.Drawing.Point(379, 27);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(23, 21);
            this.panel11.TabIndex = 4;
            this.panel11.Click += new System.EventHandler(this.SelectedColor);
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.Color.Brown;
            this.panel12.Location = new System.Drawing.Point(408, 54);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(23, 21);
            this.panel12.TabIndex = 5;
            this.panel12.Click += new System.EventHandler(this.SelectedColor);
            // 
            // panel13
            // 
            this.panel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel13.BackColor = System.Drawing.Color.Red;
            this.panel13.Location = new System.Drawing.Point(408, 27);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(23, 21);
            this.panel13.TabIndex = 6;
            this.panel13.Click += new System.EventHandler(this.SelectedColor);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Orange;
            this.panel6.Location = new System.Drawing.Point(437, 54);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(23, 21);
            this.panel6.TabIndex = 3;
            this.panel6.Click += new System.EventHandler(this.SelectedColor);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.Blue;
            this.panel7.Location = new System.Drawing.Point(437, 27);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(23, 21);
            this.panel7.TabIndex = 4;
            this.panel7.Click += new System.EventHandler(this.SelectedColor);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.Purple;
            this.panel8.Location = new System.Drawing.Point(466, 54);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(23, 21);
            this.panel8.TabIndex = 5;
            this.panel8.Click += new System.EventHandler(this.SelectedColor);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(524, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(23, 21);
            this.panel4.TabIndex = 3;
            this.panel4.Click += new System.EventHandler(this.SelectedColor);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Pink;
            this.panel5.Location = new System.Drawing.Point(524, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(23, 21);
            this.panel5.TabIndex = 4;
            this.panel5.Click += new System.EventHandler(this.SelectedColor);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(553, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(23, 21);
            this.panel3.TabIndex = 2;
            this.panel3.Click += new System.EventHandler(this.SelectedColor);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(466, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(23, 21);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.SelectedColor);
            // 
            // lblPaint
            // 
            this.lblPaint.AutoSize = true;
            this.lblPaint.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaint.Location = new System.Drawing.Point(12, 9);
            this.lblPaint.Name = "lblPaint";
            this.lblPaint.Size = new System.Drawing.Size(121, 36);
            this.lblPaint.TabIndex = 0;
            this.lblPaint.Text = "Paint";
            // 
            // pnlWrite
            // 
            this.pnlWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWrite.Location = new System.Drawing.Point(0, 138);
            this.pnlWrite.Name = "pnlWrite";
            this.pnlWrite.Size = new System.Drawing.Size(768, 425);
            this.pnlWrite.TabIndex = 1;
            this.pnlWrite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlWrite_MouseDown);
            this.pnlWrite.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlWrite_MouseMove);
            this.pnlWrite.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlWrite_MouseUp);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 563);
            this.Controls.Add(this.pnlWrite);
            this.Controls.Add(this.pnlPaint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Paint";
            this.Text = "ğ*";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlPaint.ResumeLayout(false);
            this.pnlPaint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNewForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFillWithColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRubber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPaint;
        private System.Windows.Forms.PictureBox ptbRectangle;
        private System.Windows.Forms.PictureBox ptbOval;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPaint;
        private System.Windows.Forms.PictureBox ptbFillWithColor;
        private System.Windows.Forms.PictureBox ptbNewForm;
        private System.Windows.Forms.PictureBox ptbMinimize;
        private System.Windows.Forms.PictureBox ptbMaximize;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.PictureBox ptbRubber;
        private System.Windows.Forms.Panel pnlWrite;
    }
}

