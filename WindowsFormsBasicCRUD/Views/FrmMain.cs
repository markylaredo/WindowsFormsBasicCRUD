using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsBasicCRUD.Helpers;
using WindowsFormsBasicCRUD.Models;

namespace WindowsFormsBasicCRUD.Views
{
	public partial class FrmMain : Form
	{
		private Guid _studentId;
		private const string Connection = "Data Source=.;Initial Catalog=TUTStudentDb;Integrated Security=True";

		public FrmMain()
		{
			InitializeComponent();
		}

		private void createToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//use using to dispose resource after use
			using (var reg = new FrmUpdate())
			{
				reg.ShowDialog();
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private async void reloadDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			await LoadData().ConfigureAwait(false);
		}

		/// <summary>
		/// Pullout records from database
		/// </summary>
		/// <returns></returns>
		private async Task LoadData()
		{
			var query = "SELECT GStudentId, Name,Birthdate,Gender,Address,School,cast(Status as int) as Status,Recorded FROM Student";
			var list = await DBase.LoadDataAsync<Student>(query);
			dataGridView1.DataSource = list;
			//Hide the Column ID
			dataGridView1.Columns[0].Visible = false;
			_studentId = Guid.Empty;
			dataGridView1.ClearSelection();
		}

		private async void FrmMain_Load(object sender, EventArgs e)
		{
			await LoadData().ConfigureAwait(false);
		}

		private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			var rowIndex = e.RowIndex;
			var row = dataGridView1.Rows;
			_studentId = Guid.Parse(row[rowIndex].Cells["GStudentId"].Value.ToString());
		}

		/// <summary>
		/// Update selected records
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_studentId == Guid.Empty)
			{
				MessageBox.Show("Please select a record", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			using (var frm = new Update(_studentId))
			{
				frm.ShowDialog();
			}

			await LoadData().ConfigureAwait(false);
		}

		/// <summary>
		/// Remove selected records
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var dialog = MessageBox.Show("Are you sure do you want to delete this record?", "System Message",
				 MessageBoxButtons.YesNo,
				 MessageBoxIcon.Question,
				 MessageBoxDefaultButton.Button2 //default to no
				 );

			if (dialog == DialogResult.Yes)
			{
				try
				{
					var query = "delete from student where GStudentId=@GStudentId";
					var std = new Student();
					std.GStudentId = _studentId;
					await std.ExecuteAsync(query);

					//Refresh records
					await LoadData().ConfigureAwait(false);
				}
				catch (Exception exception)
				{
					Console.WriteLine(exception);
					throw;
				}
			}
		}

		/// <summary>
		/// Refresh Records
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			await LoadData().ConfigureAwait(false);
		}

		private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			var dialog = MessageBox.Show("Are you sure do you want to close this application?", "System Message",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2 //default to no
			);

			e.Cancel = dialog != DialogResult.Yes;
		}
 
	}
}
