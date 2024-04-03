namespace Domain.Models
{
    public class Computer
    {
        public string Name { get; set; }
        public string Choice { get; set; }
        public int ComputerWins { get; set; }

        public Computer() { }   
        public Computer(string name, int computerwins)
        {
            Name = name;
            ComputerWins = computerwins;
        }
        public int IncrementComputerWins()
        {
            ComputerWins++;
            return ComputerWins;
        }
    }
}
