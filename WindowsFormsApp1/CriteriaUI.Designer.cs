namespace WindowsFormsApp1
{
    partial class CriteriaUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstButton = new System.Windows.Forms.Button();
            this.CriteriaDescription = new System.Windows.Forms.TextBox();
            this.UpperSecondButton = new System.Windows.Forms.Button();
            this.LowerSecondButton = new System.Windows.Forms.Button();
            this.ThirdButton = new System.Windows.Forms.Button();
            this.FailButton = new System.Windows.Forms.Button();
            this.NoSubmissionButton = new System.Windows.Forms.Button();
            this.Grade = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(109, 3);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(121, 171);
            this.FirstButton.TabIndex = 0;
            this.FirstButton.Text = "First";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CriteriaDescription
            // 
            this.CriteriaDescription.Location = new System.Drawing.Point(3, 3);
            this.CriteriaDescription.Multiline = true;
            this.CriteriaDescription.Name = "CriteriaDescription";
            this.CriteriaDescription.ReadOnly = true;
            this.CriteriaDescription.Size = new System.Drawing.Size(100, 171);
            this.CriteriaDescription.TabIndex = 1;
            this.CriteriaDescription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UpperSecondButton
            // 
            this.UpperSecondButton.Location = new System.Drawing.Point(236, 3);
            this.UpperSecondButton.Name = "UpperSecondButton";
            this.UpperSecondButton.Size = new System.Drawing.Size(121, 171);
            this.UpperSecondButton.TabIndex = 2;
            this.UpperSecondButton.Text = "Upper_Second";
            this.UpperSecondButton.UseVisualStyleBackColor = true;
            this.UpperSecondButton.Click += new System.EventHandler(this.UpperSecondButton_Click);
            // 
            // LowerSecondButton
            // 
            this.LowerSecondButton.Location = new System.Drawing.Point(363, 3);
            this.LowerSecondButton.Name = "LowerSecondButton";
            this.LowerSecondButton.Size = new System.Drawing.Size(121, 171);
            this.LowerSecondButton.TabIndex = 3;
            this.LowerSecondButton.Text = "Lower_Second";
            this.LowerSecondButton.UseVisualStyleBackColor = true;
            this.LowerSecondButton.Click += new System.EventHandler(this.LowerSecondButton_Click);
            // 
            // ThirdButton
            // 
            this.ThirdButton.Location = new System.Drawing.Point(490, 3);
            this.ThirdButton.Name = "ThirdButton";
            this.ThirdButton.Size = new System.Drawing.Size(121, 171);
            this.ThirdButton.TabIndex = 4;
            this.ThirdButton.Text = "Third";
            this.ThirdButton.UseVisualStyleBackColor = true;
            this.ThirdButton.Click += new System.EventHandler(this.ThirdButton_Click);
            // 
            // FailButton
            // 
            this.FailButton.Location = new System.Drawing.Point(617, 3);
            this.FailButton.Name = "FailButton";
            this.FailButton.Size = new System.Drawing.Size(121, 171);
            this.FailButton.TabIndex = 5;
            this.FailButton.Text = "Fail";
            this.FailButton.UseVisualStyleBackColor = true;
            this.FailButton.Click += new System.EventHandler(this.FailButton_Click);
            // 
            // NoSubmissionButton
            // 
            this.NoSubmissionButton.Location = new System.Drawing.Point(744, 3);
            this.NoSubmissionButton.Name = "NoSubmissionButton";
            this.NoSubmissionButton.Size = new System.Drawing.Size(121, 171);
            this.NoSubmissionButton.TabIndex = 6;
            this.NoSubmissionButton.Text = "No_Submission";
            this.NoSubmissionButton.UseVisualStyleBackColor = true;
            this.NoSubmissionButton.Click += new System.EventHandler(this.NoSubmissionButton_Click);
            // 
            // Grade
            // 
            this.Grade.Location = new System.Drawing.Point(895, 45);
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Size = new System.Drawing.Size(100, 20);
            this.Grade.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(895, 71);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // CriteriaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.NoSubmissionButton);
            this.Controls.Add(this.FailButton);
            this.Controls.Add(this.ThirdButton);
            this.Controls.Add(this.LowerSecondButton);
            this.Controls.Add(this.UpperSecondButton);
            this.Controls.Add(this.CriteriaDescription);
            this.Controls.Add(this.FirstButton);
            this.Name = "CriteriaUI";
            this.Size = new System.Drawing.Size(1019, 176);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.TextBox CriteriaDescription;
        private System.Windows.Forms.Button UpperSecondButton;
        private System.Windows.Forms.Button LowerSecondButton;
        private System.Windows.Forms.Button ThirdButton;
        private System.Windows.Forms.Button FailButton;
        private System.Windows.Forms.Button NoSubmissionButton;
        private System.Windows.Forms.TextBox Grade;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
