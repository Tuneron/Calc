using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        private Calculate calc;
        public Form1()
        {
            InitializeComponent();
            calc = new Calculate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (calc.GetRecordContinue())
            {
                calc.RecordNumer(1);
                labelResult.Text = calc.GetNumber().ToString();
                this.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (calc.GetRecordContinue())
            {
                calc.RecordNumer(2);
                labelResult.Text = calc.GetNumber().ToString();
                this.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (calc.GetRecordContinue())
            {
                calc.RecordNumer(3);
                labelResult.Text = calc.GetNumber().ToString();
                this.Refresh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (calc.GetRecordContinue())
            {
                calc.RecordNumer(4);
                labelResult.Text = calc.GetNumber().ToString();
                this.Refresh();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (calc.GetRecordContinue())
            {
                calc.RecordNumer(5);
                labelResult.Text = calc.GetNumber().ToString();
                this.Refresh();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (calc.GetRecordContinue())
            {
                calc.RecordNumer(6);
                labelResult.Text = calc.GetNumber().ToString();
                this.Refresh();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (calc.GetRecordContinue())
            {
                calc.RecordNumer(7);
                labelResult.Text = calc.GetNumber().ToString();
                this.Refresh();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (calc.GetRecordContinue())
            {
                calc.RecordNumer(8);
                labelResult.Text = calc.GetNumber().ToString();
                this.Refresh();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (calc.GetRecordContinue())
            {
                calc.RecordNumer(9);
                labelResult.Text = calc.GetNumber().ToString();
                this.Refresh();
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (calc.GetRecordContinue())
            {
                calc.RecordNumer(0);
                labelResult.Text = calc.GetNumber().ToString();
                this.Refresh();
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            calc.ChangeNumber();
            calc.SetOperation(1);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            calc.ChangeNumber();
            calc.SetOperation(2);
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            labelResult.Text = calc.getResult().ToString();
            this.Refresh();
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            calc.ChangeNumber();
            calc.SetOperation(3);
        }

        private void buttonShare_Click(object sender, EventArgs e)
        {
            calc.ChangeNumber();
            calc.SetOperation(4);
        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            calc.SetOperation(5);
            labelResult.Text = calc.getResult().ToString();
            this.Refresh();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            calc.ResetCalc();
            labelResult.Text = "0";
            this.Refresh();
        }
    }
}
