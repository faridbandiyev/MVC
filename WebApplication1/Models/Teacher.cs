using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models
{
	public class Teacher
	{
		public Teacher(string name, int id)
		{
			Name = name;
			Id = id;
		}

		public int Id { get; set; }
		public string Name { get; set; }

		public override string ToString()
		{
			return $"Name: {Name} Id:{Id}";
		}
	}
}
