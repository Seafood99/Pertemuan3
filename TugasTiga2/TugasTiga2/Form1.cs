using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblanimasi.Left -= 10;
            if (lblanimasi.Left < -lblanimasi.Width) lblanimasi.Left = this.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
