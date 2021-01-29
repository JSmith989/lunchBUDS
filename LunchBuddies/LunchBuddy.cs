using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class LunchBuddy
    {
        //fields
        public string FirstName;
        public string LastName;

        //constructors
        public LunchBuddy(string first, string last)
        {
            LastName = last;
            FirstName = first;
        }

        // methods
        public void eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is eating at {restaurant.Name}");
        }
        public void eat(string food)
        {
            
            Console.WriteLine($"{FirstName} {LastName} ordered the {food} off the menu.");
        }
        public void eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is eating at {restaurant.Name} with");
                foreach (var person in companions)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} ");
            }
        }
        public void eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is eating {food} at {restaurant.Name} with");
            foreach (var person in companions)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} ");
            }
        }

    }
}
