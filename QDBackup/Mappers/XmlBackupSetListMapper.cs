using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QDBackup.Mappers
{
    public class XmlBackupSetListMapper : IBackupSetListMapper
    {
        public string FilePath { get; protected set; }
        protected XmlSerializer _serializer;

        public XmlBackupSetListMapper(string path)
        {
            FilePath = path;
            _serializer = new XmlSerializer(typeof(BackupSetList));
        }

        public BackupSetList Load()
        {
            if(File.Exists(FilePath))
            {
                return new BackupSetList(this);
            }
            else
            {
                var fileStream = new FileStream(FilePath, FileMode.Open);
                return (BackupSetList)_serializer.Deserialize(fileStream);
            }
        }

        public bool Save(BackupSetList list)
        {
            try
            {
                var fileStream = new FileStream(FilePath, FileMode.Create);
                _serializer.Serialize(fileStream, list);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
                return false;
            }
            return true;
        }
    }
}
