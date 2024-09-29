namespace EntityFrameworkIntro.DataAccessLayer.Entities
{
    public class Group : Entity
    {
        public string? Name { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<TeacherGroup> TeacherGroups { get; set; } = new List<TeacherGroup>();
    }
}
