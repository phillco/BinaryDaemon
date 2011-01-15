using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryDaemon
{
    public class WatcherOptions
    {
        public bool RestartOnChange;

        public string CommandLineArgs;

        public string PathToCopyTo;

        public bool CopyOnChange;

        public static WatcherOptions Defaults
        {
            get
            {
                return new WatcherOptions
                {
                    RestartOnChange = true,
                    CommandLineArgs = "",
                    CopyOnChange = false
                };
            }
        }

        public string GetOnChangeString( )
        {
            string action = "";

            if ( RestartOnChange )
                action += "Restart";

            if ( CopyOnChange )
            {
                if ( action.Length > 0 )
                    action += ", ";

                action += "Copy to " + PathToCopyTo;
            }

            if ( action.Length > 0)
                return action;
            else
                return "Do Nothing";
        }
    }
}
