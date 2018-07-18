namespace PresenterData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePresenterTable3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Presenters", "PaperTitle", c => c.String(nullable: false));
            AlterColumn("dbo.Presenters", "PaperId", c => c.Int(nullable: false));
            CreateIndex("dbo.Presenters", "PaperId", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Presenters", new[] { "PaperId" });
            AlterColumn("dbo.Presenters", "PaperId", c => c.String(nullable: false));
            DropColumn("dbo.Presenters", "PaperTitle");
        }
    }
}
