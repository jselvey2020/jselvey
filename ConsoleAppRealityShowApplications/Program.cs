using System;

namespace ConsoleAppRealityShowApplications
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseHunters hhContestant = new HouseHunters("CEO", 900000, 2, 1, 2, "Douglas", "Smith", "01/01/1980",
                "123 Amazon Dr", "Orland Park", "IL", 60462, "708-209-5411", "dsmith@aol.com");

            ParadiseIsland piContestant = new ParadiseIsland("Male", "Beth", 6, "Brian", "Smith", "01/01/1980", "456 Amazon Dr",
                "Orlan Park", "IL", 60462, "708-555-5456", "bsmith@aol.com");

            AboveDeck adContestant = new AboveDeck(5, "American", "Neelson", "Smith", "01/10/1980", "789 Amazon Dr", "Orland Park", "IL", 60462, "708-555-9654", "nsmith@aol.com");

            hhContestant.Submit();
            hhContestant.Accept();

            piContestant.Submit();
            piContestant.Accept();

            adContestant.Submit();
            adContestant.Accept();
        }
    }
}
