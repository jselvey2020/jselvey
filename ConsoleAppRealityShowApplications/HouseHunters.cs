using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppRealityShowApplications
{
    class HouseHunters : Application
    {
        public string jobTitle;
        public int currentAnnualIncome;
        public int whenBuying;
        public int bedrooms;
        public int bathrooms;
       

        public HouseHunters(string jobTitle, int currentAnnualIncome, int whenBuying, int bedrooms,
            int bathrooms, string firstName, string lastName, string birthday, string address, string city, string state, int zipCode,
            string phoneNum, string email) : base(firstName, lastName, birthday, address, city, state, zipCode, phoneNum, email) 
        {
            this.jobTitle = jobTitle;
            this.currentAnnualIncome = currentAnnualIncome;
            this.whenBuying = whenBuying;
            this.bedrooms = bedrooms;
            this.bathrooms = bathrooms;
        }
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Dream House Hunters ");
            
        }





    }
}
