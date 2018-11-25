namespace NaikCourseCapstone
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CrsTaken = new System.Windows.Forms.MaskedTextBox();
            this.StdName = new System.Windows.Forms.MaskedTextBox();
            this.CourseTaken = new System.Windows.Forms.MaskedTextBox();
            this.StudentName = new System.Windows.Forms.MaskedTextBox();
            this.StartDate = new System.Windows.Forms.MaskedTextBox();
            this.CourseNo = new System.Windows.Forms.MaskedTextBox();
            this.ClassType = new System.Windows.Forms.MaskedTextBox();
            this.ClassDate = new System.Windows.Forms.DateTimePicker();
            this.CrsNo = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.radioOnline = new System.Windows.Forms.RadioButton();
            this.radioHybrid = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Of Courses Taken";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Class Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "No. Of Courses Taken";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Student Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Class Start Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Course Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(401, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Class Type";
            // 
            // CrsTaken
            // 
            this.CrsTaken.Location = new System.Drawing.Point(176, 31);
            this.CrsTaken.Name = "CrsTaken";
            this.CrsTaken.Size = new System.Drawing.Size(100, 20);
            this.CrsTaken.TabIndex = 0;
            this.CrsTaken.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CrsTaken_MaskInputRejected);
            // 
            // StdName
            // 
            this.StdName.Location = new System.Drawing.Point(176, 67);
            this.StdName.Name = "StdName";
            this.StdName.Size = new System.Drawing.Size(100, 20);
            this.StdName.TabIndex = 1;
            // 
            // CourseTaken
            // 
            this.CourseTaken.Location = new System.Drawing.Point(520, 31);
            this.CourseTaken.Name = "CourseTaken";
            this.CourseTaken.ReadOnly = true;
            this.CourseTaken.Size = new System.Drawing.Size(100, 20);
            this.CourseTaken.TabIndex = 12;
            this.CourseTaken.TabStop = false;
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(520, 67);
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Size = new System.Drawing.Size(100, 20);
            this.StudentName.TabIndex = 13;
            this.StudentName.TabStop = false;
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(520, 98);
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Size = new System.Drawing.Size(59, 20);
            this.StartDate.TabIndex = 14;
            this.StartDate.TabStop = false;
            // 
            // CourseNo
            // 
            this.CourseNo.Location = new System.Drawing.Point(520, 129);
            this.CourseNo.Name = "CourseNo";
            this.CourseNo.ReadOnly = true;
            this.CourseNo.Size = new System.Drawing.Size(100, 20);
            this.CourseNo.TabIndex = 15;
            this.CourseNo.TabStop = false;
            // 
            // ClassType
            // 
            this.ClassType.Location = new System.Drawing.Point(520, 168);
            this.ClassType.Name = "ClassType";
            this.ClassType.ReadOnly = true;
            this.ClassType.Size = new System.Drawing.Size(100, 20);
            this.ClassType.TabIndex = 16;
            this.ClassType.TabStop = false;
            // 
            // ClassDate
            // 
            this.ClassDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ClassDate.Location = new System.Drawing.Point(176, 99);
            this.ClassDate.MaxDate = new System.DateTime(2019, 1, 31, 0, 0, 0, 0);
            this.ClassDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.ClassDate.Name = "ClassDate";
            this.ClassDate.Size = new System.Drawing.Size(200, 20);
            this.ClassDate.TabIndex = 2;
            this.ClassDate.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // CrsNo
            // 
            this.CrsNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CrsNo.FormattingEnabled = true;
            this.CrsNo.Location = new System.Drawing.Point(176, 128);
            this.CrsNo.Name = "CrsNo";
            this.CrsNo.Size = new System.Drawing.Size(121, 21);
            this.CrsNo.TabIndex = 3;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(77, 209);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(143, 23);
            this.btnSet.TabIndex = 6;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(424, 209);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(143, 23);
            this.btnGet.TabIndex = 7;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // butExit
            // 
            this.butExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butExit.Location = new System.Drawing.Point(205, 259);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(229, 23);
            this.butExit.TabIndex = 8;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // radioOnline
            // 
            this.radioOnline.AutoSize = true;
            this.radioOnline.Location = new System.Drawing.Point(230, 167);
            this.radioOnline.Margin = new System.Windows.Forms.Padding(2);
            this.radioOnline.Name = "radioOnline";
            this.radioOnline.Size = new System.Drawing.Size(55, 17);
            this.radioOnline.TabIndex = 18;
            this.radioOnline.TabStop = true;
            this.radioOnline.Text = "Online";
            this.radioOnline.UseVisualStyleBackColor = true;
            // 
            // radioHybrid
            // 
            this.radioHybrid.AutoSize = true;
            this.radioHybrid.Checked = true;
            this.radioHybrid.Location = new System.Drawing.Point(135, 168);
            this.radioHybrid.Margin = new System.Windows.Forms.Padding(2);
            this.radioHybrid.Name = "radioHybrid";
            this.radioHybrid.Size = new System.Drawing.Size(55, 17);
            this.radioHybrid.TabIndex = 17;
            this.radioHybrid.TabStop = true;
            this.radioHybrid.Text = "Hybrid";
            this.radioHybrid.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioOnline);
            this.Controls.Add(this.radioHybrid);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.CrsNo);
            this.Controls.Add(this.ClassDate);
            this.Controls.Add(this.ClassType);
            this.Controls.Add(this.CourseNo);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.CourseTaken);
            this.Controls.Add(this.StdName);
            this.Controls.Add(this.CrsTaken);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Capstone";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox CrsTaken;
        private System.Windows.Forms.MaskedTextBox StdName;
        private System.Windows.Forms.MaskedTextBox CourseTaken;
        private System.Windows.Forms.MaskedTextBox StudentName;
        private System.Windows.Forms.MaskedTextBox StartDate;
        private System.Windows.Forms.MaskedTextBox CourseNo;
        private System.Windows.Forms.MaskedTextBox ClassType;
        private System.Windows.Forms.DateTimePicker ClassDate;
        private System.Windows.Forms.ComboBox CrsNo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.RadioButton radioOnline;
        private System.Windows.Forms.RadioButton radioHybrid;
    }
}

