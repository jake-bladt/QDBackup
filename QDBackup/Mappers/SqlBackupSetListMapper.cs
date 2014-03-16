using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QDBackup.Mappers
{
    public class SqlBackupSetListMapper : IBackupSetListMapper
    {

        protected string _ConnectionString;

        public SqlBackupSetListMapper(string cnStr)
        {
            _ConnectionString = cnStr;
        }

        public BackupSetList Load()
        {
            throw new NotImplementedException();
        }

        public bool Save(BackupSetList list)
        {
            throw new NotImplementedException();
        }
    }
}
