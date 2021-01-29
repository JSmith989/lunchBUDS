using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurant
    {
        public string Name;

        private List<string> listOfRestaurants = new List<string>
       {
           "Red Pony",
           "Pinewood",
           "Lipstick Lounge",
           "Catbird Seat",
           "City House",
       };
        public Restaurant()
        {
            var random = new Random();
            int index = random.Next(listOfRestaurants.Count);
            Name = listOfRestaurants[index];
        }



    }
}
