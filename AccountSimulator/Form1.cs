﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountSimulator
{
    public partial class Form1 : Form
    {
        private BankAccount account = new BankAccount(1000);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            balanceLabel.Text = account.Balance.ToString("c");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (decimal.TryParse(depositTextBox.Text, out amount))
            {
                account.Deposit(amount);

                balanceLabel.Text = account.Balance.ToString("c");

                depositTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Nieprawdiłowa kwota");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            decimal amount;

            if(decimal.TryParse(withdrawTextBox.Text, out amount))
            {
                account.Withdraw(amount);

                balanceLabel.Text = account.Balance.ToString("c");

                withdrawTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Nieporpawna kwota");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
