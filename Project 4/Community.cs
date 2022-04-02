using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4 
{
    public class Community
    {

        /// <summary>
        /// Fields of the class Comunity: country name, date, new cases per 100K, and positivity rate.
        /// </summary>
        #region Fields
        private string _countyName;
        private DateTime _date;
        private int _newCasesX100;
        private int _positivityRate;
        #endregion

        /// <summary>
        /// Properties of the class Comunity:status, color, country name, date, new cases per 100K, and positivity rate.
        /// </summary>
        #region Properties
        public string CountyName
        {
            get { return _countyName; }
            set { _countyName = value.Trim(); }

        }

        public DateTime Date { get; set; }


        public double NewCasesX100 { get; set; }

        public double PositivityRate { get; set; }

        public string Status
        {
            get
            {
                double transmission = (double)NewCasesX100;
                if (transmission >= 100)
                {
                    return "High";
                }
                else if (transmission >= 50 && transmission <= 99.99)
                {
                    return "Substantial";
                }
                else if (transmission >= 10 && transmission <= 49.99)
                {
                    return "Moderate";
                }
                else if (transmission >= 0 && transmission <= 9.99)
                {
                    return "Low";
                }
                else
                {
                    return "Unknown";
                }
            }
        }

        public string Color
        {
            get
            {
                if (Status == "Low")
                {
                    return "Blue";
                }
                else if (Status == "Moderate")
                {
                    return "Yellow";
                }
                else if (Status == "Substantial")
                {
                    return "Orange";
                }
                else
                {
                    return "Red";
                }
            }

        }
        #endregion


        /// <summary>
        /// Constructors of the class Community
        /// </summary>
        #region Constructors and destructors

        //default constructor
        public Community()
        {
            CountyName = string.Empty;
            NewCasesX100 = 0;
            PositivityRate = 0;
        }


        /// <summary>
        /// overloaded constructor
        /// </summary>
        /// <param name="pCountryName"></param>
        /// <param name="pDate"></param>
        /// <param name="pNewCasesX100"></param>
        /// <param name="pPositivityRate"></param>
        //overloaded constructor
        public Community(string pCountyName, DateTime pDate, int pNewCasesX100, int pPositivityRate)

        {
            CountyName = pCountyName;
            Date = pDate;
            NewCasesX100 = pNewCasesX100;
            PositivityRate = pPositivityRate;



        }

        /// <summary>
        /// destructor of the class
        /// </summary>
        ~Community()
        {
            _countyName = null;
        }
        #endregion


        /// <summary>
        /// Methods of the class Community
        /// </summary>
        #region Methods
        public override string ToString()
        {
            string message;
            message = Status.ToString();
                //"In " + CountryName.ToUpper() + " there are " + NewCasesX100 + " with a positivity rate of " + 
               // PositivityRate + Environment.NewLine + "Submmited on: " + Date;

            return message;
        }
        #endregion
    }
}
