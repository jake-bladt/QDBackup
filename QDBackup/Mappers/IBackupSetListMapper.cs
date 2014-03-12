using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QDBackup.Mappers
{
    public interface IBackupSetListMapper
    {
        BackupSetList Load();
        bool Save(BackupSetList list);
    }
}
