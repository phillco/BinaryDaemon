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
    public partial class MainForm : Form
    {
        public MainForm( )
        {
            InitializeComponent( );
            UpdateState( );
        }

        private void UpdateState( )
        {
            List<Watcher> watchers = new List<Watcher>( WatcherController.Watchers );

            lvWatchers.Items.Clear( );
            foreach ( Watcher w in watchers )
            {
                string[] columns = { w.File.Name, w.GetOnChangeString(), w.LastModified.ToShortTimeString( ) };
                ListViewItem item = new ListViewItem( columns );
                item.Tag = w;
                lvWatchers.Items.Add( item );
            }

        }

        private void btnNewWatcher_Click( object sender, EventArgs e )
        {
            if ( watchFileDialog.ShowDialog( ) == DialogResult.OK )
            {
                WatcherController.SaveWatcher( new Watcher
                {
                    File = new FileInfo( watchFileDialog.FileName ),
                    RestartWhenChanged = true
                });
                UpdateState( );
            }
        }

        private void editToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if ( lvWatchers.SelectedItems.Count > 0 )
                new WatcherOptionsForm( (Watcher) lvWatchers.SelectedItems[0].Tag ).ShowDialog();
        }
    }
}
