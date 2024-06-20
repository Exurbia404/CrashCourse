using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    public class ActionItem
    {
        //These are properties, properties are used for communication outside of the class
        public string Name { get; set; }
        public string Description { get; set; }
        public int Difficulty { get; set; }

        //This property is an enum(eration), they allow you to create custom variables
        public Priority Priority { get; set; }

        //This is the constructor of the object ActionItem. The constructor has multiple parameters; name, description, difficulty and priority
        //When creating an ActionItem, all of these parameters are required in order to create a new object.
        public ActionItem(string name, string description, int difficulty, Priority priority)
        {
            //Here we set the properties of an object using the given parameters
            Name = name;
            Description = description;
            Difficulty = difficulty;
            Priority = priority;
        }

        //This is an function named ToString, it has no parameters and returns a string
        public override string ToString()
        {
            return "Name: " + Name + ", Description: " + Description + ", Difficulty: " + Difficulty + ", Priority: " + Priority;
        }
    }
}
