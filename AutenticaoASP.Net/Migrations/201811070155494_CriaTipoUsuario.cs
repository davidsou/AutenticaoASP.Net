namespace AutenticaoASP.Net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriaTipoUsuario : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuarios", "Tipo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "Tipo", c => c.Int(nullable: false));
        }
    }
}
