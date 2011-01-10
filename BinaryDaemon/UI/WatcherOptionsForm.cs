using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BinaryDaemon.UI
{
    public partial class WatcherOptionsForm : Form
    {
        private Watcher watcher;

        public WatcherOptionsForm( Watcher watcher )
        {
            InitializeComponent( );

            this.Text = watcher.File.Name;
            this.watcher = watcher;
            lblWatchingFile.Text = watcher.File.Name + " options";
        }

        private void btnSave_Click( object sender, EventArgs e )
        {
            watcher.RestartWhenChanged = cbRestartProcess.Checked;
            WatcherController.SaveWatcher( watcher );
            Close( );
        }
    }
}
