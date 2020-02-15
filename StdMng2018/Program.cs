using StdMng2018.AdminForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StdMng2018
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin login = new FrmLogin();
            if(login.ShowDialog()==DialogResult.OK)
            {
               Application.Run(new FrmAdminMain());
                login.Close();
            }
            else
            {
                Application.Exit();
            }
            //Application.Run(new FrmLogin());
        }
    }
}
