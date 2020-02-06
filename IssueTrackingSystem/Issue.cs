using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystem
{
    public class Issue
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public string Assignee { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }
        public Issue(string name, string description, string assignee, string status, int priority, DateTime created)
        {
            Name = name;
            Description = description;
            Assignee = assignee;
            Priority = priority;
            Created = created;
            Status = status;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public string GetDescription()
        {
            return Description;
        }
        public void SetDescription(string description)
        {
            this.Description = description;
        }
        public DateTime GetCreated()
        {
            return Created;
        }
        public void SetCreated(DateTime created)
        {
            this.Created = created;
        }
        public string GetAssignee()
        {
            return Assignee;
        }
        public void SetAssignee(string assignee)
        {
            this.Assignee = assignee;
        }
        public int GetPriority()
        {
            return Priority;
        }
        public void SetPriority(int priority)
        {
            this.Priority = priority;
        }
        public string GetStatus()
        {
            return Status;
        }
        public void SetStatus(string status)
        {
            this.Status = status;
        }
    }
}