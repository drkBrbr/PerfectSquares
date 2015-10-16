using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tempature
{
    public partial class frmtemperature : Form
    {
        int temp;

        public frmtemperature()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            temp = Convert.ToInt32(this.txtTemp.Text) * 9 / 5 + 32;

            this.lblAnswer.Text = "Temperature in Fahrenheit is " + temp;
        }
    }
}
