namespace PresenterData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class paperscore2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Presenters", "Nominate", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Presenters", "Nominate", c => c.Int(nullable: false));
        }
    }
}
