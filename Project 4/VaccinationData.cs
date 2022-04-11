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
        /// This class holds the fields _countryName, _ageRange, _numberVaccinated
        /// </summary>
        string _countyName;
        string[] _ageRanges = new string[8];
        int[] _numberVaccinated = new int[8];     
        #endregion


        /// <summary>
        /// Properties of the class holds CountyName, Date, AgeRanges, NumberVaccinated, and readonly TotalVaccinated
        /// </summary>
        #region Properties
        public string CountyName
        {
            get { return _countyName; }
            set { _countyName = value.Trim(); }
        }
        public DateTime Date { get; set; }

        public string[] AgeRanges 
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
                int total = NumberVaccinated.Sum();
                return total;
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

        public VaccinationData(string pCountyName, DateTime pDate, string[] pAgeRange, int[] pNumberVaccinated)
        {
            CountyName = pCountyName;
            Date = pDate;
            AgeRanges = pAgeRange;
            NumberVaccinated = pNumberVaccinated;
            
        }

        ~VaccinationData()
        {
            _countyName = null;
            _ageRanges = null;
            _numberVaccinated = null;
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
            message = CountyName.ToUpper() + " has a total of " + TotalVaccinated + " of its population vaccinated." +
                " Submitted on " + Date.ToString("MM/dd/yyyy");


            return message;
        }
        #endregion
    }
}