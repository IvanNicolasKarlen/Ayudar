using ayudarApp.Dao;
using ayudarApp.Entidades;
using System;

namespace ayudarApp.Servicios
{
    public class ServicioDonacionInsumo
    {
        DonacionInsumosDao DonacionInsumosDao;
        public ServicioDonacionInsumo(TpDBContext context)
        {
            DonacionInsumosDao = new DonacionInsumosDao(context);
        }

        public DonacionesInsumos GuardarCantidadDonada(DonacionesInsumos donacionesI, int idUsuario)
        {
            donacionesI.IdUsuario = idUsuario;
            donacionesI.FechaCreacion = DateTime.Now;

            return DonacionInsumosDao.Guardar(donacionesI);
        }
    }
}