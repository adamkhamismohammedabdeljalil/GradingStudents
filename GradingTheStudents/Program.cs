namespace GradingTheStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "Saka", Grade = 9 });
            students.Add(new Student { Name = "Martinelli", Grade = 9.5 });
            students.Add(new Student { Name = "Ramsdale", Grade = 9 });
            students.Add(new Student { Name = "Patey", Grade = 8.5 });
            students.Add(new Student { Name = "Xhaka", Grade = 8.5 });
            students.Add(new Student { Name = "Odegaard", Grade = 10 });
            students.Add(new Student { Name = "G.Jesus", Grade = 9 });
            students.Add(new Student { Name = "Saliba", Grade = 9 });
            students.Add(new Student { Name = "G.Magaleash", Grade = 9 });
            students.Add(new Student { Name = "Zinchenko", Grade = 8});
            double sumOfGrades = 0;
            double studentsAverageGrade = 0;

            foreach (Student student in students) {
                sumOfGrades += student.Grade;
                studentsAverageGrade = sumOfGrades / students.Count();
            }
            Console.WriteLine($"The average score is :{studentsAverageGrade}");
            //finding the student with the highest grade
            double maxGrade = 0;
            Student studentWithHighestGrade = null;
            foreach (Student student in students) { 
                if(student.Grade > maxGrade)
                {
                    maxGrade= student.Grade;
                    studentWithHighestGrade=student;
                    
                }
            }

            Console.WriteLine($"Student : {studentWithHighestGrade.Name} scored the highest grade ,{maxGrade}.");
        }
    }
}