using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_DoiColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          RadioButton r=(RadioButton)sender;
            switch (r.Name)
            {
                case "radred":
                    lblLapTrinh.ForeColor=Color.Red;
                    txtnhapten.ForeColor = Color.Red;
                    txtLapTrinh.ForeColor = Color.Red;
                    break;
                case "radxanhla":
                    lblLapTrinh.ForeColor = (Color)Color.Green;
                    txtnhapten.ForeColor= (Color)Color.Green;
                    txtLapTrinh.ForeColor =(Color)Color.Green;
                    break;
                case "radxanhbien":
                    lblLapTrinh.ForeColor = (Color)Color.Blue;
                    txtnhapten.ForeColor =(Color)Color.Blue;
                    txtLapTrinh.ForeColor= (Color)Color.Blue;
                    break;
                case "radden":
                    lblLapTrinh.ForeColor = (Color)Color.Black;
                    txtnhapten.ForeColor=(Color)Color.Black; 
                    txtLapTrinh.ForeColor=(Color)Color.Black;
                    break

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtnhapten_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Green;
            txtnhapten.ForeColor = Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Blue;
            txtnhapten.ForeColor = Color.Blue;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Black;
            txtnhapten.ForeColor = Color.Black;
        }

        private void lblLapTrinh_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cse
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
