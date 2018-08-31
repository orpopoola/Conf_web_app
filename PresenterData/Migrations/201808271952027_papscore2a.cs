namespace PresenterData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class papscore2a : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Presenters", "Nominate", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Presenters", "Nominate", c => c.Boolean(nullable: false));
        }
    }
}
