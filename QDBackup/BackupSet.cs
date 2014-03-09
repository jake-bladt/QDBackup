using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QDBackup
{
    public class BackupSet : Dictionary<int, BackupFileSource>
    {
        public string Name { get; protected set; }
        public string TargetPath { get; protected set; }
        public string SourcePath { get; protected set; }
        public List<ExclusionRule> Exclusions { get; protected set; }
    }
}
