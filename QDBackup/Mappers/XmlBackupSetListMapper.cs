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

        protected class SetListElement
        {
            public string Name { get; set; }
            public BackupSet Set { get; set; }
        }

        protected class SerializableSetList : List<SetListElement>
        {
            public static SerializableSetList FromBackupSetList(BackupSetList bsl)
            {
                SerializableSetList ret = new SerializableSetList();
                bsl.ToList().ForEach(kvp => ret.Add(new SetListElement { Name = kvp.Key, Set = kvp.Value }));
                return ret;
            }

            public BackupSetList ToBackupSetList(IBackupSetListMapper mapper)
            {
                BackupSetList ret = new BackupSetList(mapper);
                this.ForEach(elem => ret[elem.Name] = elem.Set);
                return ret;
            }

        }

        public XmlBackupSetListMapper(string path)
        {
            FilePath = path;
            _serializer = new XmlSerializer(typeof(SerializableSetList));
        }

        public BackupSetList Load()
        {
            if(File.Exists(FilePath))
            {
                var fileStream = new FileStream(FilePath, FileMode.Open);
                var intermediateSetList = (SerializableSetList)_serializer.Deserialize(fileStream);
                return intermediateSetList.ToBackupSetList(this);
            }
            else
            {
                return new BackupSetList(this);
            }
        }

        public bool Save(BackupSetList list)
        {
            try
            {
                var fileStream = new FileStream(FilePath, FileMode.Create);
                var intermediateSetList = SerializableSetList.FromBackupSetList(list);
                _serializer.Serialize(fileStream, intermediateSetList);
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
