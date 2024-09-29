﻿namespace EntityFrameworkIntro.DataAccessLayer.Entities
{
    public class Teacher:Entity
    {
        public string Name {  get; set; }
        public ICollection<TeacherGroup> TeacherGroups { get; set; } = new List<TeacherGroup>();
    }
}
