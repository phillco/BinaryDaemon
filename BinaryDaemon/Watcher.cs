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

        public Process Process
        {
            get
            {
                if ( cachedProcess == null )
                    cachedProcess = FindRunningProcess( );

                return cachedProcess;
            }
        }

        public bool IsProcessRunning
        {
            get
            {
                return ( Process != null );
            }
        }

        private Thread WorkThread;

        private FileSystemWatcher fileWatcher = new FileSystemWatcher( );

        private bool RestartInvoked = false;

        private Process cachedProcess;

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

        private Process FindRunningProcess( )
        {
            Console.WriteLine( "Finding..." );
            foreach ( Process p in Process.GetProcesses( ) )
            {
                if ( p.ProcessName.StartsWith( File.Name.Substring( 0, File.Name.Length - File.Extension.Length ) ) )
                    return p;
            }

            return null;
        }

        private void RestartApplication( )
        {
            if ( !RestartWhenChanged )
                return;

            // Wait a bit to allow multiple FileWatcher notifications to clear.
            Thread.Sleep( 200 );
            LastModified = DateTime.Now;

            Process process = Process;
            
            if ( process != null )
            {
                // Kill the old process...
                process.Kill( );

                // ...and start it again.
                cachedProcess = new Process( );
                cachedProcess.StartInfo.FileName = File.FullName;
                cachedProcess.Start( );
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
                return "Watching";
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
