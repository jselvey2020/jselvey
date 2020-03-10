using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppRealityShowApplications
{
    class ParadiseIsland : Application
    {
        public string gender;
        public string nameOfBoyOrGirlFriend;
        public int yearsDating;

        public ParadiseIsland(string gender, string nameOfBoyOrGirlFriend, int yearsDating,
            string firstName, string lastName, string birthday, string address, string city, string state, int zipCode, string phoneNum, string email)
            : base (firstName, lastName, birthday, address, city, state, zipCode, phoneNum, email)
        {
            this.gender = gender;
            this.nameOfBoyOrGirlFriend = nameOfBoyOrGirlFriend;
            this.yearsDating = yearsDating;
        }
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Paradise Island");
        }
    }
}
