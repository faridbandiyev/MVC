namespace TaskFrontToBack.DataAccessLayer.Entities
{
    public class TeacherStudent:Entity
    {
        public int? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public int? StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
