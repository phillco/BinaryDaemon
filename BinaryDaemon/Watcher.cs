using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace BinaryDaemon
{
    public class Watcher
    {
        public FileInfo File { get; set; }

        public DateTime LastModified { get; set; }

        public bool RestartWhenChanged { get; set; }

        private Thread WorkThread;

        private FileSystemWatcher fileWatcher = new FileSystemWatcher( );

        private bool RestartInvoked = false;

        public Watcher( FileInfo file )
        {
            this.File = file;
            this.RestartWhenChanged = true;
            fileWatcher.Path = File.DirectoryName;
            fileWatcher.Filter = File.Name;
            fileWatcher.EnableRaisingEvents = IsRunning( );
            fileWatcher.Changed += new FileSystemEventHandler( fileWatcher_Changed );
            Start( );
        }

        private void RestartApplication( )
        {
            if ( !RestartWhenChanged )
                return;

            // Wait a bit to allow multiple FileWatcher notifications to clear.
            Thread.Sleep( 200 );
            LastModified = DateTime.Now;

            // Kill the old process...
            foreach ( Process p in Process.GetProcesses( ) )
            {
                if ( p.ProcessName.StartsWith( File.Name.Substring( 0, File.Name.Length - File.Extension.Length ) ) )
                    p.Kill( );
            }

            // ...and start it again.
            using ( Process newProcess = new Process( ) )
            {
                newProcess.StartInfo.FileName = File.FullName;
                newProcess.Start( );
            }

            RestartInvoked = false;
        }

        private void fileWatcher_Changed( object sender, FileSystemEventArgs e )
        {
            RestartInvoked = true;
        }

        public void Start( )
        {
            if ( WorkThread == null )
                WorkThread = new Thread( new ThreadStart( WatchLoop ) );

            if ( WorkThread.ThreadState != System.Threading.ThreadState.Running )
                WorkThread.Start( );

            fileWatcher.EnableRaisingEvents = true;
        }

        public void Stop( )
        {
            if ( WorkThread != null )
            {
                WorkThread.Abort( );
                WorkThread = null;
            }

            fileWatcher.EnableRaisingEvents = false;
        }

        public bool IsRunning( )
        {
            return ( WorkThread != null && WorkThread.IsAlive );
        }

        public string GetStatus( )
        {
            if ( IsRunning( ) )
                return "Running";
            else
                return "Stopped";
        }

        private void WatchLoop( )
        {
            while ( true )
            {
                Thread.Sleep( 50 );

                if ( RestartInvoked )
                    RestartApplication( );
            }
        }

        public string GetOnChangeString( )
        {
            if ( RestartWhenChanged )
                return "Restart";
            else
                return "Do Nothing";
        }

        public string GetLastChangedString( )
        {
            if ( LastModified == DateTime.MinValue )
                return "Never";
            else
                return LastModified.ToShortTimeString( );
        }
    }
}
