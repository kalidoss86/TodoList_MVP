using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP_TodoList.DataModel;

namespace MVP_TodoList.Model
{
    public class TodoModel : IModel
    {
        public List<TodoItem> TodoList
        {
            get
            {
                return (new TodoEntities().TodoItemEntities.ToList());
            }
            set { }
        }

        public TodoModel()
        {
            using (var db = new TodoEntities())
            {
                TodoList = db.TodoItemEntities.ToList();
            }
        }

        private void LoadList()
        {
            //Load from Db
        }

        public void AddTask(TodoItem item)
        {
            using (var db = new TodoEntities())
            {
                db.TodoItemEntities.Add(item);
                db.SaveChanges();
            }
        }

        public void RemoveTask(TodoItem item)
        {
            using (var db = new TodoEntities())
            {
                db.TodoItemEntities.Remove(item);
                db.SaveChanges();
            }
        }

        public void UpdateTask(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public void MarkCompleted(TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}
