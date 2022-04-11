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

        int [] lstVaccinations = new int[8];
        string [] lstAges = new string[8];
        private void lstAgeRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtVaccinations.Text.Trim() == String.Empty)
            {
                lblOutputResult.Text = "Please enter a valid vaccination number";
                lstAgeRange.ClearSelected();
                txtVaccinations.Focus();
            }
            else if(lstAgeRange.SelectedItem == null)
            {
                lblOutputResult.Text = "Please select a valid age range";
            }
            else
            {
                lstNumberOfVaccinations.Items[lstAgeRange.SelectedIndex] = txtVaccinations.Text;
                txtVaccinations.Text = String.Empty;
                txtVaccinations.Focus();
                lblOutputResult.Text = "Enter a vaccination number and select age range." + Environment.NewLine + " Click the Add button when finish adding number of vaccinations.";
            }
            
                
                
            

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtVaccinations.Text = String.Empty;

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
                    //instantiate new date object
                    DateTime newDate = new DateTime();
                    newDate = dateTimePicker1.Value;


                    //copy lstNumberOfVaccinations to array lstVaccinations 
                    for (int i = 0; i < lstVaccinations.Length; i++)
                    {
                        lstVaccinations[i] = Convert.ToInt32(lstNumberOfVaccinations.Items[i]);
                    }

                    //copy lstAgeRange to array lstAges
                    for (int i = 0; i < lstAges.Length; i++)
                    {
                        lstAges[i] = Convert.ToString(lstAgeRange.Items[i]);
                       
                    }

                    
                    VaccinationData newVaccinationData = new VaccinationData(txtCounty.Text, newDate, lstAges, lstVaccinations);

                    lblOutputResult.Text = newVaccinationData.ToString();

                    
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtVaccinations.Text = String.Empty;

            if (txtCounty.Text.Trim() == String.Empty)
            {
                lblOutputResult.Text = "County name required";
                txtCounty.SelectAll();
                txtCounty.Focus();
            }
            else if (lstAgeRange.SelectedIndex == -1)
            {
                lblOutputResult.Text = "Select a valid age range";
                lstAgeRange.Focus();
            }
            else
            {
                try
                {
                    //instantiate new date object
                    DateTime newDate = new DateTime();
                    newDate = dateTimePicker1.Value;

                    lstNumberOfVaccinations.Items[lstAgeRange.SelectedIndex] = "0";
                    txtVaccinations.Text = String.Empty;
                    txtVaccinations.Focus();
                    lblOutputResult.Text = "Please enter a new number of vaccination";
                    lstNumberOfVaccinations.Items[lstAgeRange.SelectedIndex] = txtVaccinations.Text;

                    //copy lstNumberOfVaccinations to array lstVaccinations 
                    for (int i = 0; i < lstVaccinations.Length; i++)
                    {
                        lstVaccinations[i] = Convert.ToInt32(lstNumberOfVaccinations.Items[i]);
                    }

                    //copy lstAgeRange to array lstAges
                    for (int i = 0; i < lstAges.Length; i++)
                    {
                        lstAges[i] = Convert.ToString(lstAgeRange.Items[i]);

                    }


                    VaccinationData newVaccinationData = new VaccinationData(txtCounty.Text, newDate, lstAges, lstVaccinations);

                    lblOutputResult.Text = newVaccinationData.ToString();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
