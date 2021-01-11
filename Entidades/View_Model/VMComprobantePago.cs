using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ayudarApp.Entidades.View_Model
{
    public class VMComprobantePago
    {
        [Required]
        public string ArchivoTransferencia { get; set; }

        public int IdDonacionMonetaria { get; set; }
    }
}