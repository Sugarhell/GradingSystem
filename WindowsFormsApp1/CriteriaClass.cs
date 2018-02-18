using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public enum CategoryGrade
    {
        first,
        upper_second,
        lower_second,
        third,
        fail,
        no_submission,
    };

    public class CriteriaClass
    {
        public int Grade { get; set; }
        private int FinalGrade { get; set; }
        public int Percentage { get; set; }
        private string Name { get ; set; }


        public CriteriaClass (int newGrade, int newPercentage, string newName)
        {
            Grade = newGrade;
            Percentage = newPercentage;
            Name = newName;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetGrade()
        {
            return Grade;
        }

        public void SetGrade(int newGrade)
        {
            Grade = newGrade;
        }

        public void SetGrade(CategoryGrade newCategory)
        {
            if (newCategory == CategoryGrade.first)
            {
                SetGrade(1);
            }
            else if (newCategory == CategoryGrade.upper_second)
            {
                SetGrade(5);
            }
            else if (newCategory == CategoryGrade.lower_second)
            {
                SetGrade(9);
            }
            else if (newCategory == CategoryGrade.third)
            {
                SetGrade(13);
            }
            else if (newCategory == CategoryGrade.fail)
            {
                SetGrade(17);
            }
            else if (newCategory == CategoryGrade.no_submission)
            {
                SetGrade(20);
            }
        }

        public CategoryGrade GetRubricGrade(int value)
        {
            if(value >= 1 && value <= 4)
            {
                return CategoryGrade.first;
            }else if(value <= 8)
            {
                return CategoryGrade.upper_second;
            }else if(value <= 13)
            {
                return CategoryGrade.lower_second;
            }else if(value <= 16)
            {
                return CategoryGrade.third;
            }else if(value <= 18)
            {
                return CategoryGrade.fail;
            }else if(value <= 20)
            {
                return CategoryGrade.no_submission;
            }

            return CategoryGrade.fail;
        }

        public int GetFinalGrade()
        {
            return Grade * (Percentage / 100);
        }


    }
}
