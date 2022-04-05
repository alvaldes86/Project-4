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

        int[] ageRanges = new int[8];
        int[] numberVaccinated = new int[8];

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
            get { return ageRanges; }
            set { ageRanges = value; }
        }

        public int[] NumberVaccinated
        {
            get { return numberVaccinated; }
            set { numberVaccinated = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructors and destructor of the class
        /// </summary>
        public VaccinationData()
        {

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
            string message = "";


            return message;
        }
        #endregion
    }
}