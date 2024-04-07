namespace Domain.Models
{
    public class Dog : Pet
    {
        public bool IsGoodBoy { get; set; }
        public string FavouriteFood { get; set; }
        public Dog(string name, int age, bool goodBoy, string favouriteFood)
        {
            Name = name;
            Age = age;
            IsGoodBoy = goodBoy;
            FavouriteFood = favouriteFood;
        }

        public override string PrintInfo()
        {
            return $"Name of the dog:{Name} It is a good dog:{IsGoodBoy}  Favourite Food:{FavouriteFood}\n";
        }
    }
}
