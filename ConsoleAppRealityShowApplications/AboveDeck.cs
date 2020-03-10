using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppRealityShowApplications
{
    class AboveDeck : Application
    {
        public int yearsExperience;
        public string nationality;

        public AboveDeck(int yearsExperience, string nationality,
            string firstName, string lastName, string birthday, string address, string city, string state, int zipCode,
            string phoneNum, string email) : base(firstName, lastName, birthday, address, city, state, zipCode, phoneNum, email)
        {
            this.yearsExperience = yearsExperience;
            this.nationality = nationality;

        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Above Deck");
        }
    }
}
