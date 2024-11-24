using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace CoinActivity
{
    public partial class Form1 : Form
    {
        Bitmap loaded;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap m = (Bitmap)pictureBox1.Image.Clone();
            BitmapFilter.Binary(m, 200);
            Coins.CountCoin(m, ref label1, ref label2);
            pictureBox2.Image = m;


        }
    }

}
