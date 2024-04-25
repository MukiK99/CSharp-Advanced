namespace Exercise.Domain.Models
{
    public class Dog : BaseEntity
    {
      
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public Dog(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }
        public override string Info()
        {
            return $"{Name} {Age}, {Color} color";
        }
    }
}
