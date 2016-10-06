#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ProjectTreeControl
{
    public class Project
    {
        // Use an enumeration to represent the three project status types.
        public enum StatusType
        {
            Unassigned,
            InProgress,
            Closed
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        private StatusType status;
        public StatusType Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }


        public Project(string name, string description, StatusType status)
        {
            Name = name;
            Description = description;
            Status = status;
        }
    }
}
