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
    public partial class output_gui : Form
    {
        public output_gui(string name, string amt, string memo, string date, string checkNum, string alphaAmt)
        {
            InitializeComponent();
            this.name.Text = name;
            this.date.Text = date;
            this.checkNum1.Text = checkNum;
            this.checkNum2.Text = checkNum;
            this.numericAmt.Text = amt;
            this.alphaAmt.Text = alphaAmt;
            this.memo.Text = memo;
        }
    }
}
