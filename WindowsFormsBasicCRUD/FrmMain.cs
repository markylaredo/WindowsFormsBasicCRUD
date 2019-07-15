using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBasicCRUD
{
	public partial class FrmMain : Form
	{
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
	}
}
