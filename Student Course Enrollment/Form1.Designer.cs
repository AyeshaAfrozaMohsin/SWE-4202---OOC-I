namespace Student_Course_Enrollment
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
            this.label15 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.EnrollStudentCBox = new System.Windows.Forms.ComboBox();
            this.EnrollCourseCBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ViewStudentCBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.EnterTypeProfessionalRadioButton = new System.Windows.Forms.RadioButton();
            this.EnterTypeStudentRadioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.EnterLevelAdvancedRadioButton = new System.Windows.Forms.RadioButton();
            this.EnterLevelIntermediateRadioButton = new System.Windows.Forms.RadioButton();
            this.EnterLevelBeginnerRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.EnterParticipantRegNoBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EnterParticipantEmailBox = new System.Windows.Forms.TextBox();
            this.EnterParticipantContactNoBox = new System.Windows.Forms.TextBox();
            this.EnterParticipantNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EnterCourseLevelAdvancedRadioButton = new System.Windows.Forms.RadioButton();
            this.EnterCourseLevelIntermediateRadioButton = new System.Windows.Forms.RadioButton();
            this.EnterCourseLevelBeginnerRadioButton = new System.Windows.Forms.RadioButton();
            this.EnterCourseFeeBox = new System.Windows.Forms.TextBox();
            this.EnterCourseTitleBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ShowCourseFeeBox = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "Select Student";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(504, 116);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(146, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Pay and Enroll";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.PayAndEnroll);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(306, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Show";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ShowEnrolledCourses);
            // 
            // EnrollStudentCBox
            // 
            this.EnrollStudentCBox.FormattingEnabled = true;
            this.EnrollStudentCBox.Location = new System.Drawing.Point(146, 50);
            this.EnrollStudentCBox.Name = "EnrollStudentCBox";
            this.EnrollStudentCBox.Size = new System.Drawing.Size(203, 24);
            this.EnrollStudentCBox.TabIndex = 24;
            this.EnrollStudentCBox.SelectedIndexChanged += new System.EventHandler(this.EnrollStudentCBox_SelectedIndexChanged);
            // 
            // EnrollCourseCBox
            // 
            this.EnrollCourseCBox.FormattingEnabled = true;
            this.EnrollCourseCBox.Location = new System.Drawing.Point(144, 94);
            this.EnrollCourseCBox.Name = "EnrollCourseCBox";
            this.EnrollCourseCBox.Size = new System.Drawing.Size(205, 24);
            this.EnrollCourseCBox.TabIndex = 25;
            this.EnrollCourseCBox.SelectedIndexChanged += new System.EventHandler(this.EnrollCourseCBox_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // ViewStudentCBox
            // 
            this.ViewStudentCBox.FormattingEnabled = true;
            this.ViewStudentCBox.Location = new System.Drawing.Point(124, 39);
            this.ViewStudentCBox.Name = "ViewStudentCBox";
            this.ViewStudentCBox.Size = new System.Drawing.Size(176, 24);
            this.ViewStudentCBox.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.EnterParticipantRegNoBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.EnterParticipantEmailBox);
            this.groupBox1.Controls.Add(this.EnterParticipantContactNoBox);
            this.groupBox1.Controls.Add(this.EnterParticipantNameBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 264);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Participant Info";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.EnterTypeProfessionalRadioButton);
            this.panel6.Controls.Add(this.EnterTypeStudentRadioButton);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(260, 34);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(145, 108);
            this.panel6.TabIndex = 21;
            // 
            // EnterTypeProfessionalRadioButton
            // 
            this.EnterTypeProfessionalRadioButton.AutoSize = true;
            this.EnterTypeProfessionalRadioButton.Location = new System.Drawing.Point(22, 58);
            this.EnterTypeProfessionalRadioButton.Name = "EnterTypeProfessionalRadioButton";
            this.EnterTypeProfessionalRadioButton.Size = new System.Drawing.Size(103, 20);
            this.EnterTypeProfessionalRadioButton.TabIndex = 16;
            this.EnterTypeProfessionalRadioButton.TabStop = true;
            this.EnterTypeProfessionalRadioButton.Text = "Professional";
            this.EnterTypeProfessionalRadioButton.UseVisualStyleBackColor = true;
            // 
            // EnterTypeStudentRadioButton
            // 
            this.EnterTypeStudentRadioButton.AutoSize = true;
            this.EnterTypeStudentRadioButton.Location = new System.Drawing.Point(22, 32);
            this.EnterTypeStudentRadioButton.Name = "EnterTypeStudentRadioButton";
            this.EnterTypeStudentRadioButton.Size = new System.Drawing.Size(73, 20);
            this.EnterTypeStudentRadioButton.TabIndex = 15;
            this.EnterTypeStudentRadioButton.TabStop = true;
            this.EnterTypeStudentRadioButton.Text = "Student";
            this.EnterTypeStudentRadioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Type";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.EnterLevelAdvancedRadioButton);
            this.panel5.Controls.Add(this.EnterLevelIntermediateRadioButton);
            this.panel5.Controls.Add(this.EnterLevelBeginnerRadioButton);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(260, 142);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(145, 135);
            this.panel5.TabIndex = 20;
            // 
            // EnterLevelAdvancedRadioButton
            // 
            this.EnterLevelAdvancedRadioButton.AutoSize = true;
            this.EnterLevelAdvancedRadioButton.Location = new System.Drawing.Point(23, 93);
            this.EnterLevelAdvancedRadioButton.Name = "EnterLevelAdvancedRadioButton";
            this.EnterLevelAdvancedRadioButton.Size = new System.Drawing.Size(90, 20);
            this.EnterLevelAdvancedRadioButton.TabIndex = 19;
            this.EnterLevelAdvancedRadioButton.TabStop = true;
            this.EnterLevelAdvancedRadioButton.Text = "Advanced";
            this.EnterLevelAdvancedRadioButton.UseVisualStyleBackColor = true;
            // 
            // EnterLevelIntermediateRadioButton
            // 
            this.EnterLevelIntermediateRadioButton.AutoSize = true;
            this.EnterLevelIntermediateRadioButton.Location = new System.Drawing.Point(23, 63);
            this.EnterLevelIntermediateRadioButton.Name = "EnterLevelIntermediateRadioButton";
            this.EnterLevelIntermediateRadioButton.Size = new System.Drawing.Size(102, 20);
            this.EnterLevelIntermediateRadioButton.TabIndex = 18;
            this.EnterLevelIntermediateRadioButton.TabStop = true;
            this.EnterLevelIntermediateRadioButton.Text = "Intermediate";
            this.EnterLevelIntermediateRadioButton.UseVisualStyleBackColor = true;
            // 
            // EnterLevelBeginnerRadioButton
            // 
            this.EnterLevelBeginnerRadioButton.AutoSize = true;
            this.EnterLevelBeginnerRadioButton.Location = new System.Drawing.Point(23, 31);
            this.EnterLevelBeginnerRadioButton.Name = "EnterLevelBeginnerRadioButton";
            this.EnterLevelBeginnerRadioButton.Size = new System.Drawing.Size(82, 20);
            this.EnterLevelBeginnerRadioButton.TabIndex = 17;
            this.EnterLevelBeginnerRadioButton.TabStop = true;
            this.EnterLevelBeginnerRadioButton.Text = "Beginner";
            this.EnterLevelBeginnerRadioButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Level";
            // 
            // EnterParticipantRegNoBox
            // 
            this.EnterParticipantRegNoBox.Location = new System.Drawing.Point(72, 93);
            this.EnterParticipantRegNoBox.Name = "EnterParticipantRegNoBox";
            this.EnterParticipantRegNoBox.Size = new System.Drawing.Size(174, 22);
            this.EnterParticipantRegNoBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddParticipant);
            // 
            // EnterParticipantEmailBox
            // 
            this.EnterParticipantEmailBox.Location = new System.Drawing.Point(57, 161);
            this.EnterParticipantEmailBox.Name = "EnterParticipantEmailBox";
            this.EnterParticipantEmailBox.Size = new System.Drawing.Size(189, 22);
            this.EnterParticipantEmailBox.TabIndex = 10;
            // 
            // EnterParticipantContactNoBox
            // 
            this.EnterParticipantContactNoBox.Location = new System.Drawing.Point(86, 127);
            this.EnterParticipantContactNoBox.Name = "EnterParticipantContactNoBox";
            this.EnterParticipantContactNoBox.Size = new System.Drawing.Size(160, 22);
            this.EnterParticipantContactNoBox.TabIndex = 9;
            // 
            // EnterParticipantNameBox
            // 
            this.EnterParticipantNameBox.Location = new System.Drawing.Point(57, 58);
            this.EnterParticipantNameBox.Name = "EnterParticipantNameBox";
            this.EnterParticipantNameBox.Size = new System.Drawing.Size(189, 22);
            this.EnterParticipantNameBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reg No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.EnterCourseLevelAdvancedRadioButton);
            this.groupBox2.Controls.Add(this.EnterCourseLevelIntermediateRadioButton);
            this.groupBox2.Controls.Add(this.EnterCourseLevelBeginnerRadioButton);
            this.groupBox2.Controls.Add(this.EnterCourseFeeBox);
            this.groupBox2.Controls.Add(this.EnterCourseTitleBox);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(22, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 176);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Course Info";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // EnterCourseLevelAdvancedRadioButton
            // 
            this.EnterCourseLevelAdvancedRadioButton.AutoSize = true;
            this.EnterCourseLevelAdvancedRadioButton.Location = new System.Drawing.Point(68, 133);
            this.EnterCourseLevelAdvancedRadioButton.Name = "EnterCourseLevelAdvancedRadioButton";
            this.EnterCourseLevelAdvancedRadioButton.Size = new System.Drawing.Size(90, 20);
            this.EnterCourseLevelAdvancedRadioButton.TabIndex = 22;
            this.EnterCourseLevelAdvancedRadioButton.TabStop = true;
            this.EnterCourseLevelAdvancedRadioButton.Text = "Advanced";
            this.EnterCourseLevelAdvancedRadioButton.UseVisualStyleBackColor = true;
            // 
            // EnterCourseLevelIntermediateRadioButton
            // 
            this.EnterCourseLevelIntermediateRadioButton.AutoSize = true;
            this.EnterCourseLevelIntermediateRadioButton.Location = new System.Drawing.Point(68, 103);
            this.EnterCourseLevelIntermediateRadioButton.Name = "EnterCourseLevelIntermediateRadioButton";
            this.EnterCourseLevelIntermediateRadioButton.Size = new System.Drawing.Size(102, 20);
            this.EnterCourseLevelIntermediateRadioButton.TabIndex = 21;
            this.EnterCourseLevelIntermediateRadioButton.TabStop = true;
            this.EnterCourseLevelIntermediateRadioButton.Text = "Intermediate";
            this.EnterCourseLevelIntermediateRadioButton.UseVisualStyleBackColor = true;
            // 
            // EnterCourseLevelBeginnerRadioButton
            // 
            this.EnterCourseLevelBeginnerRadioButton.AutoSize = true;
            this.EnterCourseLevelBeginnerRadioButton.Location = new System.Drawing.Point(68, 71);
            this.EnterCourseLevelBeginnerRadioButton.Name = "EnterCourseLevelBeginnerRadioButton";
            this.EnterCourseLevelBeginnerRadioButton.Size = new System.Drawing.Size(82, 20);
            this.EnterCourseLevelBeginnerRadioButton.TabIndex = 20;
            this.EnterCourseLevelBeginnerRadioButton.TabStop = true;
            this.EnterCourseLevelBeginnerRadioButton.Text = "Beginner";
            this.EnterCourseLevelBeginnerRadioButton.UseVisualStyleBackColor = true;
            // 
            // EnterCourseFeeBox
            // 
            this.EnterCourseFeeBox.Location = new System.Drawing.Point(186, 93);
            this.EnterCourseFeeBox.Name = "EnterCourseFeeBox";
            this.EnterCourseFeeBox.Size = new System.Drawing.Size(100, 22);
            this.EnterCourseFeeBox.TabIndex = 16;
            // 
            // EnterCourseTitleBox
            // 
            this.EnterCourseTitleBox.Location = new System.Drawing.Point(61, 39);
            this.EnterCourseTitleBox.Name = "EnterCourseTitleBox";
            this.EnterCourseTitleBox.Size = new System.Drawing.Size(185, 22);
            this.EnterCourseTitleBox.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddCourse);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(195, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Course Fee";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Level";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Title";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(47, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 16);
            this.label16.TabIndex = 15;
            this.label16.Text = "Select Student";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(47, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 16);
            this.label17.TabIndex = 16;
            this.label17.Text = "Select Course";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(47, 138);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 16);
            this.label18.TabIndex = 17;
            this.label18.Text = "Enrollment Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Purple;
            this.label14.Location = new System.Drawing.Point(151, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Course Fee :";
            // 
            // ShowCourseFeeBox
            // 
            this.ShowCourseFeeBox.AutoSize = true;
            this.ShowCourseFeeBox.ForeColor = System.Drawing.Color.Purple;
            this.ShowCourseFeeBox.Location = new System.Drawing.Point(240, 178);
            this.ShowCourseFeeBox.Name = "ShowCourseFeeBox";
            this.ShowCourseFeeBox.Size = new System.Drawing.Size(14, 16);
            this.ShowCourseFeeBox.TabIndex = 19;
            this.ShowCourseFeeBox.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.EnrollCourseCBox);
            this.groupBox3.Controls.Add(this.EnrollStudentCBox);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.ShowCourseFeeBox);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(444, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 254);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enroll in a Course";
            // 
            // groupBox4
            // 
            this.groupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.ViewStudentCBox);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(331, 282);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(516, 204);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "View Enrolled Courses";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 514);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox EnrollCourseCBox;
        private System.Windows.Forms.ComboBox EnrollStudentCBox;
        private System.Windows.Forms.ComboBox ViewStudentCBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton EnterTypeProfessionalRadioButton;
        private System.Windows.Forms.RadioButton EnterTypeStudentRadioButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton EnterLevelAdvancedRadioButton;
        private System.Windows.Forms.RadioButton EnterLevelIntermediateRadioButton;
        private System.Windows.Forms.RadioButton EnterLevelBeginnerRadioButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EnterParticipantRegNoBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox EnterParticipantEmailBox;
        private System.Windows.Forms.TextBox EnterParticipantContactNoBox;
        private System.Windows.Forms.TextBox EnterParticipantNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton EnterCourseLevelAdvancedRadioButton;
        private System.Windows.Forms.RadioButton EnterCourseLevelIntermediateRadioButton;
        private System.Windows.Forms.RadioButton EnterCourseLevelBeginnerRadioButton;
        private System.Windows.Forms.TextBox EnterCourseFeeBox;
        private System.Windows.Forms.TextBox EnterCourseTitleBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label ShowCourseFeeBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

