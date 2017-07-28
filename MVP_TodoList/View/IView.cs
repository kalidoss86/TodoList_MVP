//https://github.com/Dem0n13/MVPWinFormsDemo/blob/master/UI/Program.cs
using MVP_TodoList.Model;
using MVP_TodoList.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_TodoList.View
{
    public interface IView
    {
        TodoItem todo { get; set; }

        IPresenter Presenter { get; set; }

        event Action Add;

        event Action FormLoad;

        void LoadView(List<TodoItem> list);

        void ShowError(string errroMessage);
    }
}
