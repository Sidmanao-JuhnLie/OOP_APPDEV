using System;
using System.Windows.Forms;
using ProjectorReservationSystem.Forms;

namespace ProjectorReservationSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}