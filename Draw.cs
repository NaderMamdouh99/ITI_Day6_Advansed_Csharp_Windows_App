﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day6
{
    public partial class Draw : Form
    {
        public int x, y, score;
        Graphics g;
        public Draw()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                Pen redPen = new Pen(Color.Red);
                redPen.Width = 30;
                

                g.DrawLine(redPen, x, y, e.X, e.Y);
            }
            if (e.Button == MouseButtons.Right)
            {

                Pen whitePen = new Pen(Color.White);
                whitePen.Width = 30;

                g.DrawLine(whitePen, x, y, e.X, e.Y);
            }
            x = e.X;
            y = e.Y;

        }
        private void Draw_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
