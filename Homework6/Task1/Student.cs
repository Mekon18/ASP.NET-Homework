using System;

namespace Task1
{
    class Student : Man
    {
        public DateTime EntranceDate { get; private set; }

        public Student(string name, uint age, string gender, uint weight, DateTime entranceDate) : base(name, age, gender, weight)
        {
            EntranceDate = entranceDate;
        }

        public void SetEntranceDate(DateTime entranceDate)
        {
            EntranceDate = entranceDate;
        }

        public void IncreaseStudyingYears()
        {
            EntranceDate.AddYears(1);
        }
    }
}
