using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    internal class Student
    {
        public string name;
        public int mMarks;
        public int fMarks;
        public int eMarks;
        public float agg;
        public Student(string name, int mMarks, int fMarks, int eMarks)
        {
            this.name = name;
            this.mMarks = mMarks;
            this.fMarks = fMarks;
            this.eMarks = eMarks;
        }
    }
}
