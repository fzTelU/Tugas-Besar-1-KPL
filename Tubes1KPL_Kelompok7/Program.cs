using System;
using System.Windows.Forms;
using Tubes1KPL_Kelompok7;

namespace HalamanUtama
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
