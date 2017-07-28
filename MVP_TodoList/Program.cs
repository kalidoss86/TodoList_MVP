using MVP_TodoList.Model;
using MVP_TodoList.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using MVP_TodoList.View;

namespace MVP_TodoList
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

            IUnityContainer objContainer = new UnityContainer();
            objContainer.RegisterType<IView, Form1>();
            objContainer.RegisterType<IModel, TodoModel>();
            objContainer.RegisterType<IPresenter, TaskPresenter>();


            //IModel model = new TodoModel();


            IPresenter presenter = objContainer.Resolve<TaskPresenter>();//  new TaskPresenter(form1, model);

            Form1 form1 = presenter._view as Form1;

            Application.Run(form1);
        }
    }
}
