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

        CompletionFlag Status { get; set; }
        decimal JobCompletePercentage { get; set; }
        decimal SetCompletePercentage { get; set; }
        string Message { get; set; }
    }
}
