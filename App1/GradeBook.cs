using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class GradeBook
    {

        public List<float> grades = new List<float>();
        public void AddGrades(float grade)
        {
            grades.Add(grade);
        }

    }
}
