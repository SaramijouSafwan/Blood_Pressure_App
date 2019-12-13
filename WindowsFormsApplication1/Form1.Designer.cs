namespace WindowsFormsApplication1
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
            this.ssnText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.ageText = new System.Windows.Forms.TextBox();
            this.genderText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.weightText = new System.Windows.Forms.TextBox();
            this.signin = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lowerText = new System.Windows.Forms.TextBox();
            this.upperText = new System.Windows.Forms.TextBox();
            this.measure = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dietPlan = new System.Windows.Forms.ListBox();
            this.bloodPressure = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timeText = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ssnText
            // 
            this.ssnText.Location = new System.Drawing.Point(87, 9);
            this.ssnText.Name = "ssnText";
            this.ssnText.Size = new System.Drawing.Size(158, 20);
            this.ssnText.TabIndex = 0;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(87, 34);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(158, 20);
            this.nameText.TabIndex = 1;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(87, 59);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(158, 20);
            this.passwordText.TabIndex = 3;
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(87, 84);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(158, 20);
            this.ageText.TabIndex = 2;
            // 
            // genderText
            // 
            this.genderText.Location = new System.Drawing.Point(87, 109);
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(158, 20);
            this.genderText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "SSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "USER NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PASSWORD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "AGE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "GENDER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "WEIGHT";
            // 
            // weightText
            // 
            this.weightText.Location = new System.Drawing.Point(87, 134);
            this.weightText.Name = "weightText";
            this.weightText.Size = new System.Drawing.Size(158, 20);
            this.weightText.TabIndex = 13;
            // 
            // signin
            // 
            this.signin.Location = new System.Drawing.Point(7, 172);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(75, 23);
            this.signin.TabIndex = 14;
            this.signin.Text = "SIGN IN";
            this.signin.UseVisualStyleBackColor = true;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(88, 172);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(75, 23);
            this.signup.TabIndex = 15;
            this.signup.Text = "SIGN UP";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(169, 172);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(75, 23);
            this.find.TabIndex = 16;
            this.find.Text = "FIND";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(250, 172);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 17;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "BLOOD PRESSURE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "LOWER";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "UPPER";
            // 
            // lowerText
            // 
            this.lowerText.Location = new System.Drawing.Point(346, 55);
            this.lowerText.Name = "lowerText";
            this.lowerText.Size = new System.Drawing.Size(158, 20);
            this.lowerText.TabIndex = 20;
            // 
            // upperText
            // 
            this.upperText.Location = new System.Drawing.Point(346, 30);
            this.upperText.Name = "upperText";
            this.upperText.Size = new System.Drawing.Size(158, 20);
            this.upperText.TabIndex = 19;
            // 
            // measure
            // 
            this.measure.Location = new System.Drawing.Point(346, 81);
            this.measure.Name = "measure";
            this.measure.Size = new System.Drawing.Size(158, 23);
            this.measure.TabIndex = 23;
            this.measure.Text = "MEASURE";
            this.measure.UseVisualStyleBackColor = true;
            this.measure.Click += new System.EventHandler(this.measure_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(296, 116);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(46, 13);
            this.status.TabIndex = 24;
            this.status.Text = "Status : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "DIET PLAN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(367, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "GET DIET PLAN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dietPlan
            // 
            this.dietPlan.FormattingEnabled = true;
            this.dietPlan.Location = new System.Drawing.Point(398, 174);
            this.dietPlan.Name = "dietPlan";
            this.dietPlan.Size = new System.Drawing.Size(367, 121);
            this.dietPlan.TabIndex = 28;
            // 
            // bloodPressure
            // 
            this.bloodPressure.FormattingEnabled = true;
            this.bloodPressure.Location = new System.Drawing.Point(7, 232);
            this.bloodPressure.Name = "bloodPressure";
            this.bloodPressure.Size = new System.Drawing.Size(367, 121);
            this.bloodPressure.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "TRACK YOUR BLOOD PRESSURE";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(367, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "TRACK BLOOD PRESSURE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(543, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Notify Me";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timeText
            // 
            this.timeText.Location = new System.Drawing.Point(625, 12);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(32, 20);
            this.timeText.TabIndex = 33;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(540, 84);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(59, 13);
            this.email.TabIndex = 34;
            this.email.Text = "Messege : ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(543, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "Cheak Email";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.email);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bloodPressure);
            this.Controls.Add(this.dietPlan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.status);
            this.Controls.Add(this.measure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lowerText);
            this.Controls.Add(this.upperText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.update);
            this.Controls.Add(this.find);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.weightText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genderText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.ssnText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ssnText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.TextBox genderText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox weightText;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lowerText;
        private System.Windows.Forms.TextBox upperText;
        private System.Windows.Forms.Button measure;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox dietPlan;
        private System.Windows.Forms.ListBox bloodPressure;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox timeText;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Button button4;
    }
}

