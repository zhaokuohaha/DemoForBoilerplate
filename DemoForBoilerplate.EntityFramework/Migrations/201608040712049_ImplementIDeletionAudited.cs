namespace DemoForBoilerplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImplementIDeletionAudited : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MyTasks", "DeleterUserId", c => c.Long());
            AddColumn("dbo.MyTasks", "DeletionTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MyTasks", "DeletionTime");
            DropColumn("dbo.MyTasks", "DeleterUserId");
        }
    }
}
