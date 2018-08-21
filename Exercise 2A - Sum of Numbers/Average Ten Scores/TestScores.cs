using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Ten_Scores
{
    class TestScores
    {
        public TestScores()
        {
            grades = new List<float>();
        }
    
        public void addGrade(int grade)
        {
            grades.Add(grade);
        }

        List<float> grades;
    }
}
