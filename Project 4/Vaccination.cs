using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    class Vaccination
    {
        #region Properties and Fields
        /// <summary>
        /// Class Item will hold 
        /// </summary>

        //fields
        private string _country;
        private int _population;
        private int _vaccinated;




        //properties
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        public int Population
        {
            get { return _population; }
            set { _population = value; }
        }
        public int Vaccinated
        {
            get { return _vaccinated; }
            set { _vaccinated = value; }
        }
        public double VaccinatedPercent
        {
            get
            {
                return ((double)Vaccinated / (double)Population) * 100;
            }
        }

        #endregion

        #region Constructors and destructor of the class
        /// <summary>
        /// Default contrustors 
        /// </summary>

        public Vaccination()
        {
            Country = string.Empty;
            Population = 0;
            Vaccinated = 0;
        }

        public Vaccination(string pCountry, int pPopulation, int pVaccinated)
        {
            Country = pCountry;
            Population = pPopulation;
            Vaccinated = pVaccinated;

        }

        /// <summary>
        /// Destructor
        /// </summary>
        /// 
        ~Vaccination()
        {
            _country = null;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Methods 
        /// </summary>

        //this method will hold a message for the user
        public override string ToString()
        {
            string message;
            message = "The " + Country.ToUpper() + " has a population of " + Population + ". Currently there is a total of " + Vaccinated + " people vaccinated in the " + Country +
                ".The total number of people fully vaccinated is " + VaccinatedPercent.ToString("n0") + "%";
            return message;
        }
        #endregion
    }
}
