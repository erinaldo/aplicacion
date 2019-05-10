//------------------------------------------------------------------------------
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
    using System.Collections.Generic;

    public partial class DETADOC
    {
        public string Documento { get; set; }
        public string TipoDoc { get; set; }
        public string Producto { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> PrecUnit { get; set; }
        public Nullable<decimal> Igv { get; set; }
        public decimal PrecProm { get; set; }
        public string Estado { get; set; }
        public decimal Comision { get; set; }
        public decimal Costo { get; set; }
        public string TipoPrecio { get; set; }
        public decimal trangratuita { get; set; }
        public Nullable<decimal> pdscto { get; set; }
        public Nullable<decimal> totdscto { get; set; }
        public decimal percepcion { get; set; }
        public string lote { get; set; }
        public Nullable<System.DateTime> fvctolote { get; set; }
        public decimal detraccion { get; set; }
        public Nullable<decimal> ivap { get; set; }
        public decimal tg { get; set; }
        public Nullable<int> IDBonificacion { get; set; }
        public Nullable<decimal> PrecioUnitario { get; set; }
        public Nullable<decimal> PrecioNeto { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<decimal> Recargo { get; set; }
        public Nullable<bool> Afecto { get; set; }
        public Nullable<bool> Bonif { get; set; }

        public virtual PRODUCTO PRODUCTO1 { get; set; }
        public virtual Bonificacion Bonificacion { get; set; }
        public virtual DOCUMENTO DOCUMENTO1 { get; set; }
    }
}
