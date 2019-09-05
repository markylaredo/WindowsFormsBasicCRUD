using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsBasicCRUD.Helpers
{
	public static class Database
	{
		private static readonly string _connection = "Data Source=.;Initial Catalog=TUTStudentDb;Integrated Security=True";

		public static void Execute<T>(this T obj, string query)
		{
			using (IDbConnection con = new SqlConnection(_connection))
			{
				con.Execute(query, obj);
			}
		}
	}
}
