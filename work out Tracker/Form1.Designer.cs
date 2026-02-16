namespace work_out_Tracker
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.txtExerciseID = new System.Windows.Forms.Label();
			this.txtExerciseName = new System.Windows.Forms.Label();
			this.cmbIntensity = new System.Windows.Forms.Label();
			this.cmbStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(122, 190);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(305, 99);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(305, 142);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 3;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(305, 183);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 5;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(305, 228);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 20);
			this.textBox6.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(183, 376);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(305, 376);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 10;
			this.button3.Text = "Clear";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(409, 376);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(92, 23);
			this.button4.TabIndex = 11;
			this.button4.Text = "Exit";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// txtExerciseID
			// 
			this.txtExerciseID.AutoSize = true;
			this.txtExerciseID.Location = new System.Drawing.Point(222, 106);
			this.txtExerciseID.Name = "txtExerciseID";
			this.txtExerciseID.Size = new System.Drawing.Size(57, 13);
			this.txtExerciseID.TabIndex = 12;
			this.txtExerciseID.Text = " ExeriselID";
			// 
			// txtExerciseName
			// 
			this.txtExerciseName.AutoSize = true;
			this.txtExerciseName.Location = new System.Drawing.Point(222, 145);
			this.txtExerciseName.Name = "txtExerciseName";
			this.txtExerciseName.Size = new System.Drawing.Size(75, 13);
			this.txtExerciseName.TabIndex = 13;
			this.txtExerciseName.Text = "ExerciseName";
			// 
			// cmbIntensity
			// 
			this.cmbIntensity.AutoSize = true;
			this.cmbIntensity.Location = new System.Drawing.Point(234, 183);
			this.cmbIntensity.Name = "cmbIntensity";
			this.cmbIntensity.Size = new System.Drawing.Size(45, 13);
			this.cmbIntensity.TabIndex = 14;
			this.cmbIntensity.Text = "lntensity";
			this.cmbIntensity.Click += new System.EventHandler(this.label4_Click);
			// 
			// cmbStatus
			// 
			this.cmbStatus.AutoSize = true;
			this.cmbStatus.Location = new System.Drawing.Point(234, 228);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(37, 13);
			this.cmbStatus.TabIndex = 15;
			this.cmbStatus.Text = "Status";
			this.cmbStatus.Click += new System.EventHandler(this.label5_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.cmbStatus);
			this.Controls.Add(this.cmbIntensity);
			this.Controls.Add(this.txtExerciseName);
			this.Controls.Add(this.txtExerciseID);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "โปรเเกรมบันทึกการออกกำลังกาย";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label txtExerciseID;
        private System.Windows.Forms.Label txtExerciseName;
        private System.Windows.Forms.Label cmbIntensity;
        private System.Windows.Forms.Label cmbStatus;
    }
}

