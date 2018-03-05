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
            Console.ForegroundColor = ConsoleColor.DarkRed;
            #endregion

            //Shows the advices to start the program.
            #region Warnings
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("*****Before start be certainly to be using a VPN and a VPS*****\n####I'M NOT RESPONSIBLE FOR YOUR ACTIONS####");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            #endregion

            //Asks if the user wants the command line execution or the "normal one".

            Console.WriteLine("Command Line, Normal One or example?(cl/no/ex)");
            string answer = Console.ReadLine();

            if(answer.ToLower() == "no")
            {
                NormalWay.StartNormalWay();
            }
            else if(answer.ToLower() == "cl")
            {
                Console.WriteLine("To make a DOS attack: 'attack [time] [victim's ip]'");
                while (true)
                {
                    Console.Write("#> ");
                    string cmd = Console.ReadLine();
                    CommandLine.StartCommandLine(cmd);
                }
            }
            else if(answer.ToLower() == "ex")
            {
                IFunctions.StartDOS("127.0.0.1");
            }
            else
            {
                Application.Restart();
            }

            Console.ReadLine();
        }
    }
}
