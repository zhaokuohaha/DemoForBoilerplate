namespace DemoForBoilerplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangDateTypeForId : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.People", newName: "MyPersons");
            RenameTable(name: "dbo.Tasks", newName: "MyTasks");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.MyTasks", newName: "Tasks");
            RenameTable(name: "dbo.MyPersons", newName: "People");
        }
    }
}
