using System;
using System.Windows.Forms;

namespace BibliotecaML.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMENÚ_PRINCIPAL());
        }
    }
}