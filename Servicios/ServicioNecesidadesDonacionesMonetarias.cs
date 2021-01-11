using ayudarApp.Dao;
using ayudarApp.Entidades;

namespace ayudarApp.Servicios
{
    public class ServicioNecesidadesDonacionesMonetarias
    {
        NecesidadesDonacionesMonetariasDAO NecesidadesDonacionesMonetariasDAO;

        public ServicioNecesidadesDonacionesMonetarias(TpDBContext context)
        {
            NecesidadesDonacionesMonetariasDAO = new NecesidadesDonacionesMonetariasDAO(context);
        }
    }
}