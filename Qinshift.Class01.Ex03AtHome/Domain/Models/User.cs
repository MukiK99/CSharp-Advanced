namespace Domain.Models
{
    public class User
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Choice { get; set; }
        public int UserWins { get; set; }
        public int UserLoss { get; set; }
        public int AmountOfGames { get; set; }
        public User()
        {

        }

        public User(string firstName, string lastName, int userwins, int userLoss)
        {
            Firstname = firstName;
            LastName = lastName;
            UserWins = userwins;
            UserLoss = userLoss;
        }

        public int IncrementUserWins()
        {
            UserWins++;
            return UserWins;
        }
        public int IncrementUserLoss()
        {
            UserLoss++;
            return UserLoss;
        }
    }
}
