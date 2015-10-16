using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicodeCSharp
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnCalcualteUnicode_Click(object sender, EventArgs e)
        {
            
            int unicodeValue;
            for (int loop = 65; loop <= 90; loop++ )
            {
                
                this.lstUnicode.Items.Add(Char.ConvertFromUtf32(loop) + " --> " + loop);

            }   

        }
    }
}
