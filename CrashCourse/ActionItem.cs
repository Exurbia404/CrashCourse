using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    public class ActionItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Difficulty { get; set; }
        public Priority Priority { get; set; }

        public ActionItem(string name, string description, int difficulty, Priority priority)
        {
            Name = name;
            Description = description;
            Difficulty = difficulty;
            Priority = priority;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Description: " + Description + ", Difficulty: " + Difficulty + ", Priority: " + Priority;
        }
    }
}
