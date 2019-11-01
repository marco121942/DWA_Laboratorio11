namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StundentID = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false),
                        StudentName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        FechaCreacion = c.DateTime(),
                        FechaModificacion = c.DateTime(),
                        StudentAddress = c.String(nullable: false),
                        Activo = c.Boolean(),
                    })
                .PrimaryKey(t => t.StundentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
