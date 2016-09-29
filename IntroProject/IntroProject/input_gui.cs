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
    public partial class input_gui : Form
    {
        string response;
        checkbook checkbook;

        public input_gui(checkbook usedBook)
        {
            InitializeComponent();
            checkbook = usedBook;

            double doubleToTruncate = Math.Truncate(checkbook.getBalance() * 100) / 100;
            string formattedStr = string.Format("{0:N2}", doubleToTruncate);

            BalAmtLabel.Text = "$" + formattedStr + "";
        }

        // THESE ARE THE CHECKBOOK FUNCTIONS FOR REFERENCE
        // Checkbook(string name)     loading one
        // Checkbook(string name, double balance)       making a new one
        // check(double amount, string memo, string name, bool showCheck)      
        // cash(double amount, string memo)
        // deposit(double amount, string memo)
        // getBalance()     returns a double

        // runs through input validation, and figures out what the user wants and sends the information off to be processed
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // if it doesnt pass validation, an error will appear
            if (!isCorrectInput(NameTextBox.Text, AmountTextBox.Text, MemoTextBox.Text))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // if it does pass validation, it will figure out how to send the data
            else
            {
                double amount = Convert.ToDouble(AmountTextBox.Text);
                if (CheckBtn.Checked) // if check is selected
                {
                    checkbook.check(AmountTextBox.Text, MemoTextBox.Text, NameTextBox.Text, ShowCheckBox.Checked);
                } else if (CashBtn.Checked) // if cash is selected
                {
                    checkbook.cash(amount, MemoTextBox.Text);
                } else if (DepositBtn.Checked) // if deposit is selected
                {
                    checkbook.deposit(amount, MemoTextBox.Text);
                } else // if none are selected
                {
                    MessageBox.Show("Please select an option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // updates balance
                double doubleToTruncate = Math.Truncate(checkbook.getBalance() * 100) / 100;
                string formattedStr = string.Format("{0:N2}", doubleToTruncate);

                BalAmtLabel.Text = "$" + formattedStr + "";

                //Show();
            }
            

        }

        // clears all field info, and deselects the radio button selected
        private void clearButton_Click(object sender, EventArgs e)
        {
            // clears all fields
            NameTextBox.Text = null;
            AmountTextBox.Text = null;
            MemoTextBox.Text = null;

            // deselect radio button
            CheckBtn.Checked = false;
            CashBtn.Checked = false;
            DepositBtn.Checked = false;
            ShowCheckBox.Checked = false;

            Show();
        }

        private void input_gui_Load(object sender, EventArgs e)
        {

        }

        // make sure input received is acceptable
        private bool isCorrectInput(string name, string amountString, string memo)
        {
            // check if input is acceptable
            int periodCount = 0;
            int periodSpot = 0;
            int charSpot = -1;
            foreach (char c in amountString)
            {
                charSpot++;
                if (c != '.')
                {
                    if (!Char.IsDigit(c))
                    {
                        response = "Please only submit numbers and a period.";
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
                return false;
            }
            if (periodSpot != amountString.Length - 3)
            {
                response = "Please place a period before exactly the last two digits in the amount.";
                return false;
            }

            // check if amount is acceptable
            double doubleValue = Convert.ToDouble(amountString);
            if (doubleValue >= 10000)
            {
                response = "Please submit an amount with a value lower than 10,000.";
                return false;
            }
            if (doubleValue <= 0)
            {
                response = "Please submit an amount with a value higher than 0.";
                return false;
            }
            // name and memo character limit
            int nameLengthMax = 13;
            if (name.Length >= nameLengthMax)
            {
                response = "Please limit the name to less than " + nameLengthMax + " characters.";
                return false;
            }
            int memoLengthMax = 25;
            if (memo.Length >= memoLengthMax)
            {
                response = "Please limit the name to less than " + nameLengthMax + " characters.";
                return false;
            }

            response = "";
            return true;
        }

        // the following 3 functions manage the radio buttons and anything that is altered due to them
        private void CheckBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBtn.Checked)
            {
                NameLabel.Visible = true;
                NameTextBox.Visible = true;
                ShowCheckBox.Visible = true;
                NameTextBox.Text = null;
            }
            
        }

        private void CashBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (CashBtn.Checked)
            {
                NameLabel.Visible = false;
                NameTextBox.Visible = false;
                ShowCheckBox.Checked = false;
                ShowCheckBox.Visible = false;
            }
            
        }

        private void DepositBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (DepositBtn.Checked)
            {
                NameLabel.Visible = false;
                NameTextBox.Visible = false;
                ShowCheckBox.Checked = false;
                ShowCheckBox.Visible = false;
            }
            
        }

        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            CheckbookSelectionForm csf = new CheckbookSelectionForm();
            csf.Show();
            Hide();
        }
    }
}


