using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
		}

		private async void Update_Load(object sender, EventArgs e)
		{
			#region Status

			var dt = new DataTable();
			dt.Columns.Add("Text");
			dt.Columns.Add("Val", typeof(byte));

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

			var query = "select top 1 GStudentId, Name,Birthdate,Gender,Address,School,cast(Status as int) as Status,Recorded " +
						"FROM Student " +
						"where GStudentId=@GStudentId";
			var result = await DataBase.GetById<Student>(query, new
			{
				GStudentId = _studentId
			});

			txtName.Text = result.Name;
			drpDOB.Value = result.Birthdate;
			rdbFemale.Checked = result.Gender == "F"; rdbMale.Checked = result.Gender == "M";
			cmbStatus.SelectedValue = result.Status;
			txtAddress.Text = result.Address;
			txtSchool.Text = result.School;
		}
	}
}
