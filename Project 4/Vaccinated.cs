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
    /// <summary>
  /// the Vaccinated class contains the logic that allows the user to calculate what percent of the population 
  /// has been vaccinated.
  /// </summary>
    public partial class Vaccinated : Form
    {
        public Vaccinated()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this event handler should create a new instace of the Vaccination class
        ///populate the country, population and vaccinated field
        /// </summary>               
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Vaccination vaccinationInfo = new Vaccination(txtCountry.Text, int.Parse(txtPopulation.Text), int.Parse(txtTotalVaccinated.Text));

                lblOutputResult.Text = vaccinationInfo.ToString();
            }
            catch (Exception ex)
            {
                lblOutputResult.Text = ex.Message;
            }

        }

        /// <summary>
        /// this event should clear all the textBox labels
        /// </summary>       
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCountry.Clear();
            txtPopulation.Clear();
            txtTotalVaccinated.Clear();

            lblOutputResult.ResetText();

            txtCountry.Focus();
        }

        /// <summary>
        /// this event should close the app
        /// </summary>        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
