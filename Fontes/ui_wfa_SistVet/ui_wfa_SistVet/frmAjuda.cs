using CefSharp.WinForms;
using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui_wfa_SistVet
{
    public partial class frmAjuda : Form
    {
        public frmAjuda()
        {
            InitializeComponent();

        }

        private void linkLabelVideo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://youtu.be/mPLUUBwv5wk",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                // Lida com exceções, se houver, como por exemplo o navegador padrão não estar configurado.
                Console.WriteLine(ex.Message);
            }
        }
    }
}
