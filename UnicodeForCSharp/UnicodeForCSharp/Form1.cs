using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicodeForCSharp
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnShowUnicode_Click(object sender, EventArgs e)
        {
            this.lstUnicode.Items.Clear();
            for (int firstNumber = 65; firstNumber <= 90; firstNumber++)
            {
                for (int secondNumber = 97; secondNumber <= 122; secondNumber++)
                {
                    this.lstUnicode.Items.Add(Char.ConvertFromUtf32(firstNumber) + " --> " + Char.ConvertFromUtf32(secondNumber));
                }
                
            }

        }
    }
}
