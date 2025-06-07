

namespace Organização
{
    internal static class Program
    {

        //DECLARAÇÕES DE  VARIAVEIS GLOBAIS DO SISTEMA :

       
        
            public static string NomeUsuario;
            public static string QuemUsuario;
            public static int IdUsuario; 
            public static byte[] FotoUsuario;
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin());
        }
    }
}