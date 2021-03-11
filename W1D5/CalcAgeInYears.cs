using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D5
{
    class CalcAgeInYears
    {
        public int CalculateAgeInYears(DateTime dateOfBirth)
        {
            TimeSpan ageSpam = DateTime.Now - dateOfBirth;
            double totalAgeInYears = ageSpam.TotalDays / 365.25;
            int numberOfYears = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return numberOfYears;
        }
    }
}
