using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    public class Assignment
    {
        private string Name;
        private List<CriteriaClass> Criteria { get; set; }
        private int Grade { get; set; }

        public Assignment(string newName, List<CriteriaClass> newCriteria, int newGrade )
        {
            Name = newName;
            Criteria = newCriteria;
            Grade = newGrade;
        }

        public void SetFinalGrade(int value)
        {
            Grade = value;
        }
    }

}
