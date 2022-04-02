using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4
{
    public partial class CasesPer100K : Form
    {
        public CasesPer100K()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //declare variables to store data of the form's textbox
                int casesPer100, population;

                //declare variable to hold the result of calculation
                double total;

                //convert textbox.text value to int and store them on the variables
                casesPer100 = int.Parse(casesPer100TextBox.Text);
                population = int.Parse(populationTextBox.Text);

                //store the calculation on the total variable
                total = (double)casesPer100 / (double)population * 100000.00;


                //assign a message with the result of the calculation to the output label 
                lblOutputResult.Text = "The number of cases per 100,000 are " + total.ToString("n2");
            }
            catch (Exception ex)
            {
                lblOutputResult.Text = ex.Message;
            }

        }


        //this event handler should close the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        //this event handler should clear out all textbox fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            casesPer100TextBox.Clear();
            populationTextBox.Clear();
            lblOutputResult.Text = string.Empty;
        }
    }
}
