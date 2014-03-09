using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QDBackup
{
    public class BackupJob
    {
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

        public JobStatus Run()
        {
            JobStatus ret = new JobStatus { Status = JobStatus.CompletionFlag.InProgress };
            while (ret.Status == JobStatus.CompletionFlag.InProgress && !_stopFlag)
            {
                
            }

            return ret;
        }
        
    }
}
