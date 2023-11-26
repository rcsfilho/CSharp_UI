using CefSharp.WinForms;
using CefSharp;
using System.Runtime.CompilerServices;

namespace ui_wfa_SistVet
{
    internal static class Program
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
            frmAcesso acessoForm = new frmAcesso();
            if(acessoForm.ShowDialog() == DialogResult.OK)
            {
                acessoForm.Close();
                Application.Run(new frmPrincipal());               
            }           
        }
    }
}