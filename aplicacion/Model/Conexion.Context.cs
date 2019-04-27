﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace xtraForm.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LiderAppEntities : DbContext
    {
        public LiderAppEntities()
            : base("name=LiderAppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PERSONAL> PERSONAL { get; set; }
        public virtual DbSet<FORMAPAGO> FORMAPAGO { get; set; }
        public virtual DbSet<DETPEDIDO> DETPEDIDO { get; set; }
        public virtual DbSet<ZONA> ZONA { get; set; }
        public virtual DbSet<ZONA_PERSONAL> ZONA_PERSONAL { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<provincia> provincia { get; set; }
        public virtual DbSet<Distrito> Distrito { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<PEDIDO> PEDIDO { get; set; }
        public virtual DbSet<REPARTO> REPARTO { get; set; }
        public virtual DbSet<Filtro> Filtro { get; set; }
        public virtual DbSet<categoria> categoria { get; set; }
        public virtual DbSet<grupo> grupo { get; set; }
        public virtual DbSet<LINEA> LINEA { get; set; }
        public virtual DbSet<MARCA> MARCA { get; set; }
        public virtual DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public virtual DbSet<FiltroConfiguracion> FiltroConfiguracion { get; set; }
        public virtual DbSet<Clase_Producto> Clase_Producto { get; set; }
        public virtual DbSet<PlantillaUnidad> PlantillaUnidad { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTO { get; set; }
        public virtual DbSet<Vva_Producto> Vva_Producto { get; set; }
        public virtual DbSet<RUTAS> RUTAS { get; set; }
        public virtual DbSet<Vva_Vendedor> Vva_Vendedor { get; set; }
        public virtual DbSet<FuerzaVentas> FuerzaVentas { get; set; }
        public virtual DbSet<DOCTIPO> DOCTIPO { get; set; }
        public virtual DbSet<Vva_ItemPedido> Vva_ItemPedido { get; set; }
        public virtual DbSet<Vva_Pedido> Vva_Pedido { get; set; }
        public virtual DbSet<Gestion> Gestion { get; set; }
    
        public virtual ObjectResult<Nullable<System.DateTime>> sp_stock_sistema(Nullable<System.DateTime> fecha, Nullable<int> tipo)
        {
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var tipoParameter = tipo.HasValue ?
                new ObjectParameter("tipo", tipo) :
                new ObjectParameter("tipo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("sp_stock_sistema", fechaParameter, tipoParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> sp_stock_sistema_web(Nullable<System.DateTime> fecha, Nullable<byte> tipo)
        {
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var tipoParameter = tipo.HasValue ?
                new ObjectParameter("tipo", tipo) :
                new ObjectParameter("tipo", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("sp_stock_sistema_web", fechaParameter, tipoParameter);
        }
    
        public virtual ObjectResult<string> FacturarcionPorRutas(string ruta, Nullable<System.DateTime> fecha, string gestion)
        {
            var rutaParameter = ruta != null ?
                new ObjectParameter("Ruta", ruta) :
                new ObjectParameter("Ruta", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            var gestionParameter = gestion != null ?
                new ObjectParameter("Gestion", gestion) :
                new ObjectParameter("Gestion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("FacturarcionPorRutas", rutaParameter, fechaParameter, gestionParameter);
        }
    
        public virtual int sp_genera_documento(string pedido, Nullable<int> tipo, string tdoc)
        {
            var pedidoParameter = pedido != null ?
                new ObjectParameter("pedido", pedido) :
                new ObjectParameter("pedido", typeof(string));
    
            var tipoParameter = tipo.HasValue ?
                new ObjectParameter("tipo", tipo) :
                new ObjectParameter("tipo", typeof(int));
    
            var tdocParameter = tdoc != null ?
                new ObjectParameter("tdoc", tdoc) :
                new ObjectParameter("tdoc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_genera_documento", pedidoParameter, tipoParameter, tdocParameter);
        }
    }
}
