using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculatoApp
{
    public partial class InterstCalculatorFOrm : Form
    {
        public InterstCalculatorFOrm()
        {
            InitializeComponent();
        }

        private int time;
        private double balance;
        private double interest;
        
        private void calculateInterestButton_Click_1(object sender, EventArgs e)
        {
            balance = Convert.ToInt32(balanceTextBox.Text);
            time = Convert.ToInt32(timeTextBox.Text);
            string bankType = bankNameComboBox.Text;

            if (bankType == "BRAC")
            {
                interest = (balance * time * 6) / 100;
                resultTextBox.Text = interest.ToString() + " Taka";
            }
            else if (bankType == "DBBL")
            {
                interest = (balance * time * 7) / 100;
                resultTextBox.Text = interest.ToString() + " Taka";
            }
            else if (bankType == "HSBC")
            {
                interest = (balance * time * 8) / 100;
                resultTextBox.Text = interest.ToString() + " Taka";
            }
            else
            {
                MessageBox.Show("Please Select Bank");
            }
        }

        
    }
}
