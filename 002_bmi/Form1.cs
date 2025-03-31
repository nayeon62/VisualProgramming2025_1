using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_bmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            double height = double.Parse(txtH.Text);
            double weight = double.Parse(txtW.Text);
            double bmi = weight / (height / 100 * height / 100);
            lblBMI.Text = "BMI= " + bmi;
        }
    }
}
