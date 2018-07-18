namespace PresenterData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePresenterTable2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Presenters", "SessionId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Presenters", "SessionId");
        }
    }
}
