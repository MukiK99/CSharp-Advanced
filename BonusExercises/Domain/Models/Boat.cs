﻿namespace Domain.Models
{
    public class Boat : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a boat and i do not have wheels :(");
        }
        public void Sail()
        {
            Console.WriteLine("The boat is sailing");
        }
    }
}
