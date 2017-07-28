namespace MVP_TodoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTaskCreateDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TodoItems", "CreateDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TodoItems", "CreateDate");
        }
    }
}
