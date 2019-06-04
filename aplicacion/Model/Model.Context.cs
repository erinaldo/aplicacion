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
    
    public partial class LiderEntities : DbContext
    {
        public LiderEntities()
            : base("name=LiderEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clase_Producto> Clase_Producto { get; set; }
        public virtual DbSet<CLIENTE> CLIENTEs { get; set; }
        public virtual DbSet<Departamento> Departamentoes { get; set; }
        public virtual DbSet<DETADOC> DETADOCs { get; set; }
        public virtual DbSet<Distrito> Distritoes { get; set; }
        public virtual DbSet<DOCUMENTO> DOCUMENTOes { get; set; }
        public virtual DbSet<FORMAPAGO> FORMAPAGOes { get; set; }
        public virtual DbSet<FuerzaVenta> FuerzaVentas { get; set; }
        public virtual DbSet<Gestion> Gestions { get; set; }
        public virtual DbSet<LINEA> LINEAs { get; set; }
        public virtual DbSet<MARCA> MARCAs { get; set; }
        public virtual DbSet<Modulo> Moduloes { get; set; }
        public virtual DbSet<PEDIDO> PEDIDOes { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTOes { get; set; }
        public virtual DbSet<PROVEEDOR> PROVEEDORs { get; set; }
        public virtual DbSet<provincia> provincias { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<REPARTO> REPARTOes { get; set; }
        public virtual DbSet<RUTA> RUTAS { get; set; }
        public virtual DbSet<TIPONEG> TIPONEGs { get; set; }
        public virtual DbSet<tipoprecio> tipoprecios { get; set; }
        public virtual DbSet<ZONA_PERSONAL> ZONA_PERSONAL { get; set; }
        public virtual DbSet<VistaAdministrativa> VistaAdministrativas { get; set; }
        public virtual DbSet<Vva_Cliente> Vva_Cliente { get; set; }
        public virtual DbSet<grupo> grupoes { get; set; }
        public virtual DbSet<categoria> categorias { get; set; }
        public virtual DbSet<PlantillaUnidad> PlantillaUnidads { get; set; }
        public virtual DbSet<ItemBonificacion> ItemBonificacions { get; set; }
        public virtual DbSet<TipoAsociado> TipoAsociadoes { get; set; }
        public virtual DbSet<INFREPARTO> INFREPARTOes { get; set; }
        public virtual DbSet<infrepartocab> infrepartocabs { get; set; }
        public virtual DbSet<TIPOCLI> TIPOCLIs { get; set; }
        public virtual DbSet<ZONA> ZONAs { get; set; }
        public virtual DbSet<ClienteZona> ClienteZonas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuarioPerfil> UsuarioPerfils { get; set; }
        public virtual DbSet<UsuarioPermiso> UsuarioPermisoes { get; set; }
        public virtual DbSet<Perfil> Perfils { get; set; }
        public virtual DbSet<Permiso> Permisoes { get; set; }
        public virtual DbSet<Filtro> Filtroes { get; set; }
        public virtual DbSet<FiltroConfiguracion> FiltroConfiguracions { get; set; }
        public virtual DbSet<Bonificacion> Bonificacions { get; set; }
        public virtual DbSet<TipoBonificacion> TipoBonificacions { get; set; }
        public virtual DbSet<DOCTIPO> DOCTIPOes { get; set; }
        public virtual DbSet<PERSONAL> PERSONALs { get; set; }
        public virtual DbSet<DETPEDIDO> DETPEDIDOes { get; set; }
    
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
