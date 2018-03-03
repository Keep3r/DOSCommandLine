using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DOSCommandLine
{
    public abstract class IFunctions
    {

        public static void StartDOS(string ip, int time = 240000000)
        {
            //Calls the commands to start the DOS attack, within the ip and the time that ths will execute.

            //Notify you that it already begins.

            MessageBox.Show("It already starts!" + MessageBoxIcon.Warning);

            try
            {
                Process.Start("ping", String.Format("-w {0} {1}", time, ip));
            }
            catch
            {
                MessageBox.Show("Something goes wrong....");
                Application.Restart();
            }
        }
    }
}
