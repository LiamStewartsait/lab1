using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Relation
    {
        string RelationshipType;

        public Relation(string relationshipType)
        {
            if (relationshipType == "Sister" || relationshipType == "Brother" || relationshipType == "Mother" || relationshipType == "Father")
            {
                RelationshipType = relationshipType;
            }
        }
        
        public void ShowRelationShip(Person person1, Person person2)
        {
            Console.WriteLine("Relationship between " + person1.getFirstName() + " and " + person2.getFirstName() + " is: " + this.RelationshipType + "hood");
        }
        
    }
}
