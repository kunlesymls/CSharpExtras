namespace DatabaseFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TodoTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Todoes",
                c => new
                    {
                        TodoId = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        IsComplted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TodoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Todoes");
        }
    }
}
