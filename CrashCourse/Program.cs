using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ToDoListForm newForm = new ToDoListForm(); 
            newForm.ShowDialog();
        }
    }
}
