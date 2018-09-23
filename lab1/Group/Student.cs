using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group
{
    public class Student
    {
        private readonly string name;

        private int[] notes;

        public Student(string name)
        {
            this.name = name;
        }
    
        public Student(string name, int[] notes)
        {
            this.name = name;

            this.notes = notes;
        }

        public double AverageScore()
        {
            int allNotes = 0; 

            for (int i = 0; i < notes.Length; i++)
            {
                allNotes += notes[i];
            }

            return allNotes / notes.Length;
        }
    }
}
