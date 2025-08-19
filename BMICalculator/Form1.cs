using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace BMICalculator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e) {

            //Error handling

            if (txbWeight.Text.Length == 0) {
                txbWeight.BackColor = Color.Red;
                txbWeight.ForeColor = Color.Salmon;
                MessageBox.Show("Weight is empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txbHeight.Text.Length == 0) {
                txbHeight.BackColor = Color.Red;
                txbHeight.ForeColor = Color.Salmon;
                MessageBox.Show("Height is empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.Parse(txbHeight.Text) == 0) {
                txbHeight.BackColor = Color.Red;
                txbHeight.ForeColor = Color.Salmon;
                MessageBox.Show("Height cannot be 0", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                //Variable

                double weight = double.Parse(txbWeight.Text, CultureInfo.InvariantCulture);
                double height = double.Parse(txbHeight.Text, CultureInfo.InvariantCulture);


                double result = weight / Math.Pow(height, 2);

                //program
                txbBMI.Text = result.ToString("F2", CultureInfo.InvariantCulture);

                txbHeight.BackColor = Color.White;
                txbHeight.ForeColor = Color.Black;

                txbWeight.BackColor = Color.White;
                txbWeight.ForeColor = Color.Black;


                if (result < 18.5) {
                    lblStatus.Text = "UnderWeight";
                    lblStatus.ForeColor = Color.Orange;
                }
                else if (result >= 18.5 && result <= 24.9) {
                    lblStatus.Text = "Normal";
                    lblStatus.ForeColor = Color.Green;
                }
                else if (result >= 25.0 && result <= 29.9) {
                    lblStatus.Text = "OverWeight";
                    lblStatus.ForeColor = Color.Orange;
                }
                else if (result >= 30.0 && result <= 40.0) {
                    lblStatus.Text = "Obese";
                    lblStatus.ForeColor = Color.Red;
                }
                else {
                    lblStatus.Text = "ExtremeObese";
                    lblStatus.ForeColor = Color.DarkRed;
                }

            }
        }

        //Keyboard shortcut
        private void txbWeight_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                txbHeight.Focus();
            }
            
        }

        private void txbHeight_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnCalculate.PerformClick();
            }
        }

        private void txbWeight_KeyPress(object sender, KeyPressEventArgs e) {
           
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) {
                e.Handled = true; 
           }

        }

        private void txbHeight_KeyPress(object sender, KeyPressEventArgs e) {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) {
                e.Handled = true;
            }

        }
    }
}
