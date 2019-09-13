using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsBasicCRUD.Helpers;
using WindowsFormsBasicCRUD.Models;

namespace WindowsFormsBasicCRUD.Views
{
	public partial class Update : Form
	{
		private readonly Guid _studentId;

		public Update(Guid studentId)
		{
			_studentId = studentId;
			InitializeComponent();
		}

		private void BtnUpdate_Click(object sender, EventArgs e)
		{
			var query = "update Student set Name=@Name,Birthdate=@Birthdate,Gender=@Gender,Address=@Address,School=@School,Status=@Status " +
						"where GStudentId=@GStudentId";

			var std = new Student();
			std.GStudentId = _studentId;
			std.Name = txtName.Text;
			std.Birthdate = drpDOB.Value;
			std.Gender = rdbFemale.Checked
						? "F" : rdbMale.Checked
						? "M" : "";
			var stats = cmbStatus.SelectedValue.ToString();
			std.Status = (Status)Enum.Parse(typeof(Status), stats);
			std.Address = txtAddress.Text;
			std.School = txtSchool.Text;
			try
			{

				 std.Execute(query);
				MessageBox.Show("Record successfully updated.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

				ClearFields();	
 				Close();
			}
			catch (Exception)
			{
				throw;
			}
		}

		private async void Update_Load(object sender, EventArgs e)
		{
			#region Setup comboBox value for Status

			var dt = new DataTable();
			dt.Columns.Add("Text", typeof(string));
			dt.Columns.Add("Val", typeof(byte));

			var rNoVal = dt.NewRow();
			rNoVal["Text"] = "Select";
			dt.Rows.Add(rNoVal);

			var row = dt.NewRow();
			row["Text"] = Status.Active.ToString();
			row["Val"] = (byte)Status.Active;
			dt.Rows.Add(row);

			var row2 = dt.NewRow();
			row2["Text"] = Status.Dropped.ToString();
			row2["Val"] = (byte)Status.Dropped;
			dt.Rows.Add(row2);

			cmbStatus.DataSource = dt;
			cmbStatus.DisplayMember = "Text";
			cmbStatus.ValueMember = "Val";

			#endregion

			#region   Get Student Details  

			var query = "select top 1 GStudentId, Name,Birthdate,Gender,Address,School,cast(Status as int) as Status,Recorded " +
						"FROM Student " +
						"where GStudentId=@GStudentId";
			var result = await DBase.GetById<Student>(query, new { GStudentId = _studentId });

			txtName.Text = result.Name;
			drpDOB.Value = result.Birthdate;
			rdbFemale.Checked = result.Gender == "F"; rdbMale.Checked = result.Gender == "M";
			cmbStatus.SelectedValue = result.Status;
			txtAddress.Text = result.Address;
			txtSchool.Text = result.School;

			#endregion
		}

		#region Helpers
		private void ClearFields()
		{
			if (InvokeRequired)
			{
				Debug.WriteLine("Invoke is required");
				Invoke(new Action(delegate
				{
					txtName.Clear();
					drpDOB.Value = DateTime.Now;
					rdbFemale.Checked = false;
					rdbMale.Checked = false;
					cmbStatus.SelectedIndex = 0;
					txtAddress.Clear();
					txtSchool.Clear();
				}));
			}
			else
			{
				txtName.Clear();
				drpDOB.Value = DateTime.Now;
				rdbFemale.Checked = false;
				rdbMale.Checked = false;
				cmbStatus.SelectedIndex = 0;
				txtAddress.Clear();
				txtSchool.Clear();
			}
		}
		#endregion
	}
}
