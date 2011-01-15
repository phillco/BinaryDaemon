using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace BinaryDaemon
{
    public class Watcher
    {
        public FileInfo File { get; set; }

        public DateTime LastModified { get; set; }

        public WatcherOptions Options;

        private Process Process
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

        private FileSystemWatcher fileWatcher = new FileSystemWatcher( );

        private bool ChangedNoticed = false;

        private Process cachedProcess;

        public Watcher( FileInfo file )
        {
            this.File = file;
            this.Options = WatcherOptions.Defaults;
            fileWatcher.Path = File.DirectoryName;
            fileWatcher.Filter = File.Name;
            fileWatcher.EnableRaisingEvents = true;
            fileWatcher.Changed += new FileSystemEventHandler( fileWatcher_Changed );
        }

        private Process FindRunningProcess( )
        {
            Console.WriteLine( "Searching for " + File.Name + " in the process list..." );
            foreach ( Process p in Process.GetProcesses( ) )
            {
                if ( p.ProcessName.StartsWith( File.Name.Substring( 0, File.Name.Length - File.Extension.Length ) ) )
                    return p;
            }

            return null;
        }

        public void StopProcess( )
        {
            if ( IsProcessRunning )
            {
                try
                {
                    Process.Kill( );
                }
                catch ( InvalidOperationException ) { }
                cachedProcess = null;
            }
        }

        public void StartProcess( )
        {
            cachedProcess = new Process( );
            cachedProcess.StartInfo.FileName = File.FullName;
            cachedProcess.StartInfo.Arguments = Options.RestartParameters;
            cachedProcess.Start( );
        }

        public void RestartProcess( )
        {
            StopProcess( );
            StartProcess( );
        }

        private void fileWatcher_Changed( object sender, FileSystemEventArgs e )
        {
            Console.WriteLine( Environment.TickCount + " Change noticed!" );
            if ( !ChangedNoticed )
            {
                ChangedNoticed = true;
                new Thread( new ThreadStart( OnFileChanged ) ).Start( );
            }
        }

        private void OnFileChanged( )
        {
            Console.WriteLine( Environment.TickCount + " Acting on it!" );
            LastModified = DateTime.Now;            

            if ( Options.RestartEnabled )
                RestartProcess( );

            if ( Options.CopyEnabled )
            {
                File.CopyTo( Path.Combine( Options.CopyPath, File.Name ), true );
            }

            if ( Options.PlaySoundEnabled )
            {
                using ( SoundPlayer simpleSound = new SoundPlayer( Properties.Resources.ChangedSound ) )
                    simpleSound.Play( );
            }

            Thread.Sleep( 500 );
            ChangedNoticed = false;
        }

        public string GetStatus( )
        {
            if ( IsProcessRunning )
                return "Running";
            else
                return "Not Running";
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
