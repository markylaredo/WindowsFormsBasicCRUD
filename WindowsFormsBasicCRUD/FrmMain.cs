using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsBasicCRUD.Models;
using Dapper;

namespace WindowsFormsBasicCRUD
{
	public partial class FrmMain : Form
	{
		private const string Connection = "Data Source=.;Initial Catalog=TUTStudentDb;Integrated Security=True";

		public FrmMain()
		{
			InitializeComponent();
		}

		private void createToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//use using to dispose resource after use
			using (var reg = new Registration())
			{
				reg.ShowDialog();
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void reloadDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void LoadData()
		{
			var query = "SELECT Name,Birthdate,Gender,Address,School,cast(Status as int) as Status,Recorded FROM Student";
			using (IDbConnection con = new SqlConnection(Connection))
			{
				var list = con.Query<Student>(query);
				dataGridView1.DataSource = list;
			}
		}

		private void FrmMain_Load(object sender, EventArgs e)
		{
			LoadData();
		}
	}
}
