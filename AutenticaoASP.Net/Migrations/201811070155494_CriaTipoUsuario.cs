namespace AutenticaoASP.Net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriaTipoUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "Tipo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "Tipo");
            
        }
    }
}
