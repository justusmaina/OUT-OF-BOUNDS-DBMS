using System;
using System.Collections.Generic;
using System.Text;


namespace PTSLibrary
{
    [Serializable]
    public class Task
    {
        public Task() { }
        private Guid taskId;
        private string name;
        private Status status;

        public Guid TaskId
        {
            get { return taskId; }
            set { taskId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Status theStatus
        {
            get { return status; }
            set { status = value; }
        }
        public Task(Guid id, string name, Status status)
        {
            this.taskId = id;
            this.name = name;
            this.status = status;
        }
        public String NameandStatus
        {
            get { return name + "-" + status; }
        }
    }
}
