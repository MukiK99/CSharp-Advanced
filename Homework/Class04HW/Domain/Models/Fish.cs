namespace Domain.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }
        public Fish(string name, int age, string color, string size)
        {
            Name = name;
            Age = age;
            Color = color;
            Size = size;    
        }
        public override string PrintInfo()
        {
            return $"Name of the fish:{Name}  Color: {Color}  Size{Size}\n";

        }
    }
}
