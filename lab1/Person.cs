using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Person
    {
        private int personId { get; set;}
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string favoriteColour { get; set; }
        private int age { get; set; }
        public bool isWorking;

        public Person(int id,  string Fname, string Lname, string colour, int age, bool iswork)
        {
            this.personId = id;
            this.firstName = Fname;
            this.lastName = Lname;
            this.favoriteColour = colour;
            this.age = age;
            this.isWorking = iswork;
        }

        public void DisplayPersonInfo(Person value)
        {
            Console.Write(value.firstName + " " + value.lastName + "'s ");
            Console.Write("Person ID is " + value.personId+", their ");
            Console.Write("Favourite Colour is " + value.favoriteColour + ", they are ");
            Console.Write(value.age + " years old");
            Console.WriteLine(", and they " + (value.isWorking ? "are working" : "aren't working."));
        }
        public void ChangeFavoriteColour(string NewCoulour) { this.favoriteColour = NewCoulour; }

        public int GetAgeInTenYears(Person person) 
        {
            return person.age + 10;
        }

        public void ToString(Person value)
        {
            List<string> newlists = new List<string>();
            newlists.Add(value.personId.ToString());
            newlists.Add(value.firstName);
            newlists.Add(value.lastName);
            newlists.Add(value.favoriteColour);
            newlists.Add(value.age.ToString());
            newlists.Add(value.isWorking.ToString());
            foreach (string s in newlists) { Console.WriteLine(s); }
        }
        //i realize now that all the meathods that ask for a person as a parameter is pointless
        //-_-
        public string getFirstName()
        {
            return firstName;
        }

        public int getAge()
        { return age; }

        public string getColour() { return favoriteColour; }
    }
}
