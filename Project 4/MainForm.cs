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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// The btnClose_Click event method closes the main form closing the app
        /// </summary> 
        /// /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// The btnCasesX100K_Click event method displays the CasePer100K form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCasesX100K_Click(object sender, EventArgs e)
        {
            CasesPer100K casesForm = new CasesPer100K();
            casesForm.ShowDialog();
        }

        /// <summary>
        /// The btnVaccinations_Click event method displays the vaccinated form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVaccinations_Click(object sender, EventArgs e)
        {
            Vaccinated vaccinatedForm = new Vaccinated();
            vaccinatedForm.ShowDialog();
        }

        /// <summary>
        /// The btnCommunityTransmission_Click event method displays the transmission form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommunityTransmission_Click(object sender, EventArgs e)
        {
            Form transmissionForm = new CommunityTransmission();
            transmissionForm.ShowDialog();
        }

        /// <summary>
        /// btnVaccinationsByAge_Click event displays the Vaccination by Age form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVaccinationsByAge_Click(object sender, EventArgs e)
        {
           
            VaccinationsByAge vaccinationsByAge = new VaccinationsByAge();
            vaccinationsByAge.ShowDialog();
           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();           
            aboutForm.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new LoginForm();            
            loginForm.ShowDialog();

            
        }

        private void menuStripLogout_Click(object sender, EventArgs e)
        {
            menuStripCOVIDData.Visible = false;
            menuStripCountyDate.Visible = false;
            menuStripLogout.Visible = false;
            menuStripLogin.Visible = true;

            MessageBox.Show("You are now logout");

        }
    }
}
