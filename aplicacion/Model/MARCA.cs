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
    
    public partial class MARCA
    {
        public string Marca1 { get; set; }
        public string Proveedor { get; set; }
        public string Linea { get; set; }
        public string Descripcion { get; set; }
        public string Descorta { get; set; }
        public string Orden { get; set; }
    
        public virtual LINEA LINEA1 { get; set; }
    }
}
