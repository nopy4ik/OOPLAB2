﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FLib;

namespace OOPLAB2
{
    public partial class FormRe : Form
    {
        private FLib.Rectangle rect;
        private PictureBox pic;
        private Bitmap bmp;
        private Button butt;
        public FormRe(PictureBox pic, Bitmap bmp, Button butt)
        {
            InitializeComponent();
            this.pic = pic;
            this.bmp = bmp;
            this.butt = butt;
            rect = new FLib.Rectangle(pic, bmp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            butt.Enabled = true;
            Close();
        }

        private void BDraw_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0, w = 0, h = 0;
            try
            {
                x = int.Parse(setX.Text);
                y = int.Parse(setY.Text);
                w = int.Parse(setW.Text);
                h = int.Parse(setH.Text);
                rect.DeleteF(rect, true);
                rect = new FLib.Rectangle(x, y, w, h, pic, bmp);
                rect.Draw(rect.pen);
                BDraw.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormRe_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void BNewXY_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            try
            {
                x = int.Parse(newX.Text);
                y = int.Parse(newY.Text);
                rect.MoveTo(x, y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BNewWH_Click(object sender, EventArgs e)
        {
            int w = 0, h = 0;
            try
            {
                w = int.Parse(newW.Text);
                h = int.Parse(newH.Text);
                rect.ChangeSizeTo(w, h);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
