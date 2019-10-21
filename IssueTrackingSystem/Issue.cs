using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystem
{
    class Issue
    {
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public string Assignee { get; set; }
        public int Priority { get; set; }
    }
}
