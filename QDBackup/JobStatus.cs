using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QDBackup
{
    public class JobStatus
    {
        public enum CompletionFlag { Abend, InProgress, Complete }

        public CompletionFlag Status { get; set; }
        public decimal JobCompletePercentage { get; set; }
        public decimal SetCompletePercentage { get; set; }
        public string Message { get; set; }
    }
}
