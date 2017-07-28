namespace MVP_TodoList.DataModel
{
    using MVP_TodoList.Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TodoEntities : DbContext
    {
        // Your context has been configured to use a 'TodoEntities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MVP_TodoList.DataModel.TodoEntities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TodoEntities' 
        // connection string in the application configuration file.
        public TodoEntities()
            : base("name=TodoEntities")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<TodoItem> TodoItemEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}