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
    
    public partial class PRODUCTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCTO()
        {
            this.DETPEDIDO = new HashSet<DETPEDIDO>();
            this.DETADOC = new HashSet<DETADOC>();
        }
    
        public string Producto1 { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public bool ConIgv { get; set; }
        public Nullable<decimal> StockMin { get; set; }
        public Nullable<decimal> StockMax { get; set; }
        public decimal StockAc { get; set; }
        public decimal StockDia { get; set; }
        public Nullable<decimal> PrecMayContado { get; set; }
        public Nullable<decimal> PrecMenContado { get; set; }
        public Nullable<decimal> PrecMayCredito { get; set; }
        public Nullable<decimal> PrecMenCredito { get; set; }
        public Nullable<decimal> PrecEspecial { get; set; }
        public Nullable<int> CanEspecial { get; set; }
        public string CodAlterno { get; set; }
        public Nullable<decimal> Peso { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public string UniMed { get; set; }
        public bool Activo { get; set; }
        public int Unidades { get; set; }
        public decimal StockMal { get; set; }
        public string ean13 { get; set; }
        public string grupo { get; set; }
        public decimal stkbafecha { get; set; }
        public decimal stkmafecha { get; set; }
        public decimal comimayor { get; set; }
        public decimal comimenor { get; set; }
        public decimal credmayor { get; set; }
        public decimal credmenor { get; set; }
        public string codbase { get; set; }
        public string proveedor { get; set; }
        public string linea { get; set; }
        public string marcas { get; set; }
        public decimal minimomay { get; set; }
        public string categoria { get; set; }
        public string ncodigo { get; set; }
        public string nunimed { get; set; }
        public Nullable<decimal> PrecSEspecial { get; set; }
        public bool percepcion { get; set; }
        public decimal priesgomaycon { get; set; }
        public decimal priesgomencon { get; set; }
        public decimal priesgomaycre { get; set; }
        public decimal priesgomencre { get; set; }
        public decimal costorep { get; set; }
        public decimal PrecSSEspecial { get; set; }
        public decimal comiespecial { get; set; }
        public decimal comisespecial { get; set; }
        public bool detraccion { get; set; }
        public decimal pdetraccion { get; set; }
        public bool conivap { get; set; }
        public string Meta_Cant { get; set; }
        public string Meta { get; set; }
        public string sku { get; set; }
        public Nullable<int> factor { get; set; }
        public string clase_producto { get; set; }
        public string Orden { get; set; }
        public string CodigoUM { get; set; }
        public string IdClaseBSC { get; set; }
        public Nullable<int> FP { get; set; }
        public Nullable<bool> StatusWeb { get; set; }
        public Nullable<bool> StatusDms { get; set; }
        public Nullable<bool> ArticuloVenta { get; set; }
        public Nullable<bool> ArticuloCompra { get; set; }
        public Nullable<bool> ProductoCombo { get; set; }
        public Nullable<int> IDUnidad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETPEDIDO> DETPEDIDO { get; set; }
        public virtual MARCA MARCA1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETADOC> DETADOC { get; set; }
        public virtual Clase_Producto Clase_Producto1 { get; set; }
        public virtual PlantillaUnidad PlantillaUnidad { get; set; }
    }
}
