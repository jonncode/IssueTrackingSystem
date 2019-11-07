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
        public string Priority { get; set; }
        public string Status { get; set; }
        public Issue(string name, string description, string assignee, string status, string priority, DateTime created)
        {
            Name = name;
            Description = Description;
            Assignee = assignee;
            Priority = priority;
            Created = created;
            Status = status;
        }
    }
}