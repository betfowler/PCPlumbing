namespace PCPlumbing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class image : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Images", "ImageBefore", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Images", "ImageBefore");
        }
    }
}
