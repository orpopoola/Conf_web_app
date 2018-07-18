namespace PresenterData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePresenterTable5 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Presenters", new[] { "PaperId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Presenters", "PaperId", unique: true);
        }
    }
}
