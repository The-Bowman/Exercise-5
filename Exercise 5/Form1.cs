﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_5
{
    public partial class approximatePiForm : Form
    {
        public approximatePiForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int n;
            double pi = 4;

            if (int.TryParse(numberOfTermsTextbox.Text, out n))
            {
                numberOfTermsApproxLabel.Text = "Approximate value of Pi after " + n + " terms.";
                for (int i = 0; i < n; i++)
                {
                    double denom = i * 2 + 3;
                    if (i % 2 == 0)
                    {
                        pi -= (4 / denom);
                    }
                    else
                    {
                        pi += (4 / denom);
                    }
                }

                approxValueOfPi.Text = pi.ToString();

            }
            else
                MessageBox.Show("Invalid entry. Please try again.");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
