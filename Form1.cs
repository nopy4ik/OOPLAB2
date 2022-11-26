using System;
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
    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
        }
        private void buttonEL_Click(object sender, EventArgs e)
        {
            FormEl el = new FormEl(pictureBox1, bitmap, buttonEL);
            el.Show();
            buttonEL.Enabled = false;
        }

        private void buttonRE_Click(object sender, EventArgs e)
        {
            FormRe re = new FormRe(pictureBox1, bitmap, buttonRE);
            re.Show();
            buttonRE.Enabled = false;
        }

        private void buttonSQ_Click(object sender, EventArgs e)
        {
            FormSQ sq = new FormSQ(pictureBox1, bitmap, buttonSQ);
            sq.Show();
            buttonSQ.Enabled = false;
        }

        private void buttonCI_Click(object sender, EventArgs e)
        {
            FormCi ci = new FormCi(pictureBox1, bitmap, buttonCI);
            ci.Show();
            buttonCI.Enabled = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if(Flist.figures.Count() > 0)
            {
                Flist.figures[0].Clear();
                Flist.figures.Clear();
            }
        }
    }

}
