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

            lvWatchers.Items.Clear();
            foreach ( Watcher w in watchers )
            {
                string[] columns = { w.File.Name, w.LastModified.ToShortTimeString()};

                lvWatchers.Items.Add( new ListViewItem( columns) );
            }

        }

        private void btnNewWatcher_Click( object sender, EventArgs e )
        {
            if ( watchFileDialog.ShowDialog( ) == DialogResult.OK )
            {
                Watcher newWatcher = new Watcher
                {
                    File = new FileInfo( watchFileDialog.FileName )
                };
                new WatcherOptionsForm( newWatcher ).ShowDialog( );
                UpdateState( );
            }
        }
    }
}
