using ayudarApp.Entidades;
using ayudarApp.Entidades.Utilities;
using ayudarApp.Entidades.View_Model;
using ayudarApp.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ayudarApp.Controllers
{
    public class DonacionMonetariaController : Controller
    {
        ServicioDonacionMonetaria servicioDonacion;
        ServicioNecesidad servicioNecesidad;
        ServicioNecesidadesDonacionesMonetarias servicioNecesidadesDonacionesMonetarias;
        public DonacionMonetariaController()
        {
            TpDBContext context = new TpDBContext();
            servicioDonacion = new ServicioDonacionMonetaria(context);
            servicioNecesidad = new ServicioNecesidad(context);
            servicioNecesidadesDonacionesMonetarias = new ServicioNecesidadesDonacionesMonetarias(context);
        }

        //Muestra la lista: CBU, MONTO SOLICITADO Y MONTO RESTANTE.
        public ActionResult DetalleDeDonacion(int idNecesidad)
        {
            Necesidades necesidades = servicioNecesidad.obtenerNecesidadPorId(idNecesidad);
            return View(necesidades);
        }

        //Pasa el idNecesidadDonacionMonetaria por el boton donar. 
        //DonaMonetaria ingreso el monto a donar
      
        [HttpGet]
        public ActionResult DonaMonetaria(int idNecesidadDonacionMonetaria)
        {
            VMDonacionMonetaria vmDonacionMonetaria = new VMDonacionMonetaria();
            vmDonacionMonetaria.IdNecesidadDonacionMonetaria = idNecesidadDonacionMonetaria;

            return View(vmDonacionMonetaria);
        }


        [HttpPost]
        public ActionResult DonaMonetaria(VMDonacionMonetaria DMonetarias)

        {
            DonacionesMonetarias donacionM = new DonacionesMonetarias();

            try
            {
                if (!ModelState.IsValid)
                {
                    return View(DMonetarias);
                }
                else
                {
                    int idUsuario = int.Parse(Session["UserId"].ToString());
                    donacionM = servicioDonacion.GuardarDonacionM(DMonetarias, idUsuario);
                }

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error: ", ex.Message);
            }

            VMComprobantePago vmComprobantePago = new VMComprobantePago();
            vmComprobantePago.IdDonacionMonetaria = donacionM.IdDonacionMonetaria;

            return View("SeleccionComprobanteDePago", vmComprobantePago);
        }

        [HttpGet]
        public ActionResult SeleccionComprobanteDePago()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SeleccionComprobanteDePago(VMComprobantePago donacionesM)
        {
            DonacionesMonetarias comprobante = new DonacionesMonetarias();
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                else
                {
                    if (Request.Files.Count > 0 && Request.Files[0].ContentLength > 0)
                    {
                        int idUsuario = int.Parse(Session["UserId"].ToString());
                        string nombreSignificativo = idUsuario + " " + Session["Email"];
                        //Guardar Imagen
                        string pathRelativoImagen = ImagenesUtil.Guardar(Request.Files[0], nombreSignificativo);
                        donacionesM.ArchivoTransferencia = pathRelativoImagen;
                    }
                }
                comprobante = servicioDonacion.Actualizar(donacionesM);
                TempData["Mensaje"] = "Gracias por su donación"; //Creo el TempData son el mensaje. Este TempData lo uso en la vista.
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error: ", ex.Message);
            }
            return RedirectToAction("DetalleDeDonacion", new { comprobante.NecesidadesDonacionesMonetarias.IdNecesidad });
        }
    }
}