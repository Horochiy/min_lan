using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public int mem;

        public Form2()
        {
            InitializeComponent();
        }

        public void MoveVindow(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mem = 2048;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mem = 512;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mem = 1024;
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mem = 3072;
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mem = 4096;
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mem = 6144;
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.exit3;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.exit1;
        }
    }
}
