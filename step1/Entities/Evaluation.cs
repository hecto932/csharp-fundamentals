using System;

namespace CoreSchool.Entities
{
    public class Evaluation
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }

        public Student Student { get; set; }
        public Subject Subject  { get; set; }

        public float Points { get; set; }

        public Evaluation() => UniqueId = Guid.NewGuid().ToString();
    }
}