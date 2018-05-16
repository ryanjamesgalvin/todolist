using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Task
    {
        //string for task text
        private string task;

        public Task(string t)
        {
            //constructor for task objects
            task = t;
        }

        public string getText()
        {
            //get the text of a task object
            return this.task;
        }
    }
}
