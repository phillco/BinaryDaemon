using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryDaemon
{
    class WatcherController
    {
        public static List<Watcher> Watchers { get; private set; }

        static WatcherController( )
        {
            Watchers = new List<Watcher>( );
        }

        public static void SaveWatcher( Watcher w )
        {
            if ( Watchers.Contains( w ) )
                ;
            else
                Watchers.Add( w );
        }
    }
}
