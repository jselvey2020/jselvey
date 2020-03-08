using System;

namespace ConsoleApp7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DatingProfile rob = new DatingProfile("Rob", "Szybilski", 29, "Male");
            rob.WriteBio("Loves D&D and Spicy Food");

            DatingProfile penny = new DatingProfile("Penny", "Newman", 34, "Female");
            penny.WriteBio("Looking for new friend with interesting hobbies.");

            rob.SendMessage("Hey Penny", "Want to grab a cup of coffee?", penny);
            penny.ReadMessage();
        }
    }
}
