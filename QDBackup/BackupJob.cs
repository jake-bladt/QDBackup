using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QDBackup
{
    public class BackupJob
    {
        public enum CompletionFlag { Abend, InProgress, Complete }
        public class JobStatus
        {
            CompletionFlag Status { get; set; }
            decimal JobCompletePercentage { get; set; }
            decimal SetCompletePercentage { get; set; }
            string Message { get; set; }
        }

        private BackupSet _backupSet;
        private bool _stopFlag;

        public BackupJob(BackupSet backupSet)
        {
            _backupSet = backupSet;
            _stopFlag = false;
        }

        public void Stop()
        {
            _stopFlag = true;
        }


    }
}
