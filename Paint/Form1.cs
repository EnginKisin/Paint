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
    public partial class Paint : Form
    {
        Graphics graphics;
        int x = -1;
        int y = -1;
        Pen pencil;
        bool ctrl = false;
        Bitmap bitmap;

        public Paint()
        {
            InitializeComponent();
            graphics = pnlWrite.CreateGraphics();
            pencil = new Pen(Color.Black, 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pnlWrite.Width, pnlWrite.Height);
        }

        private void AppClose(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AppMaximize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void AppMinimize(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SelectedColor(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            pencil.Color = panel.BackColor;
        }

        private void pnlWrite_MouseDown(object sender, MouseEventArgs e)
        {
            ctrl = true;
            x = e.X;
            y = e.Y;
        }

        private void pnlWrite_MouseMove(object sender, MouseEventArgs e)
        {
            if (ctrl && x != -1 && y != -1)
            {
                graphics.DrawLine(pencil, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void pnlWrite_MouseUp(object sender, MouseEventArgs e)
        {
            ctrl = false;
            x = e.X;
            y = e.Y;
        }

        private void SelectedShape(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            PictureBox[] ptb = { ptbRectangle, ptbOval};
            Rectangle rectangle = new Rectangle(x, y, 50, 50);
            if (pb == ptb[0])
            {
                graphics.DrawRectangle(pencil, rectangle);
            }
            else if (pb == ptb[1])
            {
                graphics.DrawEllipse(pencil, rectangle);
            }
        }

        private void ptbFillWithColor_Click(object sender, EventArgs e)
        {
            pnlWrite.BackColor = pencil.Color;
        }

        private void ptbRubber_Click(object sender, EventArgs e)
        {
            pnlWrite.Invalidate();
            pnlWrite.BackColor = SystemColors.Control;
        }

        private void ptbNewForm_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ptbOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            System.Diagnostics.Process.Start(openFileDialog.FileName);
        }

        private void ptbSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog diag = new SaveFileDialog();
            DialogResult dr = diag.ShowDialog();
            string _filename = diag.FileName;
            bitmap.Save(_filename, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

    }
}
