using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BinaryDaemon
{
    public class Watcher
    {
        public FileInfo File { get; set; }

        public DateTime LastModified { get; set; }

        public bool RestartWhenChanged { get; set; }

        public void Start( )
        {
        }
    }
}
