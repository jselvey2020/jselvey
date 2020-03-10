using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppRealityShowApplications
{
    class Application
    {
        public string firstName;
        public string lastName;
        public string birthday;
        public string address;
        public string city;
        public string state;
        public int zipCode;
        public string phoneNum;
        public string email;
        public bool isSubmitted;
        public bool isAccepted;

        public Application(string firstName, string lastName, string birthday,
            string address, string city, string state, int zipCode, string phoneNum, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNum = phoneNum;
            this.email = email;
            isSubmitted = false;
            isAccepted = false;

        }

        public void Submit()
        {
            isSubmitted = true;
            Console.WriteLine("Application has been submitted");
        }

        public virtual void Accept()
        {
            isAccepted = true;
            Console.WriteLine("Application Accepted");
        }
        
        

      




    }
}
