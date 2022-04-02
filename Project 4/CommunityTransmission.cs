using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//developed by Alain Garcia
namespace Project_4
{
    /// <summary>
    ///The CommunityTransmission class allow the user to enter the county name, date, new cases per 100K, positivity rate
    ///and to calculate the transmission and alert level of the county
    /// </summary>
    public partial class CommunityTransmission : Form
    {
        public CommunityTransmission()
        {
            InitializeComponent();
        }

        /// <summary>
        /// populate at load time the month, day, and year listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommunityTransmission_Load(object sender, EventArgs e)
        {
            //use a while loop to generate the months on the lstMonth
            int index = 1;
            while (index <= 12)
            {
                lstMonth.Items.Add(index);
                index++;
            }

            //use a do while loop to generates the days on the lstDay
            index = 1;
            do
            {
                lstDay.Items.Add(index);
                index++;
            } while (index <= 31);

            //use for loop to generate the years on the lstYear

            for (index = 2019; index <= 2025; index++)
            {
                lstYear.Items.Add(index);
            }

        }

        /// <summary>
        /// Closes the CommunityTransmission form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// The btnSubmit_Click event method validate the user input and creates a new object to process the info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //check if txtCountry is empty
            if (txtCounty.Text.Trim() == String.Empty)
            {
                lblOutputResult.Text = "County name required";

                lblOutputResult.Text = "Country required";
                txtCounty.SelectAll();
                txtCounty.Focus();
            }
            else if (txtNewCasesX100.Text.Trim() == String.Empty)
            {
                lblOutputResult.Text = "New cases per 100 required";
                txtNewCasesX100.SelectAll();
                txtNewCasesX100.Focus();
            }

            
            else if (txtTotalVaccinated.Text.Trim() == String.Empty)
            {
                lblOutputResult.Text = "Positivity rate required";
                txtTotalVaccinated.SelectAll();
                txtTotalVaccinated.Focus();
            }
            else if (lstMonth.SelectedIndex == -1)
            {
                lblOutputResult.Text = "Please select a month";
            }
            else if (lstDay.SelectedIndex == -1)
            {
                lblOutputResult.Text = "Please select a day";
            }
            else if (lstYear.SelectedIndex == -1)
            {
                lblOutputResult.Text = "Please select a year";
            }
            else
            {
                try
                {
                    //store the selected lists 
                    int month = int.Parse(lstMonth.SelectedItem.ToString());
                    int day = int.Parse(lstDay.SelectedItem.ToString());
                    int year = int.Parse(lstYear.SelectedItem.ToString());

                    //create a new submissionDate object
                    DateTime newDate = new DateTime(year, month, day);

                    /*
                    //instantiate a new community object
                    Community community = new Community(txtCounty.Text, newDate, double.Parse(txtNewCasesX100.Text), double.Parse(txtPositivityRate.Text));

                    //display message to user
                    lblOutputResult.Text = community.ToString();
                    */
                    //instantiate new community object
                    Community newCommunity = new Community(txtCounty.Text, newDate, int.Parse(txtNewCasesX100.Text),
                        int.Parse(txtTotalVaccinated.Text));



                }
                catch (Exception ex)
                {
                    lblOutputResult.Text = ex.Message;

                    //how to add specific exceptions for invalid date, invalid cases or positivity rate

                }
            }
        }



        /// <summary>
        /// the btnClear_Click event handler method clears all the text input in the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCounty.Clear();
            txtNewCasesX100.Clear();
            txtTotalVaccinated.Clear();

            lstMonth.ClearSelected();
            lstDay.ClearSelected();
            lstYear.ClearSelected();

            lblOutputResult.ResetText();

            txtCounty.Focus();
        }
    }
}
