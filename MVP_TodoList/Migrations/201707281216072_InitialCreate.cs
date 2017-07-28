namespace MVP_TodoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TodoItems",
                c => new
                    {
                        TaskID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        IsCompleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TaskID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TodoItems");
        }
    }
}
