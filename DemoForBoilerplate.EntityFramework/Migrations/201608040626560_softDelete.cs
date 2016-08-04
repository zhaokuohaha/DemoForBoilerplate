namespace DemoForBoilerplate.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class softDelete : DbMigration
    {
        public override void Up()
        {
            AlterTableAnnotations(
                "dbo.MyTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssignedPersonId = c.Int(),
                        Description = c.String(),
                        State = c.Byte(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "DynamicFilter_MyTask_SoftDelete",
                        new AnnotationValues(oldValue: null, newValue: "EntityFramework.DynamicFilters.DynamicFilterDefinition")
                    },
                });
            
            AddColumn("dbo.MyTasks", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MyTasks", "IsDeleted");
            AlterTableAnnotations(
                "dbo.MyTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssignedPersonId = c.Int(),
                        Description = c.String(),
                        State = c.Byte(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "DynamicFilter_MyTask_SoftDelete",
                        new AnnotationValues(oldValue: "EntityFramework.DynamicFilters.DynamicFilterDefinition", newValue: null)
                    },
                });
            
        }
    }
}
