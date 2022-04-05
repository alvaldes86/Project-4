using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    class VaccinationData
    {

        #region Fields
        /// <summary>
        /// This class holds the fields _countryName, ...
        /// </summary>
        string _countryName;

        int[] _ageRanges = new int[8];
        int[] _numberVaccinated = new int[8];

        int _totalVaccinated;

        #endregion


        /// <summary>
        /// 
        /// </summary>
        #region Properties
        public string CountryName
        {
            get { return _countryName; }
            set { _countryName = value.Trim(); }
        }
        public DateTime Date { get; set; }

        public int[] AgeRanges 
        {
            get { return _ageRanges; }
            set { _ageRanges = value; }
        }

        public int[] NumberVaccinated
        {
            get { return _numberVaccinated; }
            set { _numberVaccinated = value; }
        }

        public int TotalVaccinated
        {
            get
            {
                int counter = 0;
                foreach(int total in _numberVaccinated)
                {
                    counter=+ total;
                }

                return counter;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructors and destructor of the class
        /// </summary>
        public VaccinationData()
        {

        }

        public VaccinationData(string pCountyName, int[] pAgeRanges, int[] pNumberVaccinated)
        {
            CountryName = pCountyName;
            AgeRanges = pAgeRanges;
            NumberVaccinated = pNumberVaccinated;
        }

        ~VaccinationData()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Contains a message for the user with al the data entered
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string message;
            message = "The total number of vaccinations for all the range ages you selected is " + TotalVaccinated + ".";


            return message;
        }
        #endregion
    }
}