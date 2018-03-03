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
    class NormalWay
    {

        public static void StartNormalWay()
        {
            //Starts All
            Start();
        }

        static void Start()
        {
            //Get the victim's ip and the time to execute it.
            int time;
            int packages;
            int packagesLength;

            Console.Write("Victim's IP address: ");
            string ip = Console.ReadLine();

            tryAgainTime:;
            Console.Write("Time to be executed(in seconds): ");
            try
            {
                time = Convert.ToInt32(Console.ReadLine());
                if (time == 0)
                {
                    MessageBox.Show("It cannot be zero!");
                    goto tryAgainTime;
                }
            }
            catch
            {
                goto tryAgainTime;
            }

            tryAgainPackages:;
            Console.Write("Number of packages to be sent:");
            try
            {
                packages = Convert.ToInt32(Console.ReadLine());
                if (packages == 0)
                {
                    MessageBox.Show("It cannot be zero!");
                    goto tryAgainPackages;
                }
            }
            catch
            {
                goto tryAgainPackages;
            }

            tryAgainPackagesLength:;

            Console.Write("Packages length: ");
            try
            {
                packagesLength = Convert.ToInt32(Console.ReadLine());
                if(packagesLength == 0)
                {
                    MessageBox.Show("It cannot be zero!");
                    goto tryAgainPackagesLength;
                }
            }
            catch
            {
                goto tryAgainPackagesLength;
            }

            //Clean the console, wait one second and then continue.
            Console.Clear();
            Thread.Sleep(1000);

            //Asks if the user wanna continue the program.
            Console.Write("Continue? [Y/N]: ");

            tryAgain:;

            try
            {
                char charactere = Convert.ToChar(Console.ReadLine());

                //If the answer is equals to 'y' or 'Y', it's going to Start, else it's going to quit the program.
                if (charactere == 'y' || charactere == 'Y')
                {
                    IFunctions.StartDOS(ip, time * 1000, packages * 1000, packagesLength * 1000);
                    Application.Exit();
                }
                else Application.Exit();
            }
            catch
            {
                goto tryAgain;
            }
        }
    }
}
