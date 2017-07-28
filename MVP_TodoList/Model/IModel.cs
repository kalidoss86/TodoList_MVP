using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_TodoList.Model
{
    public interface IModel
    {
        List<TodoItem> TodoList { get; set; }

        void AddTask(TodoItem item);

        void RemoveTask(TodoItem item);

        void UpdateTask(TodoItem item);

        void MarkCompleted(TodoItem item);
    }
}
