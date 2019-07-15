using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsBasicCRUD.Models;
using Dapper;

namespace WindowsFormsBasicCRUD
{
	public partial class Registration : Form
	{
		private const string Connection = "Data Source=.;Initial Catalog=TUTStudentDb;Integrated Security=True";

		public Registration()
		{
			InitializeComponent();
		}

		private void btnReg_Click(object sender, EventArgs e)
		{
			var gender = "";

			if (rdbMale.Checked) gender = "M";
			if (rdbFemale.Checked) gender = "F";

			var std = new Student
			{
				Name = txtName.Text,
				Birthdate = drpDOB.Value,
				Gender = gender,
				Address = txtAddress.Text,
				School = txtSchool.Text,
				Status = (Status)Enum.Parse(typeof(Status), cmbStatus.SelectedValue.ToString()),
				Recorded = DateTime.Now
			};

			try
			{
				using (IDbConnection con = new SqlConnection(Connection))
				{
					const string query = "INSERT INTO Student (Name,Birthdate,Gender,Address,School,Status,Recorded)" +
										 " VALUES (@Name,@Birthdate,@Gender,@Address,@School,@Status,@Recorded)";
					con.Execute(query, std);
				}

				MessageBox.Show("Successfully saved!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception exception)
			{
				Debug.WriteLine(exception.ToString());
				Console.WriteLine(exception);
				MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				throw;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var dt = new DataTable();
			dt.Columns.Add("Text");
			dt.Columns.Add("Val");

			var row = dt.NewRow();
			row["Text"] = Status.Active.ToString();
			row["Val"] = (byte)Status.Active;
			dt.Rows.Add(row);

			var row2 = dt.NewRow();
			row2["Text"] = Status.Dropped.ToString();
			row2["Val"] = (byte)Status.Dropped;
			dt.Rows.Add(row2);

			cmbStatus.DataSource = dt; ;
			cmbStatus.DisplayMember= "Text";
			cmbStatus.ValueMember = "Val";
		}
	}
}
