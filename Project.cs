using System;
using System.Collections.Generic;
using System.Text;
namespace PTSLibrary
{
    [Serializable]
  public class Project
    {
        public Project() { }
        private string name;
        private DateTime expectedStartDate;
        private DateTime expectedEndDate;
        private Customer theCustomer;
        private Guid projectId;
        private List<Task> tasks;
        public List<Task> Tasks
        {
            get { return tasks; }
            set { tasks = value; }
        }
        public Customer TheCustomer
        {
            get { return theCustomer; }
            set { theCustomer = value; }
        }
        public Guid ProjectId
        {
            get { return projectId; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime ExpectedStartDate
        {
            get { return expectedStartDate; }
            set { expectedStartDate = value; }
        }
        public DateTime ExpectedEndDate
        {
            get { return expectedEndDate; }
            set { expectedEndDate = value; }
        }
        public Project(string name, DateTime startDate, DateTime endDate, Guid projectId,
       Customer customer)
        {
            this.name = name;
            this.expectedStartDate = startDate;
            this.expectedEndDate = endDate;
            this.projectId = projectId;
            this.theCustomer = customer;
        }
    }
}