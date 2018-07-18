namespace PresenterData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePresenterTable4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Presenters", "NMarked", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Presenters", "NMarked");
        }
    }
}
