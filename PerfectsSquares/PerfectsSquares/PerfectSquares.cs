/*
 * Created by: Derek Barber
 * Created on: 13-Oct-2015
 * Created for: ICS3U
 * Daily Assignment – Unit #3-09
 * This program all the perfect squares between 1 and the number the user inputs
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectsSquares
{
    public partial class frmPerfectSquares : Form
    {
        public frmPerfectSquares()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int valueCounter;
            int maximumValue;
            double currentValue;
            double squareRootAsDouble;
            int squareRootAsInteger;
            int numberOfPerfectSquares = 0;

            this.lstPerfectSquares.Items.Clear();
            currentValue = 1;
            maximumValue = Convert.ToInt32(this.nudNumber.Value);
            valueCounter = 0;

            while (currentValue <= maximumValue)
            {
                squareRootAsDouble = Math.Sqrt(currentValue);
                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);
                if (squareRootAsInteger == squareRootAsDouble)
                {
                    numberOfPerfectSquares++;
                    this.lstPerfectSquares.Items.Add(currentValue);
                    currentValue++;
                }
                else
                {
                    currentValue++;
                }
                valueCounter++;
            }



        }
    }
}
