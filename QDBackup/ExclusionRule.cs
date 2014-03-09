using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QDBackup
{
    public class ExclusionRule
    {
        public string Name { get; protected set; }
        public string Path { get; protected set; }
    }
}
