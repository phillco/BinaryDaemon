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
            tbRestartParameters.Enabled = cbRestartProcess.Checked;
            btnBrowse.Enabled = tbCopyPath.Enabled = cbCopyFile.Checked;
        }

        private void LoadFromOptions( WatcherOptions options )
        {
            cbRestartProcess.Checked = options.RestartEnabled;
            cbCopyFile.Checked = options.CopyEnabled;
            tbRestartParameters.Text = options.RestartParameters;
            tbCopyPath.Text = options.CopyPath;
        }

        private void SaveToOptions( WatcherOptions options )
        {
            options.RestartEnabled = cbRestartProcess.Checked;
            options.CopyEnabled = cbCopyFile.Checked;
            options.RestartParameters = tbRestartParameters.Text;
            options.CopyPath = tbCopyPath.Text;
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
                tbCopyPath.Text = copyFolderBrowser.SelectedPath;
        }
    }
}
