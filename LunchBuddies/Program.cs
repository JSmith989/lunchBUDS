using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var lunchBud1 = new LunchBuddy("Jordan", "Smith");
            lunchBud1.eat();
            lunchBud1.eat("crab legs");

            lunchBud1.eat(new List<LunchBuddy>
            {
                new LunchBuddy("Holly", "Smith"),
                new LunchBuddy("Oliver", "Smith")

            });

            lunchBud1.eat("super salad", new List<LunchBuddy>
            {
                new LunchBuddy("Holly", "Smith"),
                new LunchBuddy("Oliver", "Smith")

            });

        }
    }
}
