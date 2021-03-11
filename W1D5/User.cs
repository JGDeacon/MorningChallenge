using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace W1D5
{

    public class User
    {
        //Setting properties section
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get;}
        public DateTime BirthDate { get; set; }
        //End of Properties Section

        //Constructor Area - Start
        //Default Constructor
        public User()
        {

        }

        //Full Constructor to create a new User
        public User(string firstName, string lastName, int IDNumber, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = IDNumber;
            BirthDate = birthDate;
        }
        //Constructor Area - End

        //User Methods Area - Start
        //Generate users full name and populate a value
        public string GetUserFullName(string firstName, string lastName)
        {
            string fullName = $"{firstName} {lastName}";
            return fullName;
        }

        //Generate age using the difference in days between DOB and today / 365.25
       
        
        
        public int GetUserAge(DateTime dateOfBirth)
        {
            TimeSpan ageSpam = DateTime.Now - dateOfBirth;
            double totalAgeInYears = ageSpam.TotalDays / 365.25;
            int numberOfYears = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return numberOfYears;
        }

        public int GetUserAgeWithClass(DateTime dateOfBirth)
        {
            CalcAgeInYears GetAge = new CalcAgeInYears();
            int ageInYears = GetAge.CalculateAgeInYears(dateOfBirth);
            return ageInYears;
            
        }
        //User Methods Area - Start

    }
}
