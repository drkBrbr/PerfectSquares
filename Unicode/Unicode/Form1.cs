using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicode
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.istUnicode.Items.Clear();

            for (int Counter = 65; Counter <= 91; Counter++);
            string letter = Convert.ToSingle(char.ConvertFromUtf32(Counter));

            this.istUnicode.Items.Add();
        }
    }
}
