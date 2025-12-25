using Pos_Restaurant.Models;
using Pos_Restaurant.Dao;
namespace Pos_Restaurant;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        
        MenuDao dao = new MenuDao();
		 	
        MenusModel menumodel = new MenusModel("465", "dfyvg");
        dao.Save(menumodel);
        
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}

