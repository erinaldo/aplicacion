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
    
    public partial class ZONA_PERSONAL
    {
        public string Zona { get; set; }
        public string Personal { get; set; }
        public Nullable<System.DateTime> Dia { get; set; }
        public byte Numero { get; set; }
    
        public virtual PERSONAL PERSONAL1 { get; set; }
        public virtual ZONA ZONA1 { get; set; }
    }
}