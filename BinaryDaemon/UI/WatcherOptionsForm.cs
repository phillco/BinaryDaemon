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
            LoadFromOptions( watcher.Options );
            UpdateState( );
        }

        private void UpdateState( )
        {
            tbParameters.Enabled = cbRestartProcess.Checked;
            btnBrowse.Enabled = tbCopyToFolder.Enabled = cbCopyFile.Checked;
        }

        private void LoadFromOptions( WatcherOptions options )
        {
            cbRestartProcess.Checked = options.RestartOnChange;
            cbCopyFile.Checked = options.CopyOnChange;
            tbParameters.Text = options.CommandLineArgs;
            tbCopyToFolder.Text = options.PathToCopyTo;
        }

        private void SaveToOptions( WatcherOptions options )
        {
            options.RestartOnChange = cbRestartProcess.Checked;
            options.CopyOnChange = cbCopyFile.Checked;
            options.CommandLineArgs = tbParameters.Text;
            options.PathToCopyTo = tbCopyToFolder.Text;
        }

        private void btnSave_Click( object sender, EventArgs e )
        {
            SaveToOptions( watcher.Options );
            WatcherController.SaveWatcher( watcher );
            Close( );
        }

        private void cbCopyFile_CheckedChanged( object sender, EventArgs e )
        {
            UpdateState( );
        }

        private void cbRestartProcess_CheckedChanged( object sender, EventArgs e )
        {
            UpdateState( );
        }

        private void btnBrowse_Click( object sender, EventArgs e )
        {
            copyFolderBrowser.Description = "Choose a folder to copy " + watcher.File.Name + " to." + Environment.NewLine + "Any file with the same name will be overriden, if possible.";
            if ( copyFolderBrowser.ShowDialog( ) == DialogResult.OK )
                tbCopyToFolder.Text = copyFolderBrowser.SelectedPath;
        }
    }
}
