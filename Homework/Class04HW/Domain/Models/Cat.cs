namespace Domain.Models
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }
        public int LivesLeft { get; set; }
        public Cat(string name, int age, bool isLazy, int livesLeft)
        {
            Name = name;
            Age = age;
            IsLazy = isLazy;
            LivesLeft = livesLeft;
        }
        public override string PrintInfo()
        {
            return $"Name of the cat:{Name}  Is it lazy? {IsLazy}  Lives left:{LivesLeft}\n";
        }
    }
}
