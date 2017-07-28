using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP_TodoList.Model;
using MVP_TodoList.View;

namespace MVP_TodoList.Presenter
{
    public class TaskPresenter : IPresenter
    {
        public IView _view { get; set; }
        public IModel _model { get; set; }

        public TaskPresenter(IView view, IModel model)
        {
            this._view = view;
            this._model = model;
            WireUpEvents();
        }


        public void Add()
        {
            try
            {
                _model.AddTask(_view.todo);

            }
            catch (Exception e)
            {
                _view.ShowError(e.Message);
            }
            LoadView();
        }

        public void LoadView()
        {
            _view.LoadView(_model.TodoList);
        }

        public void WireUpEvents()
        {
            _view.Add += _view_Add;
            _view.FormLoad += _view_FormLoad;
        }

        private void _view_FormLoad()
        {
            _view.LoadView(_model.TodoList);
        }

        private void _view_Add()
        {
            Add();
        }
    }
}
