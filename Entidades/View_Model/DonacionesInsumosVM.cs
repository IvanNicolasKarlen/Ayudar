using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ayudarApp.Entidades.View_Model
{
    public class DonacionesInsumosVM
    {
        public string NombreNecesidadInsumos { get; set; }
        public int TotalRecaudado { get; set; }
        public DonacionesInsumosVM()
        {
            this.TotalRecaudado = 0;
        }
    }
}