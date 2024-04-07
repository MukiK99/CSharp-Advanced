using Domain.Interfaces;
using Domain.Models;

namespace Domain
{
    public class GenericPetStore<T> : IGenericPetStore<T> where T : Pet
    {
        private List<T> Db = new List<T>(); 
        public void Insert(T pet)
        {
            Db.Add(pet);
            //Console.WriteLine($"{pet.PrintInfo()} added to the store");
        }
        
        public void BuyPet(string name)
        {
            T wantedPet = Db.FirstOrDefault(pet => pet.Name == name);
            if (wantedPet != null)
            {
                Db.Remove(wantedPet);
                Console.WriteLine($"You have successfully bought {wantedPet.Name}");
            }
            else
            {
                Console.WriteLine("We are very sorry! We don't have the wanted pet at the moment.");
                return;
            }
        }

        public void PrintPets()
        {
            Console.WriteLine("These pets of your chosen type are available in the store: \n");
            foreach (T pet  in Db)
            {
                Console.WriteLine(pet.PrintInfo());
            }
        }
    }
}
