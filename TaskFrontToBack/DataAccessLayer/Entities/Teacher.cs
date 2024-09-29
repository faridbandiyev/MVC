namespace TaskFrontToBack.DataAccessLayer.Entities
{
    public class Teacher : Entity
    {
        public string? Name { get; set; }
        public ICollection<TeacherStudent> TeacherStudents { get; set; } = new List<TeacherStudent>();
    }
}
