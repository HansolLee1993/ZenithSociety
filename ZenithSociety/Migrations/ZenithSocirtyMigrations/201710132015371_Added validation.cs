namespace ZenithSociety.Migrations.ZenithSocirtyMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedvalidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "EnteredUserName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "EnteredUserName", c => c.String(nullable: false));
        }
    }
}
