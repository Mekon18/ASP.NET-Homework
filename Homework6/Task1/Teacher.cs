using System.Collections.Generic;

namespace Task1
{
    class Teacher : Man
    {
        public List<Student> Students;

        public Teacher(string name, uint age, string gender, uint weight) : base(name, age, gender, weight)
        {
            Students = new List<Student>();
        }

        public void SetStudents(List<Student> students)
        {
            Students = students;
        }

        public void AddStudents(params Student[] students)
        {
            Students.AddRange(students);
        }

        public void SendDownStudent(Student student)
        {
            Students.Remove(student);
        }
    }
}
