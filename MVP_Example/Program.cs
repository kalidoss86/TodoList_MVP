using MVP_Example.Model;
using MVP_Example.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Example
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IUserModel _model = new UserModel();

            Form1 view = new Form1();

            IUserPresenter _presenter = new UserPresenter(_model, view);

            Application.Run(view);
        }
    }
}
