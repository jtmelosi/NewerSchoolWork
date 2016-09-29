using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroProject
{
    public partial class CheckbookSelectionForm : Form
    {
        public CheckbookSelectionForm()
        {
            InitializeComponent();
        }

        // the next two functions clean up what happens when each radio button is selected
        private void OpenBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (OpenBtn.Checked)
            {
                // allows all relevant options
                OpenFileBtn.Visible = true;
                FileNameText.Visible = true;
                FileNameText.Text = null;

                // hides irrelevant options
                NameLabel.Visible = false;
                NameText.Visible = false;
                BalanceLabel.Visible = false;
                BalanceText.Visible = false;
            }
                
        }

        private void NewBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (NewBtn.Checked)
            {
                // hides irrelevant options
                OpenFileBtn.Visible = false;
                FileNameText.Visible = false;
                FileNameText.Text = null;

                // allows all relevant options
                NameLabel.Visible = true;
                NameText.Visible = true;
                NameText.Text = null;
                BalanceLabel.Visible = true;
                BalanceText.Visible = true;
                BalanceText.Text = null;
            }
                
        }

        // allows the selection of a .cbk file
        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Cbk Files (*.cbk)|*.cbk";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FileNameText.Text = fileDialog.FileName;
            }
        }
        // sends input through validation, and then opens up the transaction form
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (correctInput())
            {
                if (OpenBtn.Checked)
                {
                    checkbook checkbook = new checkbook(FileNameText.Text);
                    input_gui input = new input_gui(checkbook);
                    input.Show();
                    Hide();
                }
                else if (NewBtn.Checked)
                {
                    double amount = Convert.ToDouble(BalanceText.Text);
                    checkbook checkbook = new checkbook(NameText.Text + ".cbk", amount);
                    input_gui input = new input_gui(checkbook);
                    input.Show();
                    Hide();
                }
            }
        }

        // checks input of selected option
        private bool correctInput()
        {
            if (OpenBtn.Checked)
            {
                if (FileNameText.Text.Length < 1)
                {
                    // checks to see if a file was chosen
                    MessageBox.Show("Select a checkbook.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            } else if (NewBtn.Checked)
            {
                // checks to see if a name was input
                if (NameText.Text.Length < 1)
                {
                    MessageBox.Show("Name the new checkbook.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // checks to see if the amount was a valid dollar amount in the correct format
                int periodCount = 0;
                int periodSpot = 0;
                int charSpot = -1;
                string amountString = BalanceText.Text;
                string response;
                foreach (char c in amountString)
                {
                    charSpot++;
                    if (c != '.')
                    {
                        if (!Char.IsDigit(c))
                        {
                            response = "Please only submit numbers and a period.";
                            MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        periodCount++;
                        periodSpot = charSpot;
                    }
                }
                if (periodCount != 1)
                {
                    response = "Please include a singular period in the amount input.";
                    MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (periodSpot != amountString.Length - 3)
                {
                    response = "Please place a period before exactly the last two digits in the amount.";
                    MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // check if amount is above 0
                double doubleValue = Convert.ToDouble(amountString);
                if (doubleValue <= 0)
                {
                    response = "Please submit an amount with a value higher than 0.";
                    MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            } else
            {
                MessageBox.Show("Select an option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
