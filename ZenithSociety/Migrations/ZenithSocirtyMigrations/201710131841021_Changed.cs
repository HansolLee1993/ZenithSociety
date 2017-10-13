namespace ZenithSociety.Migrations.ZenithSocirtyMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ActivityCategories", "ActivityDescription", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "EnteredUserName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "EnteredUserName", c => c.String());
            AlterColumn("dbo.ActivityCategories", "ActivityDescription", c => c.String());
        }
    }
}
