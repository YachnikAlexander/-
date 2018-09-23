using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group
{
    public class Group
    {
        private readonly int numberOfGroup;
        public Student[] students;

        public Group(int number)
        {
            numberOfGroup = number;
        }

        public Group(int number, Student[] students)
        {
            numberOfGroup = number;

            this.students = students;
        }

        public double AverageScore()
        {
            double averageScore = 0;

            for (int i = 0; i < students.Length; i++)
            {
                averageScore += students[i].AverageScore();
            }

            return averageScore / students.Length;
        }
    }
}
