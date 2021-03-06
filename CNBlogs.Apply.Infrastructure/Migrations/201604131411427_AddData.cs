namespace CNBlogs.Apply.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JsPermissionApplys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Reason = c.String(nullable: false, maxLength: 3000),
                        UserId = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Ip = c.String(maxLength: 50),
                        ApplyTime = c.DateTime(nullable: false),
                        ReplyContent = c.String(maxLength: 3000),
                        ApprovedTime = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.JsPermissionApplys");
        }
    }
}
