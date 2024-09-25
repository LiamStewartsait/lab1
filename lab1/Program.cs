using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*
            Person bob = new Person(0, "bob", "stien", "red", 35, false);

            bob.DisplayPersonInfo(bob);

            bob.ToString(bob);
            
            Console.ReadLine();
            */
            Person Ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person Gina = new Person(2, "Gian", "James", "Green", 18, false);
            Person Mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person Mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            Gina.DisplayPersonInfo(Gina);
            Mike.ToString(Mike);
            Ian.ChangeFavoriteColour("White");
            Ian.DisplayPersonInfo(Ian);
            Console.WriteLine("Mary's age after 10 years will be "+Mary.GetAgeInTenYears(Mary));
            Relation marygina = new Relation("Sister");
            Relation mikeian = new Relation("Brother");

            marygina.ShowRelationShip(Gina, Mary);
            mikeian.ShowRelationShip(Ian, Mike);



            List<Person> list = new List<Person>();

            list.Add(Ian);
            list.Add(Mary);
            list.Add(Gina);
            list.Add(Mike);



            //The average age of the people in the list
            int sum = 0;

            foreach (Person n in list)
            {
                sum = sum + n.getAge();
            }
            decimal ave = decimal.Divide(sum, list.Count);
            string formatedAve = ave.ToString("0.00");
            Console.WriteLine("Average age is: " + formatedAve);


            //The youngest person and the oldest person
            List<int> ages = new List<int>();
            //oh crap nobody else in this class knows for each loops
            //imma get acussed of using chatGPT
            foreach (Person n in list)
            {
                ages.Add(n.getAge());
            }

            int youngest = ages.Min();
            youngest = ages.IndexOf(youngest);
            int oldest = ages.Max();
            oldest = ages.IndexOf(oldest);

            Console.WriteLine("The youngest person is: " + list[youngest].getFirstName());
            Console.WriteLine("The oldest person is: " + list[oldest].getFirstName());



            //The first names of the people whose first names start with M
            //you didn't say full names so first names it is cause i dont
            //want to make another get meathod
            foreach (Person n in list)
            {
                if (n.getFirstName().StartsWith("M"))
                {
                    Console.WriteLine(n.getFirstName()+"'s name starts with M");

                }
            }

            //The person information of the person that likes the colour blue
            foreach (Person n in list)
            {
                if (n.getColour().Equals("Blue"))
                {
                    n.ToString(n);
                }
            }
            Console.ReadLine();
        }
    }
}
