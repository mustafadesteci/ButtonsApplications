using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You were click");
            this.Close();
        }

        Random random = new Random();
        int step=0;
        private void button_MouseHover(object sender,EventArgs e)
        {
            step += 60;         
            Button btn = (sender as Button);
            btn.BackColor = Color.Green;
            btn.Left = random.Next(0,Width-10);
            btn.Left = step;  
            Thread.Sleep(70);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
