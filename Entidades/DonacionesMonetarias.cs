//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ayudarApp.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class DonacionesMonetarias
    {
        public int IdDonacionMonetaria { get; set; }
        public int IdNecesidadDonacionMonetaria { get; set; }
        public int IdUsuario { get; set; }
        public decimal Dinero { get; set; }
        public string ArchivoTransferencia { get; set; }
        public System.DateTime FechaCreacion { get; set; }
    
        public virtual NecesidadesDonacionesMonetarias NecesidadesDonacionesMonetarias { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
