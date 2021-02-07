using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MVP.Presenters;
using MVP.Views;
using System.Windows.Forms;

namespace MVP
{
    public partial class Form1 : Form,ICalulatior
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string TxtNumberOne { get => txtNumberOne.Text; set=> txtNumberOne.Text=value; }
        public string TxtNumberTwo { get => txtNumberTwo.Text; set => txtNumberTwo.Text=value; }
        public string TxtResult { get => txtResult.Text; set => txtResult.Text = value; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private CalculatorPrsenter prsenter;
        private void btnSum_Click(object sender, EventArgs e)
        {
            prsenter = new CalculatorPrsenter(this);
            prsenter.CalSum();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            prsenter = new CalculatorPrsenter(this);
            prsenter.CalSub();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            prsenter = new CalculatorPrsenter(this);
            prsenter.CalMulitplic();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            prsenter = new CalculatorPrsenter(this);
            prsenter.CalDiv();
        }
    }
}
