namespace PolizaSeguros.Data.Migrations
{
	using PolizaSeguros.Model.Model;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PolizaSeguros.Data.PSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PolizaSeguros.Data.PSContext context)
        {

			if (context.TipoCubrimientos.Count() == 0)
			{
				context.TipoCubrimientos.AddRange(new List<TipoCubrimiento>()
				{
					new TipoCubrimiento(){ NombreCubrimiento = "Terremoto"},
					new TipoCubrimiento(){ NombreCubrimiento = "Incendio"},
					new TipoCubrimiento(){ NombreCubrimiento = "Robo"},
					new TipoCubrimiento(){ NombreCubrimiento = "Pérdida"}
				});
			}

			if (context.TipoDocumentos.Count() == 0)
			{
				context.TipoDocumentos.AddRange(new List<TipoDocumento>()
				{
					new TipoDocumento(){ NombreTipoDocumento = "CC"},
					new TipoDocumento(){ NombreTipoDocumento = "CE"},
					new TipoDocumento(){ NombreTipoDocumento = "TI"},
					new TipoDocumento(){ NombreTipoDocumento = "NIT"}
				});
			}

			if (context.Estados.Count() == 0)
			{
				context.Estados.AddRange(new List<Estado>()
				{
					new Estado() { NombreEstado = "Asignada"},
					new Estado() { NombreEstado = "Cancelada"}
				});
			}

			if (context.TipoRiesgos.Count() == 0)
			{
				context.TipoRiesgos.AddRange(new List<TipoRiesgo>()
				{
					new TipoRiesgo() { NombreTipoRiesgo = "Bajo"},
					new TipoRiesgo() { NombreTipoRiesgo = "Medio"},
					new TipoRiesgo() { NombreTipoRiesgo = "Medio-Alto"},
					new TipoRiesgo() { NombreTipoRiesgo = "Alto"}
				});
			}
		}
    }
}
