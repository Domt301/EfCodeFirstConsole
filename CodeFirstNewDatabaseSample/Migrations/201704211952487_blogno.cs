namespace CodeFirstNewDatabaseSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blogno : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "BlogNo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "BlogNo");
        }
    }
}
