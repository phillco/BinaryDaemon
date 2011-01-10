using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace BinaryDaemon
{
    public class Watcher
    {
        public FileInfo File { get; set; }

        public DateTime LastModified { get; set; }

        public bool RestartWhenChanged { get; set; }

        private Thread WorkThread;

        public void Start( )
        {
            if ( WorkThread == null )
                WorkThread = new Thread( new ThreadStart( WatchLoop ) );

            if ( WorkThread.ThreadState != ThreadState.Running )
                WorkThread.Start( );
        }

        public void Stop( )
        {
            if ( WorkThread != null )
            {
                WorkThread.Abort( );
                WorkThread = null;
            }
        }

        public bool IsRunning( )
        {
            return ( WorkThread != null && WorkThread.IsAlive );
        }

        public string GetStatus( )
        {
            if ( IsRunning())
                return "Running";
            else
                return "Stopped";
        }

        private void WatchLoop( )
        {
            while ( true )
            {               
                Thread.Sleep( 50 );
            }
        }

        public string GetOnChangeString( )
        {
            if ( RestartWhenChanged )
                return "Restart";
            else
                return "Do Nothing";
        }
    }
}
