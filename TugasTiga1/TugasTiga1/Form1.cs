using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblNIM.Text = "22.61.0239";
            lblNAMA.Text = "Dawam Amali";
            lblKELAS.Text = "22.61.0239";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblNIM.Text = "";
            lblNAMA.Text = "";
            lblKELAS.Text = "";
        }
    }
}
