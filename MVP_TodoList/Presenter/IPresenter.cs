using MVP_TodoList.Model;
using MVP_TodoList.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_TodoList.Presenter
{
    public interface IPresenter
    {
        IView _view { get; set; }

        IModel _model { get; set; }

        void WireUpEvents();

        void Add();

        void LoadView();

    }
}
