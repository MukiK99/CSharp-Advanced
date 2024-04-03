using Domain.Interfaces;

namespace Domain.Models
{
    public class Teacher : User, ITeacher
    {
        public List<string> Subjects { get; set; } = new List<string>();
        public Teacher(int id, string name, string usereName, List<string> subjects) : base(id, name, usereName)
        {
            Subjects = subjects;
        }

        public void PrintSubjects()
        {
            string subjects = string.Join(", ", Subjects.Select(subject => subject.ToString()));
            Console.WriteLine($"The subjects are:{subjects}");
        }

        public override void PrintUser()
        {
            Console.WriteLine($"The number of subjects is:{Subjects.Count}");
        }
    }
}
