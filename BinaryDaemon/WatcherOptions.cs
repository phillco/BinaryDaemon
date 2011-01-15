using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryDaemon
{
    public class WatcherOptions
    {
        public bool RestartEnabled;

        public string RestartParameters;

        public string CopyPath;

        public bool CopyEnabled;

        public static WatcherOptions Defaults
        {
            get
            {
                return new WatcherOptions
                {
                    RestartEnabled = true,
                    RestartParameters = "",
                    CopyEnabled = false
                };
            }
        }

        public string GetOnChangeString( )
        {
            string action = "";

            if ( RestartEnabled )
                action += "Restart";

            if ( CopyEnabled )
            {
                if ( action.Length > 0 )
                    action += ", ";

                action += "Copy to " + CopyPath;
            }

            if ( action.Length > 0)
                return action;
            else
                return "Do Nothing";
        }
    }
}
