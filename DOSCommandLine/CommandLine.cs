using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DOSCommandLine
{
    class CommandLine
    {
        public static void StartCommandLine(string cmd)
        {
            //Gets the command, which is "attack [time] [victim's ip]"
            #region Variables
            string command = "";
            string ip = "";
            string time = "";
            #endregion

            //Divide the string
            string[] parts = cmd.Split();

            #region Command
            command = parts[0];

            //Checks if the command has spaces and then remove them.
            if(command.Contains(" "))
            {
                command.Replace(" ", "");
            }

            //If the command isn't equals to "attack", the application exits.
            if(command != "attack" || command == "exit")
            {
                Application.Exit();
            }
            #endregion

            #region time 
            //Time's equals to parts[1](the second word.
            time = parts[1];

            //Replaces the " " for "".
            if(time.Contains(' '))
            {
                time.Replace("", " ");
            }
            #endregion

            #region ip
            //Ip's equals to parts[2].
            ip = parts[2];

            //Removes the " " from ip.
            if(ip.Contains(' '))
            {
                ip.Replace(" ", "");
            }
            #endregion

            IFunctions.StartDOS(ip, Convert.ToInt32(time));
        }

    }
}
