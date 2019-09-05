using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBasicCRUD.Models
{
	public class Student
	{
		public Guid GStudentId { get; set; }

		public string Name { get; set; }
		public DateTime Birthdate { get; set; }
		public string Gender { get; set; }
		public string Address { get; set; }
		public string School { get; set; }
		public Status Status { get; set; }
		public DateTime Recorded { get; set; }
	}

	public enum Status : byte
	{
		Active,
		Dropped
	}
}
