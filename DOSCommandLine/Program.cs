using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOSCommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Configure the appereance of the program.
            #region InitialConfigs
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            #endregion

            //Shows the advices to start the program.
            #region Warnings
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("*****Before start be certainly to be using a VPN and a VPS*****");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            #endregion

            //Asks if the user wants the command line execution or the "normal one".

            Console.WriteLine("Command Line or Normal One?(cl/no)");
            string answer = Console.ReadLine();

            if(answer.ToLower() == "no")
            {
                NormalWay.StartNormalWay();
            }
            else if(answer.ToLower() == "cl")
            {
                //CommandLine cl = new CommandLine();
            }
            else
            {
                Application.Restart();
            }

            Console.ReadLine();
        }
    }
}
