namespace TaskFrontToBack.DataAccessLayer.Entities
{
    public class Student:Entity
    {
        public string? Name { get; set; }
        public int? Grade { get; set; }

        public ICollection<TeacherStudent> TeacherStudents { get; set; } = new List<TeacherStudent>();

    }
}
