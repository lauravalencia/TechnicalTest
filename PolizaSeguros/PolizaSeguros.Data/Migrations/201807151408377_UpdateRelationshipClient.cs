namespace PolizaSeguros.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRelationshipClient : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cliente", "TipoRiesgo_IdTipoRiesgo", "dbo.TipoRiesgo");
            DropIndex("dbo.Cliente", new[] { "TipoRiesgo_IdTipoRiesgo" });
            DropColumn("dbo.Cliente", "TipoRiesgo_IdTipoRiesgo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cliente", "TipoRiesgo_IdTipoRiesgo", c => c.Int());
            CreateIndex("dbo.Cliente", "TipoRiesgo_IdTipoRiesgo");
            AddForeignKey("dbo.Cliente", "TipoRiesgo_IdTipoRiesgo", "dbo.TipoRiesgo", "IdTipoRiesgo");
        }
    }
}
