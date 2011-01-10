﻿using System;
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

            List<Watcher> selected = new List<Watcher>( );
            foreach ( ListViewItem item in lvWatchers.Items )
                selected.Add( (Watcher) item.Tag );

            lvWatchers.Items.Clear( );
            foreach ( Watcher w in watchers )
            {
                string[] columns = { w.File.Name, w.GetStatus( ), w.GetOnChangeString( ), w.LastModified.ToShortTimeString( ) };
                ListViewItem item = new ListViewItem( columns );
                item.Tag = w;
                item.Selected = selected.Contains( w );
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
                } );
                UpdateState( );
            }
        }

        private Watcher getSelectedWatcher( )
        {
            if ( lvWatchers.SelectedItems.Count > 0 )
                return (Watcher) lvWatchers.SelectedItems[0].Tag;
            else
                return null;
        }

        private void editToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Watcher watcher = getSelectedWatcher( );

            if ( watcher != null )
            {
                new WatcherOptionsForm( watcher ).ShowDialog( );
                UpdateState( );
            }
        }

        private void listContextMenu_Opening( object sender, CancelEventArgs e )
        {
            Watcher watcher = getSelectedWatcher( );

            if ( watcher == null )
            {
                e.Cancel = true;
                return;
            }

            startStopToolStripMenuItem.Text = watcher.IsRunning( ) ? "Stop" : "Start";
        }

        private void startStopToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Watcher watcher = getSelectedWatcher( );

            if ( watcher != null )
            {
                if ( watcher.IsRunning( ) )
                    watcher.Stop( );
                else
                    watcher.Start( );

                UpdateState( );
            }
        }

        private void refreshTimer_Tick( object sender, EventArgs e )
        {
            UpdateState( );
        }
    }
}