using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QDBackup.Mappers;

namespace QDBackup
{
    public class BackupSetList : Dictionary<string, BackupSet>
    {
        protected IBackupSetListMapper _mapper;

        public BackupSetList(IBackupSetListMapper mapper)
        {
            _mapper = mapper;
        }

        public bool Save()
        {
            return _mapper.Save(this);
        }

    }
}
