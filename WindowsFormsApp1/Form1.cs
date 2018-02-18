using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();      
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void criteriaUI1_Load(object sender, EventArgs e)
        {

        }


        public void CreateAssignment()
        {
            CriteriaClass Criteria1 = new CriteriaClass(0, 40, "Presentation");
            CriteriaClass Criteria2 = new CriteriaClass(0, 20, "Technical");
            CriteriaClass Criteria3 = new CriteriaClass(0, 40, "Implementation");
            List<CriteriaClass> Criteria = new List<CriteriaClass>();
            Criteria.Add(Criteria1);
            Criteria.Add(Criteria2);
            Criteria.Add(Criteria3);
            Assignment GPR4100_1 = new Assignment("GPR4100.1", Criteria, 0);
            CriteriaUI CriteriaControl1 = new CriteriaUI(Criteria1);
            flowLayoutPanel1.Controls.Add(CriteriaControl1);
            CriteriaUI CriteriaControl2 = new CriteriaUI(Criteria2);
            
            flowLayoutPanel1.Controls.Add(CriteriaControl2);
            
            CriteriaUI CriteriaControl3 = new CriteriaUI(Criteria3);
            
            flowLayoutPanel1.Controls.Add(CriteriaControl3);


        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateAssignment();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
