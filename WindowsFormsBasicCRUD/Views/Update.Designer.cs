namespace WindowsFormsBasicCRUD.Views
{
	partial class Update
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.rdbFemale = new System.Windows.Forms.RadioButton();
			this.txtName = new System.Windows.Forms.TextBox();
			this.rdbMale = new System.Windows.Forms.RadioButton();
			this.drpDOB = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSchool = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cmbStatus);
			this.groupBox1.Controls.Add(this.btnUpdate);
			this.groupBox1.Controls.Add(this.rdbFemale);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.rdbMale);
			this.groupBox1.Controls.Add(this.drpDOB);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtSchool);
			this.groupBox1.Controls.Add(this.txtAddress);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(14, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(352, 358);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Personal Info";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 167);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Status:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Name:";
			// 
			// cmbStatus
			// 
			this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Location = new System.Drawing.Point(35, 187);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(121, 21);
			this.cmbStatus.TabIndex = 12;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(121, 325);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(119, 27);
			this.btnUpdate.TabIndex = 0;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// rdbFemale
			// 
			this.rdbFemale.AutoSize = true;
			this.rdbFemale.Location = new System.Drawing.Point(95, 131);
			this.rdbFemale.Name = "rdbFemale";
			this.rdbFemale.Size = new System.Drawing.Size(59, 17);
			this.rdbFemale.TabIndex = 11;
			this.rdbFemale.Text = "Female";
			this.rdbFemale.UseVisualStyleBackColor = true;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(36, 47);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(230, 20);
			this.txtName.TabIndex = 1;
			// 
			// rdbMale
			// 
			this.rdbMale.AutoSize = true;
			this.rdbMale.Location = new System.Drawing.Point(36, 130);
			this.rdbMale.Name = "rdbMale";
			this.rdbMale.Size = new System.Drawing.Size(48, 17);
			this.rdbMale.TabIndex = 11;
			this.rdbMale.Text = "Male";
			this.rdbMale.UseVisualStyleBackColor = true;
			// 
			// drpDOB
			// 
			this.drpDOB.CustomFormat = "MMM dd, yyyy";
			this.drpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.drpDOB.Location = new System.Drawing.Point(36, 93);
			this.drpDOB.Name = "drpDOB";
			this.drpDOB.Size = new System.Drawing.Size(233, 20);
			this.drpDOB.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(35, 215);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "School:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Birthdate:";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(35, 281);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(230, 20);
			this.txtAddress.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 261);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Address:";
			// 
			// txtSchool
			// 
			this.txtSchool.Location = new System.Drawing.Point(35, 235);
			this.txtSchool.Name = "txtSchool";
			this.txtSchool.Size = new System.Drawing.Size(230, 20);
			this.txtSchool.TabIndex = 9;
			// 
			// Update
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 383);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Update";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Update";
			this.Load += new System.EventHandler(this.Update_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.RadioButton rdbFemale;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.RadioButton rdbMale;
		private System.Windows.Forms.DateTimePicker drpDOB;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSchool;
	}
}