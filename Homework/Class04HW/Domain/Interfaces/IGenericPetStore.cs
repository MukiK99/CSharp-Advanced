using Domain.Models;

namespace Domain.Interfaces
{
    public interface IGenericPetStore<T> where T : Pet
    {
        void PrintPets();
        void BuyPet(string name);
    }
}
