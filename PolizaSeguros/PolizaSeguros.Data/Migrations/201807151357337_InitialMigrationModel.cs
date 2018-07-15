namespace PolizaSeguros.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigrationModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientePoliza",
                c => new
                    {
                        IdClientePoliza = c.Int(nullable: false, identity: true),
                        IdCliente = c.Int(nullable: false),
                        IdPoliza = c.Int(nullable: false),
                        IdEstado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdClientePoliza)
                .ForeignKey("dbo.Cliente", t => t.IdCliente)
                .ForeignKey("dbo.Estado", t => t.IdEstado)
                .ForeignKey("dbo.Poliza", t => t.IdPoliza)
                .Index(t => t.IdCliente)
                .Index(t => t.IdPoliza)
                .Index(t => t.IdEstado);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        NombreCiente = c.String(),
                        IdTipoDocumento = c.Int(nullable: false),
                        TipoRiesgo_IdTipoRiesgo = c.Int(),
                    })
                .PrimaryKey(t => t.IdCliente)
                .ForeignKey("dbo.TipoDocumento", t => t.IdTipoDocumento)
                .ForeignKey("dbo.TipoRiesgo", t => t.TipoRiesgo_IdTipoRiesgo)
                .Index(t => t.IdTipoDocumento)
                .Index(t => t.TipoRiesgo_IdTipoRiesgo);
            
            CreateTable(
                "dbo.TipoDocumento",
                c => new
                    {
                        IdTipoDocumento = c.Int(nullable: false, identity: true),
                        NombreTipoDocumento = c.String(),
                    })
                .PrimaryKey(t => t.IdTipoDocumento);
            
            CreateTable(
                "dbo.Estado",
                c => new
                    {
                        IdEstado = c.Int(nullable: false, identity: true),
                        NombreEstado = c.String(),
                    })
                .PrimaryKey(t => t.IdEstado);
            
            CreateTable(
                "dbo.Poliza",
                c => new
                    {
                        IdPoliza = c.Int(nullable: false, identity: true),
                        NombrePoliza = c.String(),
                        DescripcionPoliza = c.String(),
                        FechaInicioVigencia = c.DateTime(nullable: false),
                        PrecioPoliza = c.Int(nullable: false),
                        IdTipoRiesgo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdPoliza)
                .ForeignKey("dbo.TipoRiesgo", t => t.IdTipoRiesgo)
                .Index(t => t.IdTipoRiesgo);
            
            CreateTable(
                "dbo.PolizaTipoCubrimiento",
                c => new
                    {
                        IdPolizaCubrimiento = c.Int(nullable: false, identity: true),
                        IdPoliza = c.Int(nullable: false),
                        IdTipoCubrimiento = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdPolizaCubrimiento)
                .ForeignKey("dbo.Poliza", t => t.IdPoliza)
                .ForeignKey("dbo.TipoCubrimiento", t => t.IdTipoCubrimiento)
                .Index(t => t.IdPoliza)
                .Index(t => t.IdTipoCubrimiento);
            
            CreateTable(
                "dbo.TipoCubrimiento",
                c => new
                    {
                        IdTipoCubrimiento = c.Int(nullable: false, identity: true),
                        NombreCubrimiento = c.String(),
                    })
                .PrimaryKey(t => t.IdTipoCubrimiento);
            
            CreateTable(
                "dbo.TipoRiesgo",
                c => new
                    {
                        IdTipoRiesgo = c.Int(nullable: false, identity: true),
                        NombreTipoRiesgo = c.String(),
                    })
                .PrimaryKey(t => t.IdTipoRiesgo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientePoliza", "IdPoliza", "dbo.Poliza");
            DropForeignKey("dbo.Poliza", "IdTipoRiesgo", "dbo.TipoRiesgo");
            DropForeignKey("dbo.Cliente", "TipoRiesgo_IdTipoRiesgo", "dbo.TipoRiesgo");
            DropForeignKey("dbo.PolizaTipoCubrimiento", "IdTipoCubrimiento", "dbo.TipoCubrimiento");
            DropForeignKey("dbo.PolizaTipoCubrimiento", "IdPoliza", "dbo.Poliza");
            DropForeignKey("dbo.ClientePoliza", "IdEstado", "dbo.Estado");
            DropForeignKey("dbo.ClientePoliza", "IdCliente", "dbo.Cliente");
            DropForeignKey("dbo.Cliente", "IdTipoDocumento", "dbo.TipoDocumento");
            DropIndex("dbo.PolizaTipoCubrimiento", new[] { "IdTipoCubrimiento" });
            DropIndex("dbo.PolizaTipoCubrimiento", new[] { "IdPoliza" });
            DropIndex("dbo.Poliza", new[] { "IdTipoRiesgo" });
            DropIndex("dbo.Cliente", new[] { "TipoRiesgo_IdTipoRiesgo" });
            DropIndex("dbo.Cliente", new[] { "IdTipoDocumento" });
            DropIndex("dbo.ClientePoliza", new[] { "IdEstado" });
            DropIndex("dbo.ClientePoliza", new[] { "IdPoliza" });
            DropIndex("dbo.ClientePoliza", new[] { "IdCliente" });
            DropTable("dbo.TipoRiesgo");
            DropTable("dbo.TipoCubrimiento");
            DropTable("dbo.PolizaTipoCubrimiento");
            DropTable("dbo.Poliza");
            DropTable("dbo.Estado");
            DropTable("dbo.TipoDocumento");
            DropTable("dbo.Cliente");
            DropTable("dbo.ClientePoliza");
        }
    }
}
