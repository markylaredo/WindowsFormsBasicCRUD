using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsBasicCRUD.Helpers
{
	public static class Database
	{
		public const string Connection = "Data Source=.;Initial Catalog=TUTStudentDb;Integrated Security=True";

		public static void Execute<T>(this T obj, string query)
		{
			using (IDbConnection con = new SqlConnection(Database.Connection))
			{
				con.Execute(query, obj);
			}
		}
	}
}
