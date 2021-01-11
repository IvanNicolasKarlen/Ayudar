﻿using ayudarApp.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ayudarApp.Entidades.View_Model
{
    public class VMNecesidades
    {
        public int IdNecesidad { get; set; }
        public string Nombre { get; set; }
        public TipoDonacion TipoDonacion { get; set; }
        public TipoEstadoNecesidad Estado { get; set; }
        public decimal TotalDineroRecaudado { get; set; }
        public List<DonacionesInsumosVM> DonacionesInsumos { get; set; }
        public List<DonacionesInsumos> MisDonacionesInsumos { get; set; }
        public List<DonacionesMonetarias> MisDonacionesMonetarias { get; set; }
        public decimal TotalDineroDonado { get; set; }
    }
}