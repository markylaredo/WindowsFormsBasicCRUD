using System;
using System.Collections.Generic;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using WindowsFormsBasicCRUD.Models;

namespace WindowsFormsBasicCRUD.Helpers
{
	public static class Database
	{
		private const string Connection = "Data Source=.;Initial Catalog=TUTStudentDb;Integrated Security=True";

		public static void Insert<TEntity>(this TEntity obj, string query)
		{
			using (IDbConnection con = new SqlConnection(Connection))
			{
				con.Execute(query, obj);
			}
		}

		public static void Execute<TEntity>(this TEntity obj, string query)
		{
			using (IDbConnection con = new SqlConnection(Connection))
			{
				con.Execute(query, obj);
			}
		}

		public static async Task ExecuteAsync<TEntity>(this TEntity obj, string query)
		{
			using (IDbConnection con = new SqlConnection(Connection))
			{
				await con.ExecuteAsync(query, obj);
			}
		}

		public static IEnumerable<TEntity> LoadData<TEntity>(string query)
		{
			using (IDbConnection con = new SqlConnection(Connection))
			{
				return con.Query<TEntity>(query);
			}
		}

		public static async Task<IEnumerable<TEntity>> LoadDataAsync<TEntity>(string query)
		{
			using (IDbConnection con = new SqlConnection(Connection))
			{
				return await con.QueryAsync<TEntity>(query);
			}
		}

		public static async Task<TEntity> GetById<TEntity>(string query, object param)
		{
			using (IDbConnection con = new SqlConnection(Connection))
			{
				return await con.QueryFirstOrDefaultAsync<TEntity>(query, param);
			}
		}

	}
}
