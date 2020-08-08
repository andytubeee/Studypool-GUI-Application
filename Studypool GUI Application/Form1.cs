using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Studypool_GUI_Application
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		//Initalizing base numbers
		double num1, num2, num3, num4;

		private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Check if key pressed is number or decimal, we do not allow anything else.
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
		(e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			// Allow the user to only enter one decimal point
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}

		private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Check if key pressed is number or decimal, we do not allow anything else.
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
		(e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			// Allow the user to only enter one decimal point
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			// Safely shuts the program
			Application.Exit();
		}

		private void txtNum3_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Check if key pressed is number or decimal, we do not allow anything else.
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
		(e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			// Allow the user to only enter one decimal point
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}

		private void txtNum4_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Check if key pressed is number or decimal, we do not allow anything else.
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
		(e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			// Allow the user to only enter one decimal point
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}
		private void btnCalc_Click(object sender, EventArgs e)
		{
			/*if (String.IsNullOrEmpty(txtNum1.Text)|| String.IsNullOrEmpty(txtNum2.Text)|| String.IsNullOrEmpty(txtNum3.Text)|| String.IsNullOrEmpty(txtNum1.Text))
			{
				MessageBox.Show("Please Enter All 4 Numbers");
			}
			else
			{
				double num1 = Convert.ToDouble(txtNum1.Text);
				double num2 = Convert.ToDouble(txtNum2.Text);
				double num3 = Convert.ToDouble(txtNum3.Text);
				double num4 = Convert.ToDouble(txtNum4.Text);
			}*/
			try
			{
				double num1 = Convert.ToDouble(txtNum1.Text);
				double num2 = Convert.ToDouble(txtNum2.Text);
				double num3 = Convert.ToDouble(txtNum3.Text);
				double num4 = Convert.ToDouble(txtNum4.Text);


				double s = (num1 + num2 + num3 + num4);
				// Converting to standard numeric form
				if ((s % 1) == 0)
				{
					// If the product has no decimal, remove decimal and format the number.
					string sum = s.ToString("N0");
					lblSum.Text = "Sum: " + sum;
				}
				else
				{
					// Else, if it has decmial, only format numbers before decimal, keep the number after decimal.
					string sum = s.ToString();
					double beforeDecimal = Convert.ToDouble(sum.Split('.').First());
					var afterDecimal = sum.Split('.')[1];
					lblSum.Text = "Sum: " + beforeDecimal.ToString("N0") + "." + afterDecimal.ToString();
				}

				double p = (num1 * num2 * num3 * num4);

				// Converting to standard numeric form
				if ((p % 1) == 0)
				{
					// If the product has no decimal, remove decimal and format the number.
					string product = p.ToString("N0");
					lblProd.Text = "Product: " + product;
				}
				else
				{
					// Else, if it has decmial, only format numbers before decimal, keep the number after decimal.
					string product = p.ToString();
					double beforeDecimal = Convert.ToDouble(product.Split('.').First());
					var afterDecimal = product.Split('.')[1];
					lblProd.Text = "Product: " + beforeDecimal.ToString("N0")+"."+afterDecimal.ToString();
				}
				if (lblProd.Text.ToString().Length >= 28)
				{
					lblProd.Text = "Product: UI Overflow. Reduce your Input.";
				}

					// Put all the numbers in an array
					double[] numArr = { num1, num2, num3, num4 };

				double sm = numArr.Min();
				// Converting to standard numeric form
				if ((sm % 1) == 0)
				{
					// If the product has no decimal, remove decimal and format the number.
					string smallest = sm.ToString("N0");
					lblSmallest.Text = "Smallest: " + smallest;
				}
				else
				{
					// Else, if it has decmial, only format numbers before decimal, keep the number after decimal.
					string smallest = sm.ToString();
					double beforeDecimal = Convert.ToDouble(smallest.Split('.').First());
					var afterDecimal = smallest.Split('.')[1];
					lblSmallest.Text = "Smallest: " + beforeDecimal.ToString("N0") + "." + afterDecimal.ToString();
				}
				
				double la = numArr.Max();

				// Converting to standard numeric form
				if ((la % 1) == 0)
				{
					// If the product has no decimal, remove decimal and format the number.
					string largest = la.ToString("N0");
					lblLargest.Text = "Largest: " + largest;
				}
				else
				{
					// Else, if it has decmial, only format numbers before decimal, keep the number after decimal.
					string largest = la.ToString();
					double beforeDecimal = Convert.ToDouble(largest.Split('.').First());
					var afterDecimal = largest.Split('.')[1];
					lblLargest.Text = "Largest: " + beforeDecimal.ToString("N0") + "." + afterDecimal.ToString();
				}
				if (lblLargest.Text.Length >= 28)
				{
					lblLargest.Text = "Largest: UI Overflow. Reduce your Input.";
				}
			}
			catch (Exception ex)
			{
				if(ex.Message.ToString()=="Input string was not in a correct format.")
				{
					MessageBox.Show("Please Enter All 4 Numbers", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					MessageBox.Show("Unknown error, please restart. Sorry for the inconvenience.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					Application.Exit();
				}
			}
		}
	}
}
