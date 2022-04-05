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
    public partial class VaccinationsByAge : Form
    {
        public VaccinationsByAge()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtCounty.Text.Trim() == String.Empty)
            {
                lblOutputResult.Text = "County name required";
                txtCounty.SelectAll();
                txtCounty.Focus();
            }
            else if(lstAgeRange.SelectedIndex == -1)
            {
                lblOutputResult.Text = "Select a valid age range";              
                lstAgeRange.Focus();
            }
            else
            {
                try
                {
                    DateTime newDate = new DateTime();
                    newDate = dateTimePicker1.Value;                   
                    lblOutputResult.Text = newDate.ToString("MM/dd/yyyy");

                    VaccinationData newVaccinationData = new VaccinationData();


                    if(lstAgeRange.SelectedIndex != -1)
                    {
                        /*
                        newVaccinationData.NumberVaccinated[0] = int.Parse(txtVaccinations.Text);
                        lstNumberOfVaccinations.Items[0] = txtVaccinations.Text;
                        */

                        lstNumberOfVaccinations.Items[lstAgeRange.SelectedIndex] = int.Parse(txtVaccinations.Text);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);    
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstAgeRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAgeRange.SelectedIndex != -1)
            {
                /*
                newVaccinationData.NumberVaccinated[0] = int.Parse(txtVaccinations.Text);
                lstNumberOfVaccinations.Items[0] = txtVaccinations.Text;
                */

                lstNumberOfVaccinations.Items[lstAgeRange.SelectedIndex] = int.Parse(txtVaccinations.Text);
            }
        }
    }
}
