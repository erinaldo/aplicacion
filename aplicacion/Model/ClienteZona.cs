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
    
    public partial class ClienteZona
    {
        public int PKID { get; set; }
        public string IDCliente { get; set; }
        public string IDZona { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual ZONA ZONA { get; set; }
    }
}
