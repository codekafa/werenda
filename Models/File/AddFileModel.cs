using System;
using System.Collections.Generic;
using System.Text;

namespace Models.File
{
    public class AddFileModel
    {
        public string Name { get; set; }
        public string Key { get; set; }

        public byte[] File { get; set; }
        public string Path { get; set; }
        public string GroupKey { get; set; }
    }
}
