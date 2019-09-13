using System;
using System.Collections.Generic;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using WindowsFormsBasicCRUD.Models;

namespace WindowsFormsBasicCRUD.Helpers
{
	public static class DBase
	{
		private const string Connection = "Data Source=.;Initial Catalog=TUTStudentDb;Integrated Security=True";

		/// <summary>
		/// Insert Record
		/// </summary>
		/// <typeparam name="TEntity"></typeparam>
		/// <param name="obj"></param>
		/// <param name="query"></param>
		public static void Insert<TEntity>(this TEntity obj, string query)
		{
			using (IDbConnection con = new SqlConnection(Connection))
			{
				con.Execute(query, obj);
			}
		}

		/// <summary>
		/// Execute query
		/// </summary>
		/// <typeparam name="TEntity"></typeparam>
		/// <param name="obj"></param>
		/// <param name="query"></param>
		public static void Execute<TEntity>(this TEntity obj, string query)
		{
			using (IDbConnection con = new SqlConnection(Connection))
			{
				con.Execute(query, obj);
			}
		}

		/// <summary>
		/// Execute Query Async
		/// </summary>
		/// <typeparam name="TEntity"></typeparam>
		/// <param name="obj"></param>
		/// <param name="query"></param>
		/// <returns></returns>
		public static async Task ExecuteAsync<TEntity>(this TEntity obj, string query)
		{
			using (IDbConnection con = new SqlConnection(Connection))
			{
				await con.ExecuteAsync(query, obj);
			}
		}

		/// <summary>
		/// Fetch records
		/// </summary>
		/// <typeparam name="TEntity"></typeparam>
		/// <param name="query"></param>
		/// <returns></returns>
		public static IEnumerable<TEntity> LoadData<TEntity>(string query)
		{
			using (IDbConnection con = new SqlConnection(Connection))
			{
				return con.Query<TEntity>(query);
			}
		}

		/// <summary>
		/// Fetch records async
		/// </summary>
		/// <typeparam name="TEntity"></typeparam>
		/// <param name="query"></param>
		/// <returns></returns>
		public static async Task<IEnumerable<TEntity>> LoadDataAsync<TEntity>(string query)
		{
			using (IDbConnection con = new SqlConnection(Connection))
			{
				return await con.QueryAsync<TEntity>(query);
			}
		}

		/// <summary>
		/// Get record by id
		/// </summary>
		/// <typeparam name="TEntity"></typeparam>
		/// <param name="query"></param>
		/// <param name="param"></param>
		/// <returns></returns>
		public static async Task<TEntity> GetById<TEntity>(string query, object param)
		{
			using (IDbConnection con = new SqlConnection(Connection))
			{
				return await con.QueryFirstOrDefaultAsync<TEntity>(query, param);
			}
		}

	}
}
