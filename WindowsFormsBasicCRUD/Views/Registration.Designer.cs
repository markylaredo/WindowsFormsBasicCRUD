namespace WindowsFormsBasicCRUD.Views
{
	partial class FrmUpdate
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
			this.btnReg = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.drpDOB = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSchool = new System.Windows.Forms.TextBox();
			this.rdbMale = new System.Windows.Forms.RadioButton();
			this.rdbFemale = new System.Windows.Forms.RadioButton();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnReg
			// 
			this.btnReg.Location = new System.Drawing.Point(121, 325);
			this.btnReg.Name = "btnReg";
			this.btnReg.Size = new System.Drawing.Size(119, 27);
			this.btnReg.TabIndex = 0;
			this.btnReg.Text = "Register";
			this.btnReg.UseVisualStyleBackColor = true;
			this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(36, 47);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(230, 21);
			this.txtName.TabIndex = 1;
			this.txtName.Text = "Mark Anthony";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Name:";
			// 
			// drpDOB
			// 
			this.drpDOB.CustomFormat = "MMM dd, yyyy";
			this.drpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.drpDOB.Location = new System.Drawing.Point(36, 93);
			this.drpDOB.Name = "drpDOB";
			this.drpDOB.Size = new System.Drawing.Size(233, 21);
			this.drpDOB.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Birthdate:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 261);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "Address:";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(35, 281);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(230, 21);
			this.txtAddress.TabIndex = 7;
			this.txtAddress.Text = "San Jose";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(35, 215);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 15);
			this.label5.TabIndex = 10;
			this.label5.Text = "School:";
			// 
			// txtSchool
			// 
			this.txtSchool.Location = new System.Drawing.Point(35, 235);
			this.txtSchool.Name = "txtSchool";
			this.txtSchool.Size = new System.Drawing.Size(230, 21);
			this.txtSchool.TabIndex = 9;
			this.txtSchool.Text = "OMSC";
			// 
			// rdbMale
			// 
			this.rdbMale.AutoSize = true;
			this.rdbMale.Checked = true;
			this.rdbMale.Location = new System.Drawing.Point(36, 130);
			this.rdbMale.Name = "rdbMale";
			this.rdbMale.Size = new System.Drawing.Size(53, 19);
			this.rdbMale.TabIndex = 11;
			this.rdbMale.TabStop = true;
			this.rdbMale.Text = "Male";
			this.rdbMale.UseVisualStyleBackColor = true;
			// 
			// rdbFemale
			// 
			this.rdbFemale.AutoSize = true;
			this.rdbFemale.Location = new System.Drawing.Point(95, 131);
			this.rdbFemale.Name = "rdbFemale";
			this.rdbFemale.Size = new System.Drawing.Size(67, 19);
			this.rdbFemale.TabIndex = 11;
			this.rdbFemale.Text = "Female";
			this.rdbFemale.UseVisualStyleBackColor = true;
			// 
			// cmbStatus
			// 
			this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Location = new System.Drawing.Point(35, 187);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(121, 23);
			this.cmbStatus.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 167);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 15);
			this.label3.TabIndex = 13;
			this.label3.Text = "Status:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cmbStatus);
			this.groupBox1.Controls.Add(this.btnReg);
			this.groupBox1.Controls.Add(this.rdbFemale);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.rdbMale);
			this.groupBox1.Controls.Add(this.drpDOB);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtSchool);
			this.groupBox1.Controls.Add(this.txtAddress);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(352, 358);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Personal Info";
			this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
			// 
			// FrmUpdate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 383);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmUpdate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Registration Form";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnReg;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker drpDOB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSchool;
		private System.Windows.Forms.RadioButton rdbMale;
		private System.Windows.Forms.RadioButton rdbFemale;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

