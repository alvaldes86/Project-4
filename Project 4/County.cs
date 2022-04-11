using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    public class County
    {
        #region Fields
        /// <summary>
        /// Fields of the class County
        /// </summary>
        private string _countyName;
        private int _population;
        #endregion

        #region Properties
        /// <summary>
        /// Properties of the class County
        /// </summary>
        public string CountyName
        {
            get { return _countyName; }
            set { _countyName = value.Trim(); }
        }
        public int Population
        {
            get { return _population; }
            set { _population = value; }
        }
        #endregion

        #region Constructors and destructor
        /// <summary>
        /// Constructor and destructor of the class County
        /// </summary>
        County()
        {

        }

        County(string pCountyName, int pPopulation)
        {
            CountyName = pCountyName;
            Population = pPopulation;
        }

        ~County()
        {
            _countyName = null;
            _population = 0;
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
