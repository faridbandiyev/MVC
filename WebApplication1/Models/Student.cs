namespace WebApplication1.Models
{
    public class Student
    {
        public Student(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public string Name { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Id: {Id}";
        }
    }
}
