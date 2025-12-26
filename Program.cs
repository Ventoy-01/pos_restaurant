namespace Pos_Restaurant;

using Pos_Restaurant.Models;
using Pos_Restaurant.Dao;
using Pos_Restaurant.Views.Menus;
using Pos_Restaurant.Views.Clients;
static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new AfficherClientForm());
        // Application.Run(new MainForm());
    }
}

