using System;

namespace CoreSchool.Entities
{
    public class Course
    {
        public string Name { get;  set; }
        public string uniqueId { get; private set; }
        public TypeWorkDay typeWorkDay { get; set; }

        public Course () => this.uniqueId = Guid.NewGuid().ToString();

        public override string ToString() 
        {
            return $"Course: UniqueId: {uniqueId}, Name: {Name}, TypeWorkDay: ${typeWorkDay}";
        }
    }
}