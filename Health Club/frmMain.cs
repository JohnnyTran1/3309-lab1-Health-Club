using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Club
{
    public partial class frmMain : Form
    {

        private double selected;
        private const double yogaMonth = 10;
        private const double karateMonth = 30;
        private const double trainerMonth = 50;

        public frmMain()
        {
            InitializeComponent();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMonths.Clear();
            radAdult.Checked = false;
            radChild.Checked = false;
            radSenior.Checked = false;
            radStudent.Checked = false;
            chkKarate.Checked = false;
            chkTrainer.Checked = false;
            chkYoga.Checked = false;
            lblMonthlyFee.Text = "";
            lblTotalFee.Text = "";
            lblTypeOFMemberShipError.Text = "";
            lblEnterMonthsError.Text = "";

        }

        private void gboTypeOfMember_Enter(object sender, EventArgs e)
        {
        }

        private void radAdult_CheckedChanged(object sender, EventArgs e)
        {
            if (radAdult.Checked)
                selected = 40;
        }

        private void radChild_CheckedChanged(object sender, EventArgs e)
        {
            if (radChild.Checked)
                selected = 20;
        }

        private void radStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (radStudent.Checked)
                selected = 25;
        }

        private void radSenior_CheckedChanged(object sender, EventArgs e)
        {
            if (radSenior.Checked)
                selected = 30;
        }

        private void chkYoga_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkKarate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTrainer_CheckedChanged(object sender, EventArgs e)
        {

        }
        private double CalculateAdditionalCost()
        {
            double totalCost = 0;

            if (chkYoga.Checked)
                totalCost += yogaMonth;

            if (chkKarate.Checked)
                totalCost += karateMonth;

            if (chkTrainer.Checked)
                totalCost += trainerMonth;

            return totalCost;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double months;
            if (!radAdult.Checked && !radChild.Checked && !radSenior.Checked && !radStudent.Checked)
            {
                // Display error message if none of the radio buttons are checked
                lblTypeOFMemberShipError.Text = "Please select a membership type.";
                lblTypeOFMemberShipError.Visible = true;
                return;
            }

            // Try parsing txtMonths.Text
            if (!double.TryParse(txtMonths.Text, out months) || months <= 0) 
            {
                lblEnterMonthsError.Text = "Please enter postive a number for months.";
                lblEnterMonthsError.Visible = true;
                return;
            }

            double totalCostOfOptions = CalculateAdditionalCost();
            double monthyFee = selected + totalCostOfOptions;
            double total = Math.Round(monthyFee * months,2);

            lblMonthlyFee.Text = "$" + monthyFee.ToString();
            lblTotalFee.Text =  "$" + total.ToString();

            lblMonthlyFee.Visible = true;
            lblTotalFee.Visible = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
