using Domain.Interfaces;

namespace Domain.Models
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; } = new List<int>();
        public Student(int id, string name, string usereName, List<int> grades) : base(id, name, usereName)
        {
            Grades = grades;
        }
        public  override void PrintUser()
        {
            double average = Grades.Average();
            Console.WriteLine($"The average grade is: {average}");
        }

        public void PrintGrades()
        {
            string grades = string.Join(", ", Grades.Select(grade => grade.ToString()));
            Console.WriteLine($"The grades are:{grades}");
        }
    }
}
