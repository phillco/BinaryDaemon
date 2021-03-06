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
            showOrHideToolStripMenuItem.Text = Visible ? "Hide" : "Show";

            List<Watcher> watchers = new List<Watcher>( WatcherController.Watchers );

            List<Watcher> selected = new List<Watcher>( );
            foreach ( ListViewItem item in lvWatchers.Items )
                selected.Add( (Watcher) item.Tag );

            lvWatchers.Items.Clear( );
            foreach ( Watcher w in watchers )
            {
                string[] columns = { w.File.Name, w.GetStatus( ), w.Options.GetOnChangeString( ), w.GetLastChangedString( ) };
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
                WatcherController.SaveWatcher( new Watcher( new FileInfo( watchFileDialog.FileName ) ) );
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

            restartToolStripMenuItem.Text = String.Format( "{0} program", watcher.IsProcessRunning ? "Restart" : "Start" );
            stopToolStripMenuItem.Enabled = watcher.IsProcessRunning;
        }

        private void refreshTimer_Tick( object sender, EventArgs e )
        {
            UpdateState( );
        }

        private void restartToolStripMenuItem_Click( object sender, EventArgs e )
        {
            getSelectedWatcher( ).RestartProcess( );
        }

        private void stopToolStripMenuItem_Click( object sender, EventArgs e )
        {
            getSelectedWatcher( ).StopProcess( );
        }

        private void exitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Close( );
        }

        private void MainForm_Resize( object sender, EventArgs e )
        {
            if ( this.WindowState == FormWindowState.Minimized )
                Hide( );
        }

        private void ShowFromTray( )
        {
            Show( );
            WindowState = FormWindowState.Normal;
            BringToFront( );
        }

        private void ToggleVisibility( )
        {
            if ( Visible )
                Hide( );
            else
                ShowFromTray( );
        }

        private void showOrHideToolStripMenuItem_Click( object sender, EventArgs e )
        {
            ToggleVisibility( );
        }

        private void notifyIcon_MouseClick( object sender, MouseEventArgs e )
        {
            if ( e.Button == MouseButtons.Left )
                ToggleVisibility( );
        }

        private void watchFileToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if ( watchFileDialog.ShowDialog( ) == DialogResult.OK )
            {
                WatcherController.SaveWatcher( new Watcher( new FileInfo( watchFileDialog.FileName ) ) );
                UpdateState( );
                ShowFromTray( );
            }
        }
    }
}
