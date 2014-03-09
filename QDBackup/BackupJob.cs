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
    }
}
