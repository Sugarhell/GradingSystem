using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CriteriaUI : UserControl
    {
        CriteriaClass newCriteria;
        Button pressedButton;
        public CriteriaUI(CriteriaClass criteria)
        {
            InitializeComponent();
            newCriteria = criteria;
            CriteriaDescription.Text = newCriteria.GetName();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckButton(FirstButton);
        }

        public void CheckButton(Button newButton)
        {
            if(newButton == pressedButton)
            {
                return;
            }
            ResetButtonColors();
            pressedButton = newButton;
            newButton.BackColor = Color.Green;

            if(newButton == FirstButton)
            {
                newCriteria.SetGrade(CategoryGrade.first);
            }else if(newButton == UpperSecondButton)
            {
                newCriteria.SetGrade(CategoryGrade.upper_second);
            }
            else if(newButton == LowerSecondButton)
            {
                newCriteria.SetGrade(CategoryGrade.lower_second);
            }
            else if (newButton == ThirdButton)
            {
                newCriteria.SetGrade(CategoryGrade.third);
            }
            else if(newButton == FailButton)
            {
                newCriteria.SetGrade(CategoryGrade.fail);
            }
            else if(newButton == NoSubmissionButton)
            {
                newCriteria.SetGrade(CategoryGrade.no_submission);
            }

            Grade.Text = newCriteria.GetGrade().ToString();

        }

        

        private void ResetButtonColors()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.White;
                }
            }
        }

            
        private void UpperSecondButton_Click(object sender, EventArgs e)
        {
            CheckButton(UpperSecondButton);
        }

        private void LowerSecondButton_Click(object sender, EventArgs e)
        {
            CheckButton(LowerSecondButton);
        }

        private void ThirdButton_Click(object sender, EventArgs e)
        {
            CheckButton(ThirdButton);
        }

        private void FailButton_Click(object sender, EventArgs e)
        {
            CheckButton(FailButton);
        }

        private void NoSubmissionButton_Click(object sender, EventArgs e)
        {
            CheckButton(NoSubmissionButton);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            newCriteria.SetGrade((int)numericUpDown1.Value);
            CheckButton(newCriteria.GetRubricGrade((int)numericUpDown1.Value));
            Grade.Text = newCriteria.GetGrade().ToString();

        }

        public void CheckButton(CategoryGrade newCategory)
        {
            ResetButtonColors();
            if(newCategory == CategoryGrade.first)
            {
                FirstButton.BackColor = Color.Green;
            }else if(newCategory == CategoryGrade.upper_second)
            {
                UpperSecondButton.BackColor = Color.Green;
            }else if(newCategory == CategoryGrade.lower_second)
            {
                LowerSecondButton.BackColor = Color.Green;
            }else if(newCategory == CategoryGrade.third)
            {
                ThirdButton.BackColor = Color.Green;
            }else if(newCategory == CategoryGrade.fail)
            {
                FailButton.BackColor = Color.Green;
            }else if(newCategory == CategoryGrade.no_submission)
            {
                NoSubmissionButton.BackColor = Color.Green;
            }
        }
    }
}
