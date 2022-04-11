using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    public class Report
    {
        #region Fields
        /// <summary>
        /// Fields of the class Report
        /// </summary>
        private int _countyID;
        private int _numberOfCases;
        private double _positivityRate;
        private DateTime _reportDate;
        #endregion

        #region Properties
        /// <summary>
        /// Properties of the class Report
        /// </summary>
        public int CountyID
        {
            get { return _countyID; }
            set { _countyID = value; }
        }

        public int NumberOfCases
        {
            get { return _numberOfCases; }
            set { _numberOfCases = value; }
        }

        public double PositivityRate
        {
            get { return _positivityRate; }
            set { _positivityRate = value; }
        }

        public DateTime ReportDate
        {
            get { return _reportDate; }
            set { _reportDate = value; }
        }
        #endregion

        #region Constuctors and destructor
        /// <summary>
        /// Constructors and destructor of the class Report
        /// </summary>
        Report()
        {
            
        }

        Report( int pCountyID, int pNumberOfCases, double pPositivityRate, DateTime pReportDate)
        {
            CountyID = pCountyID;
            NumberOfCases = pNumberOfCases;
            PositivityRate = pPositivityRate;
            ReportDate = pReportDate;
        }

        ~Report()
        {
            _countyID = 0;
            _numberOfCases = 0;
            _positivityRate = 0;
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
